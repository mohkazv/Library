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
        readonly SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = Library; Integrated Security = True");
        public static string SetValueForEmail = "";
        public SignIn()
        {
            InitializeComponent();
        }

        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                SetValueForEmail = InfoTxtBx.Text;
                if (MainWindow.Librarian == true)
                {
                    
                    con.Open();

                    SqlCommand cmd = new SqlCommand("select Email,Password from Admins where Email='" + InfoTxtBx.Text + "'and Password='" + PasswordTxtBx.Password + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    
                    if (dt.Rows.Count > 0)
                    {
                       
                             MessageBox.Show(
                            messageBoxText: $"Login sucess Welcome  ",
                            caption: "Successful Login",
                            button: MessageBoxButton.OK,
                            icon: MessageBoxImage.Information);
                        new LibrarianDashboard().Show();
                        Close();

                    }
                    else
                    {
                        MessageBox.Show(
                               messageBoxText: "Invalid Login please check username and password.",
                               caption: "Error",
                               button: MessageBoxButton.OK,
                               MessageBoxImage.Error);

                    }
                    con.Close();

                }
                else
                {
                   
                    con.Open();
                    SqlCommand cmd = new SqlCommand("select Email,Password from Users where Email='" + InfoTxtBx.Text + "'and Password='" + PasswordTxtBx.Password + "'", con);
                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show(
                          messageBoxText: $"Login sucess Welcome.",
                          caption: "Successful Login",
                          button: MessageBoxButton.OK,
                          icon: MessageBoxImage.Information);
                        new MemberDashboard().Show();
                        Close();

                    }
                    else
                    {
                        MessageBox.Show(
                               messageBoxText: "Invalid Login please check Username and Password.",
                               caption: "Error",
                               button: MessageBoxButton.OK,
                               MessageBoxImage.Error);
                    }
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

        private void SignInPage_Loaded(object sender, RoutedEventArgs e)
        {
            
            if (MainWindow.Librarian == true)
            {
                textblockTxB.Text = "Sign in as Librarian:";
            }
            else
            {
                textblockTxB.Text = "Sign in as Member:";
            }
        }
    }


}
 