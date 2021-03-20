using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PDA2._0_
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            TimeDate();
        }

        private void OffButton_Click(object sender, System.Windows.RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }


        private void TasksButton_Click(object sender, RoutedEventArgs e)
        {
            PageNameLabel.Content = "Задания";
            Main.Content = new TasksPage();
        }

        private void MapsButton_Click(object sender, RoutedEventArgs e)
        {
            PageNameLabel.Content = "Карта";
            Main.Content = new MapPage();
        }

        private void TimeDate()
        {
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 1);
            timer.IsEnabled = true;
            timer.Tick += (o, e) => { DateTimeLabel.Content = DateTime.Now.ToString("hh:mm:ss dd.MM.yyyy"); };
            timer.Start();
        }
    }
}
