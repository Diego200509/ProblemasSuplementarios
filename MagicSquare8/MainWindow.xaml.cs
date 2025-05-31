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
        private static readonly Random _rnd = new Random();

        public MainWindow()
        {
            InitializeComponent();

            _builder = new BacktrackingMagicSquareBuilder(new SumValidator());
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            MagicGrid.Children.Clear();
            SumResultsText.Text = string.Empty;

            // Genera dos dígitos aleatorios únicos entre 1 y 9
            var digits = new HashSet<int>();
            while (digits.Count < 2)
                digits.Add(_rnd.Next(1, 10));

            // Crea el generador dinámicamente en cada clic
            var numberGenerator = new SpecificDigitNumberGenerator(digits.ToArray(), 4);
            var numbers = numberGenerator.Generate().ToList()
                          .OrderBy(x => _rnd.Next()) // aleatoriza el orden
                          .ToList();

            var square = _builder.Build(numbers);

            if (square == null)
            {
                MessageBox.Show("No se encontró ninguna solución válida.",
                                "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            // Pinta el cuadrado
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

            // Calcula y muestra las sumas
            var lines = new List<string>();

            for (int i = 0; i < n; i++)
                lines.Add($"Fila {i}: {Enumerable.Range(0, n).Sum(j => square[i, j].Value)}");

            for (int j = 0; j < n; j++)
                lines.Add($"Columna {j}: {Enumerable.Range(0, n).Sum(i => square[i, j].Value)}");

            lines.Add($"Diagonal principal: {Enumerable.Range(0, n).Sum(i => square[i, i].Value)}");
            lines.Add($"Diagonal secundaria: {Enumerable.Range(0, n).Sum(i => square[i, n - 1 - i].Value)}");

            SumResultsText.Text = string.Join("\n", lines);
        }
    }
}