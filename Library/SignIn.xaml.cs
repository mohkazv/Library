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
using System.Text.RegularExpressions;
using System.Data;
using System.Data.SqlClient;
namespace Library
{
    /// <summary>
    /// Interaction logic for SignIn.xaml
    /// </summary>
    public partial class SignIn : Window
    {
        SqlConnection con;
        public static string SetValueForEmail = "";
        public SignIn()
        {
            InitializeComponent();
        }
    
        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            SetValueForEmail = InfoTxtBx.Text;
            if (MainWindow.Librarian == true)
            {
                con = new SqlConnection(@"Data Source =.; Initial Catalog = Library; Integrated Security = True");
                con.Open();

                SqlCommand cmd = new SqlCommand("select Email,Password from Admins where Email='" + InfoTxtBx.Text + "'and Password='" + PasswordTxtBx.Password + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login sucess Welcome  ");
                    new LibrarianDashboard().Show();
                    Close();

                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                }
                con.Close();
            }
            else
            {
                con = new SqlConnection(@"Data Source =.; Initial Catalog = Library; Integrated Security = True");
                con.Open();

                SqlCommand cmd = new SqlCommand("select Email,Password from Users where Email='" + InfoTxtBx.Text + "'and Password='" + PasswordTxtBx.Password + "'", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Login sucess Welcome  ");
                    new LibrarianDashboard().Show();
                    Close();

                }
                else
                {
                    MessageBox.Show("Invalid Login please check username and password");
                }
                con.Close();
            }
        }

        private void SignInPage_Loaded(object sender, RoutedEventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = Library; Integrated Security = True");
            con.Open();
        }
    }


}
 