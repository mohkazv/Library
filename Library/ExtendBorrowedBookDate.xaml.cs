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
        SqlConnection con;
        public ExtendBorrowedBookDate()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void ExtendDateBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                con = new SqlConnection(@"Data Source =.; Initial Catalog = Library; Integrated Security = True");
                con.Open();
                cmd = new SqlCommand("Update BorrowedBooks Set ReturnDate=@ReturnDate, DeadlineDate=@DeadLineDate Where UserId ='"+MemberDashboard.SetValueForUserId  +"'", con);
                cmd.Parameters.Add("@ReturnDate", ReturnDateDP.SelectedDate);
                cmd.Parameters.Add("@DeadLineDate", DeadlineDP.SelectedDate);
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

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new MemberborrowedBook().Show();
            Close();
        }
    }
}
