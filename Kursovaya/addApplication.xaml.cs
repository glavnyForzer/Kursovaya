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
    /// Логика взаимодействия для addApplication.xaml
    /// </summary>
    public partial class addApplication : Window
    {
        private Page _parentPage;
        private Frame _parentFrame;
        ApplicationContext db;
        /*private DatabaseService db = new DatabaseService();*/

        public Journal Journal { get; private set; }
        public StatusTrucks StatusTrucks { get; }

        public addApplication(Page parentPage)
        {
            InitializeComponent();
            _parentPage = parentPage;
            db = new ApplicationContext();
        }
        public addApplication()
        {
            InitializeComponent();
           /* upTruck.ItemsSource = new db.StatusTrucks.ToList();*/
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
                string owner = Owners.Text;
                string name_Gruz = cargos.Text;
                int truck = upTruck.SelectedIndex;
                string address = OwnerAddres.Text;
                string weight = cargoWeight.Text;
                string dateOtgruzki = ShippingDate.Text;
                string status = Statuz2.Text;

            if (Owners.Text != "" && cargos.Text != "" && upTruck.SelectedItem != null && OwnerAddres.Text != "" && cargoWeight.Text != "" && ShippingDate.Text != "" && Statuz2.Text != "")
            {
                    Journal = new Journal()
                    {
                        ID_Zayavki = new Random().Next(0,100),
                        Owner = owner,
                        Name_Gruz = name_Gruz,
                        Truck = truck,
                        Adress = address,
                        Weight = weight,
                        Date_Otgruzki = dateOtgruzki,
                        Status = status
                    };

                    db.Journal.Add(Journal);
                    db.SaveChanges();
                    Close();  // Если нужно закрыть окно после сохранения.
            }
                else
                {
                    MessageBox.Show("Заполните все данные");
                }
        }


        private void OnTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = string.Empty;
            textBox.GotFocus -= OnTextBoxGotFocus;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void Owner_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBoxStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBoxTruck_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
