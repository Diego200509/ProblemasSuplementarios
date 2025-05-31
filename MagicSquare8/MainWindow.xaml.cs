using System.Windows;
using MagicSquare8.Implementations;
using MagicSquare8.Interfaces;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace MagicSquare8
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private const int N = 4;
        private readonly INumberGenerator _numberGenerator;
        private readonly IMagicSquareBuilder _builder;
        private static readonly Random _rnd = new Random();
        private TextBlock[,] _cellBlocks = new TextBlock[N, N];

        public MainWindow()
        {
            InitializeComponent();

            _numberGenerator = new SpecificDigitNumberGenerator(new[] { 5, 7 }, N);
            _builder = new BacktrackingMagicSquareBuilder(new SumValidator());
        }

        private void GenerateButton_Click(object sender, RoutedEventArgs e)
        {
            MagicGrid.Children.Clear();
            SumResultsPanel.Children.Clear();
            ClearHighlight();

            //Generar y construir
            var numbers = _numberGenerator
                            .Generate()
                            .OrderBy(x => _rnd.Next())
                            .ToList();
            var square = _builder.Build(numbers);

            if (square == null)
            {
                MessageBox.Show("No se encontró ninguna solución válida.",
                                "Aviso", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            //Pintar cuadrado y guardar referencias a cada celda
            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < N; col++)
                {
                    var cell = new TextBlock
                    {
                        Text = square[row, col].ToString(),
                        FontSize = 24,
                        FontWeight = FontWeights.Bold,
                        Background = Brushes.Transparent,
                        HorizontalAlignment = HorizontalAlignment.Center,
                        VerticalAlignment = VerticalAlignment.Center
                    };
                    _cellBlocks[row, col] = cell;
                    MagicGrid.Children.Add(cell);
                }
            }

            // Filas
            for (int i = 0; i < N; i++)
                AddSummaryLine(
                    $"Fila {i}: {Enumerable.Range(0, N).Sum(j => square[i, j].Value)}",
                    tag: $"Row:{i}"
                );

            // Columnas
            for (int j = 0; j < N; j++)
                AddSummaryLine(
                    $"Columna {j}: {Enumerable.Range(0, N).Sum(i => square[i, j].Value)}",
                    tag: $"Col:{j}"
                );

            // Diagonales
            AddSummaryLine(
                $"Diagonal principal: {Enumerable.Range(0, N).Sum(i => square[i, i].Value)}",
                tag: "Diag:0"
            );
            AddSummaryLine(
                $"Diagonal secundaria: {Enumerable.Range(0, N).Sum(i => square[i, N - 1 - i].Value)}",
                tag: "Diag:1"
            );
        }

        private void AddSummaryLine(string text, string tag)
        {
            var tb = new TextBlock
            {
                Text = text,
                Margin = new Thickness(2),
                Tag = tag,
                Cursor = Cursors.Hand
            };
            tb.MouseEnter += SummaryLine_MouseEnter;
            tb.MouseLeave += SummaryLine_MouseLeave;
            SumResultsPanel.Children.Add(tb);
        }

        private void SummaryLine_MouseEnter(object sender, MouseEventArgs e)
        {
            if (sender is not TextBlock tb || tb.Tag is not string tag) return;
            var parts = tag.Split(':');
            var type = parts[0];
            var idx = int.Parse(parts[1]);
            Highlight(type, idx);
        }

        private void SummaryLine_MouseLeave(object sender, MouseEventArgs e)
        {
            ClearHighlight();
        }

        private void Highlight(string type, int idx)
        {
            ClearHighlight();
            switch (type)
            {
                case "Row":
                    for (int c = 0; c < N; c++)
                        _cellBlocks[idx, c].Background = Brushes.LightYellow;
                    break;
                case "Col":
                    for (int r = 0; r < N; r++)
                        _cellBlocks[r, idx].Background = Brushes.LightYellow;
                    break;
                case "Diag":
                    if (idx == 0)
                        for (int i = 0; i < N; i++)
                            _cellBlocks[i, i].Background = Brushes.LightYellow;
                    else
                        for (int i = 0; i < N; i++)
                            _cellBlocks[i, N - 1 - i].Background = Brushes.LightYellow;
                    break;
            }
        }

        private void ClearHighlight()
        {
            for (int r = 0; r < N; r++)
            {
                for (int c = 0; c < N; c++)
                {
                    var cell = _cellBlocks[r, c];
                    if (cell != null)
                        cell.Background = Brushes.Transparent;
                }
            }
        }
    }
}