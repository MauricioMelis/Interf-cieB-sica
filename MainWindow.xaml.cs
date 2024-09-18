using System.Windows;
using System.Windows.Media;

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
            Botó2.Background = new SolidColorBrush(Colors.LightGreen);
            Botó1.Background = new SolidColorBrush(Colors.Red);
            Etiqueta.Foreground = new SolidColorBrush(Colors.Red);

        }

        private void Botó2_Click_1(object sender, RoutedEventArgs e)
        {
            Etiqueta.Content = "Hola, món!";
            Botó1.Background = new SolidColorBrush(Colors.LightGreen);
            Botó2.Background = new SolidColorBrush(Colors.Red);
            Etiqueta.Foreground = new SolidColorBrush(Colors.Green);
        }
    }
}