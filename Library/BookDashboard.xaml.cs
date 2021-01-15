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
    /// Interaction logic for BookDashboard.xaml
    /// </summary>
    public partial class BookDashboard : Window
    {
        public BookDashboard()
        {
            InitializeComponent();
        }

        private void AddNewBookBtn_Click(object sender, RoutedEventArgs e)
        {
            new AddNewBook().Show();
            Close();
        }

        private void EditBookInformationBtn_Click(object sender, RoutedEventArgs e)
        {
            new SearchEditBookInformation().Show();
            Close();
        }

        private void BorrowBookBtn_Click(object sender, RoutedEventArgs e)
        {
            new BorrowBook().Show();
            Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new LibrarianDashboard().Show();
            Close();

        }

        private void BorrowBackBookBtn_Click(object sender, RoutedEventArgs e)
        {
            new BorrowBackBook().Show();
            Close();
        }
    }
}
