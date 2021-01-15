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
using System.Data.Entity.Core.Objects;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;
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
            new ExtendBorrowedBookDate().Show();
            Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new MemberDashboard().Show();
                Close();
        }
       
        private void MemberBorrowedBook1_Loaded(object sender, RoutedEventArgs e)
        {
            string userId = MemberDashboard.SetValueForUserId;

            using (SqlConnection sqlConn = new SqlConnection())
            {
                sqlConn.ConnectionString = "Data Source =.; Initial Catalog = Library; Integrated Security = True";
                string queryString = "select ReturnDate,DeadlineDate,BookName from BorrowedBooks Inner join Books on BorrowedBooks.BookId = Books.Id  where UserId = '"+ userId  + "'";
                sqlConn.Open();

                DataTable table = new DataTable();
                SqlDataAdapter a = new SqlDataAdapter(queryString, sqlConn);
                a.Fill(table);

                this.MemberBorrowedBookDG.ItemsSource = table.DefaultView;
            }

        }

        
    }
}
