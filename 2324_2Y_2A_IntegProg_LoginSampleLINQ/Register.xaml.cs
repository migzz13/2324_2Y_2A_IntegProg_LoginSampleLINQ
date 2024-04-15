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
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        public Register()
        {
            InitializeComponent();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MainWindow mw = new MainWindow();
            mw.Show();
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

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            PasswordBox.Text = "";
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBox.Text == "")
                PasswordBox.Text = "Password";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
