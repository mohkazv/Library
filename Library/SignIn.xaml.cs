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
       
        public static string SetValueForUsername = "";
        public SignIn()
        {
            InitializeComponent();
        }
    
        private void SignInBtn_Click(object sender, RoutedEventArgs e)
        {
            SetValueForUsername = InfoTxtBx.Text;

            if (InfoTxtBx.Text.Length == 0)
            {
                MessageBox.Show( "Enter an email.");
                InfoTxtBx.Focus();
            }
            else if (!Regex.IsMatch(InfoTxtBx.Text, @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$"))
            {
              MessageBox.Show("Enter a valid email.");
                InfoTxtBx.Select(0, InfoTxtBx.Text.Length);
                InfoTxtBx.Focus();
            }
            else
            {
                string email = InfoTxtBx.Text;
                string password = PasswordTxtBx.Password;
                SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = Library; Integrated Security = True");
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * from Registration where Email='" + email + "'  and Password='" + password + "'", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                con.Close();
            }
        }
      
    }


}
 