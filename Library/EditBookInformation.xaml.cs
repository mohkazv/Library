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
    /// Interaction logic for EditBookInformation.xaml
    /// </summary>
    public partial class EditBookInformation : Window
    {
        SqlCommand cmd;
        SqlConnection con;
        public EditBookInformation()
        {
            InitializeComponent();
        }

        private void RemoveBtn_Click(object sender, RoutedEventArgs e)
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
                con = new SqlConnection(@"Data Source=.;Initial Catalog=Library_DB;Integrated Security=True");
                con.Open();

                cmd = new SqlCommand("Delete From Books Where BookName=@BookName and CategoryTitle=@CategoryTitle and Avilable=@Available and PublishedYear=@PublishedYear and Edition=@Edition and AuthorName=@AuthorName and ISBN=@ISBN and Language=@Language ", con);

                cmd.Parameters.AddWithValue("@BookName", BookNameTxtBx.Text);
                cmd.Parameters.AddWithValue("@CategoryTitle", CategoryTxtBx.Text);
                cmd.Parameters.AddWithValue("@Available", AvailableTxtBx.Text);
                cmd.Parameters.AddWithValue("@PublishedYear", PublishYearTxtBx.Text);
                cmd.Parameters.AddWithValue("@Edition", EditionTxtBx.Text);
                cmd.Parameters.AddWithValue("@AuthorName", AuthorTxtBx.Text);
                cmd.Parameters.AddWithValue("@ISBN", ISBNTxtBx.Text);
                cmd.Parameters.AddWithValue("@Language", LanguageTxtBx.Text);

                int deleted = cmd.ExecuteNonQuery();
                MessageBox.Show(
                              messageBoxText: $"Book «{BookNameTxtBx.Text}» successfully Removed",
                              caption: "Successful Removing",
                              button: MessageBoxButton.OK,
                              icon: MessageBoxImage.Information);

            }
        }
              catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                con = new SqlConnection(@"Data Source=.;Initial Catalog=Library_DB;Integrated Security=True");
                con.Open();
                cmd = new SqlCommand("Select * From Books where Id ='" + SearchEditBookInformation.SetValueForBookId + "'", con);


                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                      BookNameTxtBx.Text = dr.GetValue(0).ToString();
                      CategoryTxtBx.Text = dr.GetValue(1).ToString();
                      AvailableTxtBx.Text = dr.GetValue(2).ToString();
                      PublishYearTxtBx.Text = dr.GetValue(3).ToString();
                      EditionTxtBx.Text = dr.GetValue(4).ToString(); 
                      AuthorTxtBx.Text = dr.GetValue(5).ToString();
                      ISBNTxtBx.Text = dr.GetValue(6).ToString();

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new SearchEditBookInformation().Show();
            Close();

        }
    }
}
