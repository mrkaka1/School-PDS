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

namespace Sistem_School
{
    /// <summary>
    /// Lógica interna para dashboards.xaml
    /// </summary>
    public partial class dashboards : Window
    {
        public dashboards()
        {
            InitializeComponent();
        }

        private void txbTeste_Click(object sender, RoutedEventArgs e)
        {
            framePage.Source = new Uri("./School.xaml", UriKind.Relative);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            framePage.Source = new Uri("./courses.xaml", UriKind.Relative);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            framePage.Source = new Uri("./class.xaml", UriKind.Relative);
            
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            framePage.Source = new Uri("./students.xaml", UriKind.Relative);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            framePage.Source = new Uri("./Reports.xaml", UriKind.Relative);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            framePage.Source = new Uri("./tables.xaml", UriKind.Relative);
        }
    }
}
