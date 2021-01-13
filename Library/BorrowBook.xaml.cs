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
        SqlConnection con;
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

                con = new SqlConnection(@"Data Source =.; Initial Catalog = Library; Integrated Security = True");
                con.Open();
                cmd = new SqlCommand("INSERT INTO BorrowedBook (BookName,ISBN,UserId,ReturnDate,DeadLineDate,IssueDate) VALUES (@BookName,@ISBN,@UserId,@ReturnDate,@DeadLineDate,@IssueDate)", con);
                cmd.Parameters.Add("@BookName", BookNameTxtBx.Text);
                cmd.Parameters.Add("@ISBN", BookIdTxtBx.Text);
                cmd.Parameters.Add("@UserId", UserIdTxtBx.Text);
                cmd.Parameters.Add("@ReturnDate", ReturnDateDP.SelectedDate);
                cmd.Parameters.Add("@DeadLineDate", DeadlineDateDp.SelectedDate);
                cmd.Parameters.Add("@IssueDate", DateTime.Now);
                cmd.ExecuteNonQuery();
                MessageBox.Show(
                           messageBoxText: $"Book «{BookNameTxtBx.Text}» successfully Added",
                           caption: "Successful Adding",
                           button: MessageBoxButton.OK,
                           icon: MessageBoxImage.Information);
                con.Close();
            }
            catch (Exception b)
            {
                MessageBox.Show("Exception occur while creating table:" + b.Message + "\t" + b.GetType());
            }
        }
    }
}
