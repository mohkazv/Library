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
    /// Interaction logic for MemberDashboard.xaml
    /// </summary>
    public partial class MemberDashboard : Window
    {
        public MemberDashboard()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BorrowedBookBtn_Click(object sender, RoutedEventArgs e)
        {
            new MemberborrowedBook().Show();
            Close();
        }

        private void AccountDashboardBtn_Click(object sender, RoutedEventArgs e)
        {
            new MemberAccountDashboard().Show();
            Close();
        }

        private void LogoutBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
