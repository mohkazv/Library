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
    /// Interaction logic for AddNewMember.xaml
    /// </summary>
    public partial class AddNewMember : Window
    {
        SqlCommand cmd;
        readonly SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = Library; Integrated Security = True");
        public AddNewMember()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            string FirstName = FirstNameTxtBx.Text;
            string LastName = LastNameTxtBx.Text;
            string Email = EmailTxtBx.Text;
            string Username = UsernameTxtBx.Text;
            string PhoneNumber = PhoneNumberTxtBx.Text;
            string Password = PasswordTxtBx.Password;
            string Education = EducationTxtBx.Text;
            string BirthDate = BirthDateDP.Text;

            try
                {

                    if (string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName)  && string.IsNullOrEmpty(Email) && string.IsNullOrEmpty(Username) && string.IsNullOrEmpty(PhoneNumber) && string.IsNullOrEmpty(Password) && string.IsNullOrEmpty(Education) && string.IsNullOrEmpty(BirthDate) && GenderCmBx.SelectedIndex == -1)
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
                    else {

                        con.Open();
                        cmd = new SqlCommand("INSERT INTO Users (FirstName,LastName,Gender,Email,Username,PhoneNumber,Password,BirthDate,Education,RegisterDate) VALUES (@FirstName,@LastName,@Gender,@Email,@Username,@PhoneNumber,@Password,@BirthDate,@Education,@RegisterDate)", con);
                        cmd.Parameters.Add("@FirstName", FirstNameTxtBx.Text);
                        cmd.Parameters.Add("@LastName", LastNameTxtBx.Text);
                        cmd.Parameters.Add("@Gender", GenderCmBx.Text);
                        cmd.Parameters.Add("@Email", EmailTxtBx.Text);
                        cmd.Parameters.Add("@Username", UsernameTxtBx.Text);
                        cmd.Parameters.Add("@PhoneNumber", PhoneNumberTxtBx.Text);
                        cmd.Parameters.Add("@Password", PasswordTxtBx.Password);
                        cmd.Parameters.Add("@BirthDate", BirthDateDP.SelectedDate);
                       cmd.Parameters.Add("@Education", EducationTxtBx.Text);
                       cmd.Parameters.Add("@RegisterDate", DateTime.Now);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(
                                messageBoxText: $"Member «{FirstNameTxtBx.Text + LastNameTxtBx.Text}» successfully Added",
                                caption: "Successful Adding",
                                button: MessageBoxButton.OK,
                                icon: MessageBoxImage.Information);
                        con.Close();
                    FirstNameTxtBx.Text = "";
                    LastNameTxtBx.Text = "";
                    GenderCmBx.Text = "";
                    EmailTxtBx.Text = "";
                    UsernameTxtBx.Text = "";
                    PhoneNumberTxtBx.Text = "";
                    PasswordTxtBx.Password = "";
                    BirthDateDP.Text = "";
                    EducationTxtBx.Text = "";

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

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new LibrarianMemberDashboard().Show();
            Close();
        }
    }
}
