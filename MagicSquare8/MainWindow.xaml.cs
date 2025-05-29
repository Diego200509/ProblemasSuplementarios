using System.Windows;
using MagicSquare8.Implementations;
using MagicSquare8.Interfaces;
using System.Windows.Controls;

namespace MagicSquare8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private readonly INumberGenerator _numberGenerator;
        private readonly IMagicSquareBuilder _builder;

        public MainWindow()
        {
            InitializeComponent();

            _numberGenerator = new SpecificDigitNumberGenerator(new[] { 5, 7 }, 4);
            _builder = new BacktrackingMagicSquareBuilder(new SumValidator());
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            MagicGrid.Children.Clear();
            SumResultsText.Text = string.Empty;

            // 1) Genera y construye
            var numbers = _numberGenerator.Generate().ToList();
            var square = _builder.Build(numbers);

            if (square == null)
            {
                MessageBox.Show("No se encontró ninguna solución válida.",
                                "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // 2) Pinta el cuadrado
            const int n = 4;
            for (int fila = 0; fila < n; fila++)
                for (int col = 0; col < n; col++)
                {
                    var tb = new TextBlock
                    {
                        Text = square[fila, col].ToString(),
                        FontSize = 24,
                        FontWeight = FontWeights.Bold,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center
                    };
                    MagicGrid.Children.Add(tb);
                }

            // 3) Calcula y muestra las sumas
            var lines = new[]
            {
                // Suma target (opcional)
                $"Target (fila 0): {Enumerable.Range(0, n).Sum(j => square[0, j].Value)}",
            }.ToList();

            // Filas
            for (int i = 0; i < n; i++)
                lines.Add($"Fila {i}: {Enumerable.Range(0, n).Sum(j => square[i, j].Value)}");

            // Columnas
            for (int j = 0; j < n; j++)
                lines.Add($"Columna {j}: {Enumerable.Range(0, n).Sum(i => square[i, j].Value)}");

            // Diagonales
            lines.Add($"Diagonal principal: {Enumerable.Range(0, n).Sum(i => square[i, i].Value)}");
            lines.Add($"Diagonal secundaria: {Enumerable.Range(0, n).Sum(i => square[i, n - 1 - i].Value)}");

            // Une con saltos de línea
            SumResultsText.Text = string.Join("\n", lines);
        }
    }
}