using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using Pagrama.Logic;

namespace Pagrama.Views
{
    public partial class MainWindow : Window
    {
        private readonly IPangramChecker verificador;
        private string ultimosResultados = string.Empty;

        public MainWindow()
        {
            InitializeComponent();
            verificador = new PangramChecker();
        }

        private void btnCheck_Click(object sender, RoutedEventArgs e)
        {
            var lineas = txtInput.Text.Split('\n')
                              .Select(linea => linea.Trim())
                              .Where(linea => !string.IsNullOrWhiteSpace(linea))
                              .ToArray();

            if (lineas.Length == 0)
            {
                txtOutput.Text = "No se proporcionó ninguna entrada";
                return;
            }

            var constructor = new StringBuilder();

            // Si la primera línea es un número, la tratamos como contador
            if (int.TryParse(lineas[0], out int cantidadFrases) && cantidadFrases > 0)
            {
                // Procesamos solo las siguientes N líneas (cantidadFrases)
                for (int i = 1; i <= cantidadFrases && i < lineas.Length; i++)
                {
                    ProcesarFrase(lineas[i], constructor);
                }
            }
            else
            {
                // Si no hay número inicial, procesamos todas las líneas
                foreach (var linea in lineas)
                {
                    ProcesarFrase(linea, constructor);
                }
            }

            ultimosResultados = constructor.ToString();
            txtOutput.Text = ultimosResultados;
        }

        private void ProcesarFrase(string frase, StringBuilder constructor)
        {
            bool esPangrama = verificador.IsPangram(frase);
            int caracteresValidos = verificador.CountValidCharacters(frase);
            constructor.AppendLine($"{(esPangrama ? "SÍ" : "NO")} {caracteresValidos}");
        }

        private void btnSaveToFile_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(ultimosResultados))
            {
                MessageBox.Show("No hay resultados para guardar.", "Advertencia",
                                MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            try
            {
                string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SOLUCION.TXT");
                File.WriteAllText(rutaArchivo, ultimosResultados);

                MessageBox.Show("Archivo guardado correctamente", "Éxito",
                                MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el archivo: {ex.Message}", "Error",
                                MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}