﻿using System;
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
        SqlConnection con;
        public AddNewMember()
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
                cmd = new SqlCommand("INSERT INTO Users (FirstName,LastName,Gender,Email,Username,PhoneNumber,Password,BirthDate,RegisterDate) VALUES (@FirstName,@LastName,@Gender,@Email,@Username,@PhoneNumber,@Password,@BirthDate,@RegisterDate)", con);
                cmd.Parameters.Add("@FirstName", FirstNameTxtBx.Text);
                cmd.Parameters.Add("@LastName", LastNameTxtBx.Text);
                cmd.Parameters.Add("@Gender", GenderCmBx.Text);
                cmd.Parameters.Add("@Email",EmailTxtBx.Text);
                cmd.Parameters.Add("@Username", UsernameTxtBx.Text);
                cmd.Parameters.Add("@PhoneNumber",PhoneNumberTxtBx.Text);
                cmd.Parameters.Add("@Password", PasswordTxtBx.Password);
                cmd.Parameters.Add("@BirthDate", BirthDateDP.SelectedDate);
                cmd.Parameters.Add("@RegisterDate", DateTime.Now);
                cmd.ExecuteNonQuery();
                MessageBox.Show(
                        messageBoxText: $"Admin «{FirstNameTxtBx.Text + LastNameTxtBx.Text}» successfully Added",
                        caption: "Successful Adding",
                        button: MessageBoxButton.OK,
                        icon: MessageBoxImage.Information);
                con.Close();
            }
            catch (Exception b)
            {
                MessageBox.Show("Exception occur while creating table:" + b.Message + "\t" + b.GetType());
            }

        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new LibrarianDashboard().Show();
            Close();
        }
    }
}
