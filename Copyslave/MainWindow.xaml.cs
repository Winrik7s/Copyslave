using System.Windows;
using System.Windows.Threading;
using System.Windows.Forms;

namespace Copyslave
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer Timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Windows1_Loaded(object sender, RoutedEventArgs e)
        {
            Timer.Start();
        }
    }
}
