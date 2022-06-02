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

namespace Wpf_Exam
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new PC_Access_ViewModel();
        }
        
        System.Windows.Threading.DispatcherTimer timer = new System.Windows.Threading.DispatcherTimer();
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            timer.Tick += new EventHandler(timerTick);
            timer.Interval = new TimeSpan(0, 0, 5);
            timer.Start();
        }
        public int chech_img = 1;
        private void timerTick(object sender, EventArgs e)
        {
            if (chech_img == 7)
            {
                chech_img = 1;
            }
            switch (chech_img)
            {
                case 1: img1.IsChecked = true;
                    break;
                case 2: img2.IsChecked = true;
                    break;
                case 3:img3.IsChecked = true;
                    break;
                case 4:img4.IsChecked = true;
                    break;
                case 5:img5.IsChecked = true;
                    break;
                case 6:img6.IsChecked = true;
                    break;
                default:
                    break;
            }
            chech_img++;
            
        }
    }
}
