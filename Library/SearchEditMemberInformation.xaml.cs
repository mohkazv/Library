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
    /// Interaction logic for SearchEditMemberInformation.xaml
    /// </summary>
    public partial class SearchEditMemberInformation : Window
    {
        public static int SetValueForUserId = 0;
        public SearchEditMemberInformation()
        {
            InitializeComponent();
        }

        private void SearchBtn_Click(object sender, RoutedEventArgs e)
        {
            SetValueForUserId = int.Parse(UserIdTxtBx.Text);
            new EditMemberInformation().Show();
            Close();
        }

        private void BackBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
