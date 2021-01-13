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

namespace Library
{
    /// <summary>
    /// Interaction logic for MemberLoginPage.xaml
    /// </summary>
    public partial class MemberLoginPage : Window
    {
        public MemberLoginPage()
        {
            InitializeComponent();
        }

        private void SigninButton_Click(object sender, RoutedEventArgs e)
        {
            new SignIn().Show();
            Close();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            new SignUp().Show();
            Close();
        }
    }
}
