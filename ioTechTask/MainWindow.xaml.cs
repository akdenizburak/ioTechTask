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

namespace ioTechTask
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (chckboxOnOff.IsChecked == true)
            {
                chckboxOnOff.IsChecked = false;
                chckboxOnOff.Content = "Kapalı";
                SolidColorBrush brush = new SolidColorBrush();
                ellipseLed.Fill = brush;
                brush.Color = Color.FromArgb(255, 0, 0, 0);
            }
            else
            {
                chckboxOnOff.IsChecked = true;
                chckboxOnOff.Content = "Açık";
                SolidColorBrush brush = new SolidColorBrush();
                brush.Color = Color.FromArgb(255, 19, 255, 0);
                ellipseLed.Fill = brush;
            }
        }

        private void chckboxOnOff_Checked(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random random=new Random();
            
            txtbox.Text = random.Next(1000).ToString();
        }
    }
}
