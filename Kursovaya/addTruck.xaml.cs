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
using Kursovaya.classes;

namespace Kursovaya
{
    public partial class AddTruckWindow : Window
    {
        /* private Page _parentPage;
         private Frame _parentFrame;

         ApplicationContext db;

         public Trucks Trucks { get; private set; }  

         public AddTruckWindow(Page parentPage)
         {
             InitializeComponent();
             _parentPage = parentPage;
         }

         public AddTruckWindow(Frame parentFrame)
         {
             InitializeComponent();
             _parentFrame = parentFrame;
         }*/
        private ApplicationContext db = new ApplicationContext();
        private Trucks  newTrucks;
        /*public AddTruckWindow()
        {
            InitializeComponent();
            Statuses.ItemsSource = db.StatusTrucks.ToList();
        }*/
       public AddTruckWindow()
        {
            InitializeComponent();
            StatusTrucks.ItemsSource = db.StatusTrucks.ToList();
        }

        private void Owner_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Ваш код обработки изменения текста
        }

        private void OnTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = string.Empty;
            textBox.GotFocus -= OnTextBoxGotFocus;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string number = NumberPlate.Text;
            string fio = Initials.Text;
            int status = StatusTrucks.SelectedIndex;
            string car = BrandModel.Text;

            if (NumberPlate.Text != "" && Initials.Text != "" && StatusTrucks.SelectedItem != null && BrandModel.Text != "")
            {
                newTrucks = new Trucks()
                {
                    ID_Truck = new Random().Next(0, 100),
                    Number = number,
                    FIO = fio,
                    Status = status,
                    Car = car,
                    
                };

                db.Trucks.Add(newTrucks);
                db.SaveChanges();
                Close();  // Если нужно закрыть окно после сохранения.
            }
            else
            {
                MessageBox.Show("Заполните все данные");
            }
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false; // Закройте текущее окно после возврата на предыдущую страницу
        }

        private void ComboBoxStatus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
