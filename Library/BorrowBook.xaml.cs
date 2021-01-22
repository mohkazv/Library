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
    /// Interaction logic for BorrowBook.xaml
    /// </summary>
    public partial class BorrowBook : Window
    {
        SqlCommand cmd;
        readonly SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = Library; Integrated Security = True");
        public BorrowBook()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new BookDashboard().Show();
            Close();
        }

        [Obsolete]
        private void BorrowBtn_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                string BookId = BookIdTxtBx.Text;
                string UserId = UserIdTxtBx.Text;
                
                if (string.IsNullOrEmpty(BookId) && string.IsNullOrEmpty(UserId) && ReturnDateDP.SelectedDate == null && DeadlineDateDp.SelectedDate == null )
                {
                    MessageBox.Show(
                            messageBoxText: "Please enter valid Values.",
                            caption: "Error",
                            button: MessageBoxButton.OK,
                            MessageBoxImage.Error);

                    BookIdTxtBx.Focus();
                    UserIdTxtBx.Focus();
                    ReturnDateDP.Focus();
                    DeadlineDateDp.Focus();
     

                }
                else
                {
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO BorrowedBooks (BookId,UserId,ReturnDate,DeadLineDate,IssueDate) VALUES (@BookId,@UserId,@ReturnDate,@DeadLineDate,@IssueDate)", con);
                    cmd.Parameters.Add("@BookId", BookIdTxtBx.Text);
                    cmd.Parameters.Add("@UserId", UserIdTxtBx.Text);
                    cmd.Parameters.Add("@ReturnDate", ReturnDateDP.SelectedDate);
                    cmd.Parameters.Add("@DeadLineDate", DeadlineDateDp.SelectedDate);
                    cmd.Parameters.Add("@IssueDate", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(
                               messageBoxText: $"Book with Book Id : «{BookIdTxtBx.Text}» successfully Borrowed.",
                               caption: "Successful Adding",
                               button: MessageBoxButton.OK,
                               icon: MessageBoxImage.Information);
                    con.Close();
                } 
            }
            catch (Exception b)
            {
                MessageBox.Show(
                    messageBoxText: "Exception occur :" + b.Message + "\t" + b.GetType(),
                    caption: "Exception",
                    button: MessageBoxButton.OK,
                     icon: MessageBoxImage.Error);
            }
        }
    }
}
