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
    /// Interaction logic for BorrowBackBook.xaml
    /// </summary>
    public partial class BorrowBackBook : Window
    {
        SqlCommand cmd;
        SqlConnection con;
        public BorrowBackBook()
        {
            InitializeComponent();
        }

        private void BorrowBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                string BookId = BookIdTxtBx.Text;
                string UserId = UserIdTxtBx.Text;
               

                if (string.IsNullOrEmpty(BookId) && string.IsNullOrEmpty(UserId))
                {
                    MessageBox.Show("Please enter valid Values");
                    BookIdTxtBx.Focus();
                    UserIdTxtBx.Focus();
                }
                else
                {
                    con = new SqlConnection(@"Data Source=.;Initial Catalog=Library;Integrated Security=True");
                    con.Open();

                    cmd = new SqlCommand("Delete From BorrowedBooks Where BookId=@BookId and UserId=@UserId", con);

                    cmd.Parameters.AddWithValue("@BookId", BookIdTxtBx.Text);
                    cmd.Parameters.AddWithValue("@UserId", UserIdTxtBx.Text);
               

                    int deleted = cmd.ExecuteNonQuery();
                    MessageBox.Show(
                                  messageBoxText: $"The Book successfully Borrowed Back",
                                  caption: "Successful",
                                  button: MessageBoxButton.OK,
                                  icon: MessageBoxImage.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}