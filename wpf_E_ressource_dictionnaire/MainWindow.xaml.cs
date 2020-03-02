using System.Windows;
using System.Windows.Media;

namespace wpf_E_ressource_dictionnaire
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ChangeColor_Click(object sender, RoutedEventArgs e)
        {
            Color blue = (Color)Application.Current.Resources["BlueColour"];
            Application.Current.Resources["GreenBrush"] 
                = new SolidColorBrush(blue);
        }
    }
}
