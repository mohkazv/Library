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
using System.Data.Sql;
using System.Data.SqlClient;
namespace Library
{
    /// <summary>
    /// Interaction logic for SearchEditBookInformation.xaml
    /// </summary>
    public partial class SearchEditBookInformation : Window
    {

        readonly SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = Library; Integrated Security = True");
        public static int SetValueForBookId = 0;

        public SearchEditBookInformation()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            string BookId = BookIdTxtBx.Text;


            if (string.IsNullOrEmpty(BookId))

            {
                MessageBox.Show(
                           messageBoxText: "Please enter valid Values.",
                           caption: "Error",
                           button: MessageBoxButton.OK,
                           MessageBoxImage.Error);
                BookIdTxtBx.Focus();
            }

            else
            { 
                con.Open();
                SqlCommand checkBook = new SqlCommand("SELECT COUNT(*) FROM Books WHERE Id= @Id", con);
                checkBook.Parameters.AddWithValue("@Id", BookIdTxtBx.Text);
                int BookExist = (int)checkBook.ExecuteScalar();

                if (BookExist > 0)
                {
                    SetValueForBookId = int.Parse(BookIdTxtBx.Text);
                    new EditBookInformation().Show();
                    Close();
                }
                else
                {
                    MessageBox.Show(
                              messageBoxText: "Book not Found.",
                              caption: "Error",
                              button: MessageBoxButton.OK,
                              MessageBoxImage.Error);
                }
              
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new BookDashboard().Show();
            Close();
        }
    }
}
