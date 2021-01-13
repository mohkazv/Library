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

namespace Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       public static bool Librarian = false;
       public static bool Member = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void LibrarianBtn_Click(object sender, RoutedEventArgs e)
        {
            Librarian = true;
            new LibrarianLoginPage().Show();
            Close();
        }

        private void MemberBtn_Click(object sender, RoutedEventArgs e)
        {
            Member = true;
            new MemberLoginPage().Show();
            Close();

        }
    }
}
