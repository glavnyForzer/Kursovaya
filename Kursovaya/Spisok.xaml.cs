using System;
using Kursovaya;
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
using Kursovaya.classes;

namespace Kursovaya
{
    /// <summary>
    /// Логика взаимодействия для Spisok.xaml
    /// </summary>
    public partial class Spisok : Page
    {
        private Frame _frame;
        private DatabaseService _dbService;
        public Spisok(Frame frame)
        {
            InitializeComponent();
            _frame = frame;
        }
        public Spisok()
        {
            InitializeComponent();
            _dbService = new DatabaseService();
            LoadTrucks();
        }
        private void LoadTrucks()
        {
            var trucks = _dbService.GetTruck();
            TrucksDataGrid.ItemsSource = trucks;
        }
        private void Btn_Jurnal_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Zayavki());
        }

        private void Btn_Complete_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Complete());
        }

        private void Btn_Spisok_Click(object sender, RoutedEventArgs e)
        {

        }

        private void AddTruck_Click(object sender, RoutedEventArgs e)
        {
            new addCar().ShowDialog();
            TrucksDataGrid.ItemsSource = new DatabaseService().GetTruck();
        }

        private void statusTrucks_Click(object sender, RoutedEventArgs e)
        {

        }

        private void TrucksDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
