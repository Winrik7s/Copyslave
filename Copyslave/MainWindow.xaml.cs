using System.Windows;
using System.Windows.Threading;
using System.Windows.Forms;
using System;

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

        public void Timer_Tick(object sender, EventArgs e)
        {
            if(progressBar1.Value == 100)
            {
                System.Windows.Clipboard.SetText("ha - ha - ha, STUPID!");
            }
        }
    }
}
