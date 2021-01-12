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
    /// Interaction logic for EditMemberInformation.xaml
    /// </summary>
    public partial class EditMemberInformation : Window
    {
        SqlCommand cmd;
        SqlConnection con;
        public EditMemberInformation()
        {
            InitializeComponent();
        }

        private void RemoveMemberBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=.;Initial Catalog=Library_DB;Integrated Security=True");
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
                    PasswordTxtBx.Text = dr.GetValue(8).ToString();


                }
                con.Close();

            }
            catch (Exception ex)
            {

            }
        }
    }
}
