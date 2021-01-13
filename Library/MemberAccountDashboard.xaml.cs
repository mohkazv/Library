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
    /// Interaction logic for MemberAccountDashboard.xaml
    /// </summary>
    public partial class MemberAccountDashboard : Window
    {
        SqlCommand cmd;
        SqlConnection con;
        public MemberAccountDashboard()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                con = new SqlConnection(@"Data Source =.; Initial Catalog = Library; Integrated Security = True");
                con.Open();
                cmd = new SqlCommand("Update Users Set FirstName=@FirstName and LastName=@LastName and Gender=@Gender and Email=@Email and Username=@Username and PhoneNumber=@PhoneNumber and Password=@Password and Education=@Education and BirthDate=@BirthDate ", con);
                cmd.Parameters.Add("@FirstName", FirstNameTxtBx.Text);
                cmd.Parameters.Add("@LastName", LastNameTxtBx.Text);
                cmd.Parameters.Add("@Gender", GenderCmBx.Text);
                cmd.Parameters.Add("@Email", EmailTxtBx.Text);
                cmd.Parameters.Add("@Username", UsernameTxtBx.Text);
                cmd.Parameters.Add("@PhoneNumber", PhoneNumberTxtBx.Text);
                cmd.Parameters.Add("@Password", PasswordTxtBx.Password);
                cmd.Parameters.Add("@BirthDate", BirthDateDP.SelectedDate);
                cmd.Parameters.Add("@RegisterDate", DateTime.Now);
                cmd.ExecuteNonQuery();
                MessageBox.Show(
                        messageBoxText: $"User «{FirstNameTxtBx.Text + LastNameTxtBx.Text}» successfully Added",
                        caption: "Successful Adding",
                        button: MessageBoxButton.OK,
                        icon: MessageBoxImage.Information);
                con.Close();
            }
            catch (Exception b)
            {
                MessageBox.Show("Exception occur while Updating table:" + b.Message + "\t" + b.GetType());
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new MemberDashboard().Show();
            Close();
        }

        private void MemberAccountDashboard1_Loaded(object sender, RoutedEventArgs e)
        {

            try
            {
                con = new SqlConnection(@"Data Source=.;Initial Catalog=Library;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select * from Users where Id ='" + SearchEditMemberInformation.SetValueForUserId + "'", con);

                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    FirstNameTxtBx.Text = dr.GetValue(0).ToString();
                    LastNameTxtBx.Text = dr.GetValue(1).ToString();
                    GenderCmBx.Text = dr.GetValue(2).ToString();
                    EmailTxtBx.Text = dr.GetValue(3).ToString();
                    UsernameTxtBx.Text = dr.GetValue(4).ToString();
                    EducationTxtBx.Text = dr.GetValue(5).ToString();
                    PhoneNumberTxtBx.Text = dr.GetValue(6).ToString();
                    BirthDateDP.DisplayDate = (DateTime)dr.GetValue(7);
                    PasswordTxtBx.Password = dr.GetValue(8).ToString();


                }
                con.Close();

            }
            catch (Exception)
            {

            }



        }
    }
}
