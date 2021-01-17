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
    /// Interaction logic for SearchEditMemberInformation.xaml
    /// </summary>
    public partial class SearchEditMemberInformation : Window
    {
        readonly SqlConnection con = new SqlConnection(@"Data Source =.; Initial Catalog = Library; Integrated Security = True");
        public static int SetValueForUserId = 0;
        public SearchEditMemberInformation()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            string UserId = UserIdTxtBx.Text;

            try
            {

                if (string.IsNullOrEmpty(UserId))
                {
                    MessageBox.Show(
                                   messageBoxText: "Please enter valid Values.",
                                   caption: "Error",
                                   button: MessageBoxButton.OK,
                                   MessageBoxImage.Error);
                    UserIdTxtBx.Focus();


                }
                else
                {
                   
                    con.Open();
                    SqlCommand checkUser = new SqlCommand("SELECT COUNT(*) FROM Users WHERE Id= @Id", con);
                    checkUser.Parameters.AddWithValue("@Id", UserIdTxtBx.Text);
                    int BookExist = (int)checkUser.ExecuteScalar();

                    if (BookExist > 0)
                    {

                        SetValueForUserId = int.Parse(UserIdTxtBx.Text);
                        new EditBookInformation().Show();
                        Close();
                    }
                    else
                    {
                        MessageBox.Show(
                                   messageBoxText: "User Not Found!",
                                   caption: "Error",
                                   button: MessageBoxButton.OK,
                                   MessageBoxImage.Error);

                    }

                    SetValueForUserId = int.Parse(UserIdTxtBx.Text);
                    new EditMemberInformation().Show();
                    Close();


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
