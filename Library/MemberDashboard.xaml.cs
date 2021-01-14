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
    /// Interaction logic for MemberDashboard.xaml
    /// </summary>
    public partial class MemberDashboard : Window
    {
        SqlCommand cmd;
        SqlConnection con;
        public static string SetValueForUserId;
        public MemberDashboard()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BorrowedBookBtn_Click(object sender, RoutedEventArgs e)
        {
            new MemberborrowedBook().Show();
            Close();
        }

        private void AccountDashboardBtn_Click(object sender, RoutedEventArgs e)
        {
            new MemberAccountDashboard().Show();
            Close();
        }

        private void LogoutBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void MemberDashboard1_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=.;Initial Catalog=Library;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("select FirstName,LastName,Id from Users where Email='" + SignIn.SetValueForEmail + "'", con);

                 SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    FullNameTxtB.Text = "Loged in as Member" + " " + dr.GetValue(0).ToString() + " " + dr.GetValue(1).ToString();
                     SetValueForUserId = dr.GetValue(2).ToString();
                }
                con.Close();

            }
            catch (Exception)
            {

            }
        }
    }
}
