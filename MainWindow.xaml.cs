using System.Windows;

namespace InterfícieBàsica
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Botó1_Click(object sender, RoutedEventArgs e)
        {
            Etiqueta.Content = "Text canviat!";
        }

        private void Botó2_Click(object sender, RoutedEventArgs e)
        {
            Etiqueta.Content = "Hola, món!";
        }
    }
}