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
using System.Data;
using System.Data.SqlClient;
namespace Library
{
    /// <summary>
    /// Interaction logic for MemberSearchBook.xaml
    /// </summary>
    public partial class MemberSearchBook : Window
    {
        
        public MemberSearchBook()
        {
            InitializeComponent();
        }
      

        private void SearchTxtBx_KeyUp(object sender, KeyEventArgs e)
        {
            try { 
            string query = "SELECT BookName, CategoryTitle, AuthorName From Books";
            query += " WHERE BookName LIKE '%' + @BookName+ '%'";
            query += " OR @BookName = ''";
            string constr = @"Data Source=.;Initial Catalog=Library;Integrated Security=True";
                using (SqlConnection con = new SqlConnection(constr))
                {
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@BookName", SearchTxtBx.Text.Trim());
                        using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                        {
                            DataTable dt = new DataTable();
                            sda.Fill(dt);

                            this.MemberSearchBookDG.ItemsSource = dt.DefaultView;
                        }

                    } 
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception occur :" + ex.Message + "\t" + ex.GetType());
            }

        }
    }
}
