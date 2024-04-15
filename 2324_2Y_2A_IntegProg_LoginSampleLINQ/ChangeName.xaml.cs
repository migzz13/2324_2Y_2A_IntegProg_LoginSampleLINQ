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
using System.Windows.Shapes;

namespace _2324_2Y_2A_IntegProg_LoginSampleLINQ
{
    /// <summary>
    /// Interaction logic for ChangeName.xaml
    /// </summary>
    public partial class ChangeName : Window
    {
        public ChangeName()
        {
            InitializeComponent();
        }
        private void UsernameBox_GotFocus(object sender, RoutedEventArgs e)
        {
            UsernameBox.Text = "";
        }

        private void UsernameBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (UsernameBox.Text == "")
                UsernameBox.Text = "Username";
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Window1 w1 = new Window1();
            w1.Show();
        }

    }
}
