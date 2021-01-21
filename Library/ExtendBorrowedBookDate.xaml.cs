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
    /// Interaction logic for ExtendBorrowedBookDate.xaml
    /// </summary>
    public partial class ExtendBorrowedBookDate : Window
    {
        SqlCommand cmd;
        readonly SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = Library; Integrated Security = True");
        public ExtendBorrowedBookDate()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void ExtendDateBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                if (ReturnDateDP.SelectedDate == null && DeadlineDP.SelectedDate == null)
                {
                    MessageBox.Show(
                           messageBoxText: "Please enter valid Values.",
                           caption: "Error",
                           button: MessageBoxButton.OK,
                           MessageBoxImage.Error);
                    ReturnDateDP.Focus();
                    DeadlineDP.Focus();

                }
                else {
                    
                    con.Open();
                    cmd = new SqlCommand("Update BorrowedBooks Set ReturnDate=@ReturnDate, DeadlineDate=@DeadLineDate Where UserId ='" + MemberDashboard.SetValueForUserId + "'", con);
                    cmd.Parameters.Add("@ReturnDate", ReturnDateDP.SelectedDate);
                    cmd.Parameters.Add("@DeadLineDate", DeadlineDP.SelectedDate);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(
                               messageBoxText: $"the Book Return Date  Successfully Extended",
                               caption: "Successful",
                               button: MessageBoxButton.OK,
                               icon: MessageBoxImage.Information);
                    con.Close();
                    ReturnDateDP.Text = "";
                    DeadlineDP.Text = "";
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

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new MemberborrowedBook().Show();
            Close();
        }
    }
}
