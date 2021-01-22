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
    /// Interaction logic for SignUp.xaml
    /// </summary>
    public partial class SignUp : Window
    {
        SqlCommand cmd;
        readonly SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = Library; Integrated Security = True");
        public SignUp()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void SignUpBtn_Click(object sender, RoutedEventArgs e)
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

                if (MainWindow.Librarian == true)
                {
                    if (string.IsNullOrEmpty(FirstName) && string.IsNullOrEmpty(LastName) && string.IsNullOrEmpty(Email) && string.IsNullOrEmpty(Username) && string.IsNullOrEmpty(PhoneNumber) && string.IsNullOrEmpty(Password) && string.IsNullOrEmpty(Education) && BirthDateDP.SelectedDate == null && GenderCmBx.SelectedIndex == -1)
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
                        cmd = new SqlCommand("INSERT INTO Admins (FirstName,LastName,Gender,Email,Username,PhoneNumber,Password,BirthDate,RegisterDate,Education) VALUES (@FirstName,@LastName,@Gender,@Email,@Username,@PhoneNumber,@Password,@BirthDate,@RegisterDate,@Education)", con);
                        cmd.Parameters.Add("@FirstName", FirstNameTxtBx.Text);
                        cmd.Parameters.Add("@LastName", LastNameTxtBx.Text);
                        cmd.Parameters.Add("@Gender", GenderCmBx.Text);
                        cmd.Parameters.Add("@Email", EmailTxtBx.Text);
                        cmd.Parameters.Add("@Username", UsernameTxtBx.Text);
                        cmd.Parameters.Add("@PhoneNumber", PhoneNumberTxtBx.Text);
                        cmd.Parameters.Add("@Password", PasswordTxtBx.Password);
                        cmd.Parameters.Add("@BirthDate", BirthDateDP.SelectedDate);
                        cmd.Parameters.Add("@RegisterDate", DateTime.Now);
                        cmd.Parameters.Add("@Education", EducationTxtBx.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(
                                messageBoxText: $"Librarain «{FirstNameTxtBx.Text + LastNameTxtBx.Text}» successfully Added.",
                                caption: "Successful Adding",
                                button: MessageBoxButton.OK,
                                icon: MessageBoxImage.Information);
                        con.Close();
                        new LibrarianLoginPage().Show();



                    } }
                else
                {

                    if (string.IsNullOrEmpty(FirstNameTxtBx.Text) && string.IsNullOrEmpty(LastName) && string.IsNullOrEmpty(Email) && string.IsNullOrEmpty(Username) && string.IsNullOrEmpty(PhoneNumber) && string.IsNullOrEmpty(Password) && string.IsNullOrEmpty(Education) && string.IsNullOrEmpty(BirthDate) && GenderCmBx.SelectedIndex == -1)
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
                        cmd = new SqlCommand("INSERT INTO Users (FirstName,LastName,Gender,Email,Username,PhoneNumber,Password,BirthDate,RegisterDate,Education) VALUES (@FirstName,@LastName,@Gender,@Email,@Username,@PhoneNumber,@Password,@BirthDate,@RegisterDate,@Education)", con);
                        cmd.Parameters.Add("@FirstName", FirstNameTxtBx.Text);
                        cmd.Parameters.Add("@LastName", LastNameTxtBx.Text);
                        cmd.Parameters.Add("@Gender", GenderCmBx.Text);
                        cmd.Parameters.Add("@Email", EmailTxtBx.Text);
                        cmd.Parameters.Add("@Username", UsernameTxtBx.Text);
                        cmd.Parameters.Add("@PhoneNumber", PhoneNumberTxtBx.Text);
                        cmd.Parameters.Add("@Password", PasswordTxtBx.Password);
                        cmd.Parameters.Add("@BirthDate", BirthDateDP.SelectedDate);
                        cmd.Parameters.Add("@RegisterDate", DateTime.Now);
                        cmd.Parameters.Add("@Education", EducationTxtBx.Text);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(
                                messageBoxText: $"User «{FirstNameTxtBx.Text + LastNameTxtBx.Text}» Successfully Added.",
                                caption: "Successful Adding",
                                button: MessageBoxButton.OK,
                                icon: MessageBoxImage.Information);
                        con.Close();
                        new MemberLoginPage().Show();
                        Close();


                    }
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
          
        private void SignUp1_Loaded_1(object sender, RoutedEventArgs e)
        {
            if (MainWindow.Librarian == true)
            {
                textblockTxB.Text = "Sign Up as Librarian :";

            }
            else
            {
                textblockTxB.Text = "Sign Up as Member :";
            }
        }


    } 
}


