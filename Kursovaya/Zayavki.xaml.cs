using Kursovaya.classes;
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
    /// Логика взаимодействия для Zayavki.xaml
    /// </summary>
    public partial class Zayavki : Page
    {
        private Frame _frame;
        private DatabaseService _dbService;

        public Zayavki(Frame frame)
        {
                InitializeComponent();
                _frame = frame;
                
        }

        public Zayavki()
        {
            InitializeComponent();
            _dbService = new DatabaseService();
            LoadJournal();
        }
        private void LoadJournal()
        {
            var Journal = _dbService.GetJournals();
            JournalDataGrid.ItemsSource = Journal;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new StatusZayavki());
        }

        private void Btn_Jurnal_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Btn_Complete_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new Complete());
        }

        private void Btn_Spisok_Click(object sender, RoutedEventArgs e)
        {
            if (_frame != null && _frame.NavigationService != null)
            {
                _frame.NavigationService.Navigate(new Spisok(_frame));
            }
        }

        private void MakeApplication_Click(object sender, RoutedEventArgs e)
        {
            new addApplication().ShowDialog();
            JournalDataGrid.ItemsSource = new DatabaseService().GetJournals();
            /*var addaddApplicationPage = new addApplication();
            if (addaddApplicationPage.ShowDialog() == true)
            {
                Journal newJournal = addaddApplicationPage.Journal;
                _dbService.AddJournal(newJournal);
                LoadJournals();
            }*/
        }

        private void JournalsDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
