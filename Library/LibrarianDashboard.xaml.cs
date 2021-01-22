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
    /// Interaction logic for LibrarianDashboard.xaml
    /// </summary>
    public partial class LibrarianDashboard : Window
    {
        SqlCommand cmd;
        readonly SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Library;Integrated Security=True");
        public static string SetValueForAdminId = "";
        public LibrarianDashboard()
        {
            InitializeComponent();
        }

        private void MemberDashboardBtn_Click(object sender, RoutedEventArgs e)
        {
            new LibrarianMemberDashboard().Show();
            Close();
        }

        private void BookDashboardBtn_Click(object sender, RoutedEventArgs e)
        {
            new BookDashboard().Show();
            Close();


        }

        private void AccountDashboardBtn_Click(object sender, RoutedEventArgs e)
        {
            new LibrarianAccountDashboard().Show();
            Close();

        }

        private void LogoutBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void LibrarainDashboard1_Loaded(object sender, RoutedEventArgs e)
        {
            
            try
            {
                con.Open();
                cmd = new SqlCommand("Select FirstName,LastName,Id from Admins where Email='" + SignIn.SetValueForEmail + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   FullNameTxB.Text = "Loged in as Librarian" + " " + dr.GetValue(0).ToString()+ " " + dr.GetValue(1).ToString();
                   SetValueForAdminId = dr.GetValue(2).ToString();
                }
                con.Close();

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
