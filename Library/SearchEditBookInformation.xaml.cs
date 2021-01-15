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

namespace Library
{
    /// <summary>
    /// Interaction logic for SearchEditBookInformation.xaml
    /// </summary>
    public partial class SearchEditBookInformation : Window
    {
        public static int SetValueForBookId = 0;

        public SearchEditBookInformation()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            SetValueForBookId = int.Parse(BookIdTxtBx.Text);
            new EditBookInformation().Show();
            Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {
            new BookDashboard().Show();
            Close();
        }
    }
}
