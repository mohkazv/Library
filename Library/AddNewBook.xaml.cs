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
    /// Interaction logic for AddNewBook.xaml
    /// </summary>
    public partial class AddNewBook : Window
    {
        SqlCommand cmd;
        SqlConnection con;
        public AddNewBook()
        {
            InitializeComponent();
        }

        [Obsolete]
        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string BookName = BookNameTxtBx.Text;
                string Category = CategoryTxtBx.Text;
                string Available = AvailableTxtBx.Text;
                string Edition = EditionTxtBx.Text;
                string PublishedYear = PublishYearTxtBx.Text;
                string AuthorName = AuthorTxtBx.Text;
                string ISBN = ISBNTxtBx.Text;

                if (string.IsNullOrEmpty(BookName) && string.IsNullOrEmpty(Category) && string.IsNullOrEmpty(Available) && string.IsNullOrEmpty(Edition) && string.IsNullOrEmpty(PublishedYear) && string.IsNullOrEmpty(AuthorName) && string.IsNullOrEmpty(ISBN))
                {
                    MessageBox.Show("Please enter valid Values");
                    BookNameTxtBx.Focus();
                    CategoryTxtBx.Focus();
                    AvailableTxtBx.Focus();
                    EditionTxtBx.Focus();
                    PublishYearTxtBx.Focus();
                    AuthorTxtBx.Focus();
                    ISBNTxtBx.Focus();


                }
                else
                {
                    con = new SqlConnection(@"Data Source =.; Initial Catalog = Library; Integrated Security = True");
                    con.Open();
                    cmd = new SqlCommand("INSERT INTO Books (BookName,CategoryTitle,Available,PublishedYear,Edition,AuthorName,ISBN,Language) VALUES (@BookName,@CategoryTitle,@Available,@PublishedYear,@Edition,@AuthorName,@ISBN,@Language)", con);
                    cmd.Parameters.Add("@BookName", BookNameTxtBx.Text);
                    cmd.Parameters.Add("@CategoryTitle", CategoryTxtBx.Text);
                    cmd.Parameters.Add("@Available", AvailableTxtBx.Text);
                    cmd.Parameters.Add("@PublishedYear", PublishYearTxtBx.Text);
                    cmd.Parameters.Add("@Edition", EditionTxtBx.Text);
                    cmd.Parameters.Add("@AuthorName", AuthorTxtBx.Text);
                    cmd.Parameters.Add("@ISBN", ISBNTxtBx.Text);
                    cmd.Parameters.Add("@Language", LanguageTxtBx.Text);
                    //cmd.Parameters.Add("@RegisterDate", DateTime.Now);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show(
                               messageBoxText: $"Book «{BookNameTxtBx.Text}» successfully Added",
                               caption: "Successful Adding",
                               button: MessageBoxButton.OK,
                               icon: MessageBoxImage.Information);
                    con.Close();
                } 
            }
            catch (Exception b)
            {
                MessageBox.Show("Exception occur while creating table:" + b.Message + "\t" + b.GetType());
            }


        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new BookDashboard().Show();
            Close();
        }
    }
}
