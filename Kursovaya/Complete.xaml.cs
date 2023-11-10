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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Kursovaya
{
    /// <summary>
    /// Логика взаимодействия для Complete.xaml
    /// </summary>
    public partial class Complete : Page
    {
        public Complete()
        {
            InitializeComponent();
        }

        private void Btn_Jurnal_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Zayavki());
        }

        private void Btn_Complete_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Spisok_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Spisok());
        }
    }
}
