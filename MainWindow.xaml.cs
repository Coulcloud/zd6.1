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

namespace interfaceWPF
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

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            int click = 0;
            click++;
            if (click == 1) 
            {
                this.Background = new SolidColorBrush(Color.FromArgb(255, 0, 255, 0));
            }
            if (click == 2) 
            {
                this.Background = new SolidColorBrush(Colors.Coral);
            }
            if (click == 3)
            {
                this.Background = new SolidColorBrush(Colors.DarkRed);
            }
            if (click == 4)
            {
                this.Background = new SolidColorBrush(Colors.LightSkyBlue);
            }

        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Стаховский Станилав Андреевич");
        }

        private void MenuItem_Click_2(object sender, RoutedEventArgs e)
        {
            this.Background = new SolidColorBrush(Color.FromArgb(0, 255, 255, 0));
            
        }

        private void MenuItem_Click_3(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Разработчик: Стаховский Станилав Андреевич");
           
        }

        private void MenuItem_Click_4(object sender, RoutedEventArgs e)
        {
            Close();
            
        }

        private void Button_MouseEnter(object sender, MouseEventArgs e)
        {
            status.Text = "Измение цвета фона";
         

        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {

        }
        private void updateFon_click(object sender, MouseEventArgs e) 
        {
            this.Background = new SolidColorBrush(Color.FromArgb(0, 255, 255, 0));
        }

        private void Button_MouseEnter_1(object sender, MouseEventArgs e)
        {
            status.Text = "Информация о разработчике";
        }

        private void Button_MouseEnter_2(object sender, MouseEventArgs e)
        {
            status.Text = "закрыть";
        }

        private void MenuItem_Click_5(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
