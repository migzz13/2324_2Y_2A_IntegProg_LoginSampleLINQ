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
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
            WelcomeMessage.Content = "Welcome " + MainWindow.userName;
        }
        private void RegisterBtn_Click(object sender, RoutedEventArgs e)
        {
            Register w2 = new Register();
            w2.Show();
            this.Close();
        }

        private void ChangeUNameBtn_Click(object sender, RoutedEventArgs e)
        {
            ChangeName w3 = new ChangeName();
            w3.Show();
            this.Close();
        }
    }
}
