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
        readonly SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=Library;Integrated Security=True");
        public MemberAccountDashboard()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                string FirstName = FirstNameTxtBx.Text;
                string LastName = LastNameTxtBx.Text;
                string Gender = GenderCmBx.Text;
                string Email = EmailTxtBx.Text;
                string Username = UsernameTxtBx.Text;
                string PhoneNumber = PhoneNumberTxtBx.Text;
                string Password = PasswordTxtBx.Password;
                string Education = EducationTxtBx.Text;
                string BirthDate = BirthDateDP.Text;

                if (string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName) &&  string.IsNullOrEmpty(Email) && string.IsNullOrEmpty(Username) && string.IsNullOrEmpty(PhoneNumber) && string.IsNullOrEmpty(Password) && string.IsNullOrEmpty(Education) && string.IsNullOrEmpty(BirthDate) && GenderCmBx.SelectedIndex == -1)
                {
                    MessageBox.Show(
                           messageBoxText: "Please enter valid Values.",
                           caption: "Error",
                           button: MessageBoxButton.OK,
                           MessageBoxImage.Error);

                    FirstNameTxtBx.Focus();
                    LastNameTxtBx.Focus();
                    GenderCmBx.Focus();
                    EmailTxtBx.Focus();
                    UsernameTxtBx.Focus();
                    PhoneNumberTxtBx.Focus();
                    PasswordTxtBx.Focus();
                    EducationTxtBx.Focus();
                    BirthDateDP.Focus();

                }
                else
                {
                   
                    con.Open();
                    cmd = new SqlCommand("Update Users Set FirstName=@FirstName , LastName=@LastName , Gender=@Gender , Email=@Email , Username=@Username , PhoneNumber=@PhoneNumber , Password=@Password , Education=@Education , BirthDate=@BirthDate  where Id ='" + MemberDashboard.SetValueForUserId + "'", con);
                    cmd.Parameters.Add("@FirstName", FirstNameTxtBx.Text);
                    cmd.Parameters.Add("@LastName", LastNameTxtBx.Text);
                    cmd.Parameters.Add("@Gender", GenderCmBx.Text);
                    cmd.Parameters.Add("@Email", EmailTxtBx.Text);
                    cmd.Parameters.Add("@Username", UsernameTxtBx.Text);
                    cmd.Parameters.Add("@PhoneNumber", PhoneNumberTxtBx.Text);
                    cmd.Parameters.Add("@Education", EducationTxtBx.Text);
                    cmd.Parameters.Add("@Password", PasswordTxtBx.Password);
                    cmd.Parameters.Add("@BirthDate", BirthDateDP.SelectedDate);
                
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(
                            messageBoxText: $"Information of User «{FirstNameTxtBx.Text + LastNameTxtBx.Text}»  Successfully Updated",
                            caption: "Successful Update",
                            button: MessageBoxButton.OK,
                            icon: MessageBoxImage.Information);
                    con.Close();

                }
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
                con.Open();
                cmd = new SqlCommand("Select FirstName,LastName,Gender,Email,Username,Education,PhoneNumber,BirthDate,Password from Users where Id ='" + MemberDashboard.SetValueForUserId + "'", con);

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
                    BirthDateDP.SelectedDate = (DateTime)dr.GetValue(7);
                    PasswordTxtBx.Password = dr.GetValue(8).ToString();


                }
                con.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception occur:" + ex.Message + "\t" + ex.GetType());
            }



        }
    }
}
