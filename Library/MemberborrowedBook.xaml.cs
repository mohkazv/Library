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
    /// Interaction logic for MemberborrowedBook.xaml
    /// </summary>
    public partial class MemberborrowedBook : Window
    {
        public MemberborrowedBook()
        {
            InitializeComponent();
        }

        private void ExtendDateBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new MemberDashboard().Show();
                Close();
        }
    }
}
