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
using System.Data;
using System.Data.SqlClient;
namespace Library
{
    /// <summary>
    /// Interaction logic for MemberSearchBook.xaml
    /// </summary>
    public partial class MemberSearchBook : Window
    {
        readonly string cs = @"Data Source =.; Initial Catalog = Library; Integrated Security = True";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        public MemberSearchBook()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new MemberDashboard().Show();
            Close();
        }

        private void MemberSearchBook1_Loaded(object sender, RoutedEventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select BookName,CategoryTitle,AuthorName from Books", con);
            dt = new DataTable();
            adapt.Fill(dt);
            MemberSearchBookDG.ItemsSource = dt.DefaultView;
            con.Close();
        }

        private void SearchTxtBx_TextChanged(object sender, TextChangedEventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select BookName,CategoryTitle,AuthorName  from Books where BookName like '%" + SearchTxtBx.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            MemberSearchBookDG.ItemsSource = dt.DefaultView;
            con.Close();
        }
     
    }
}
