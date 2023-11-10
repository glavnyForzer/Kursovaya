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
    /// Логика взаимодействия для statusZayavki.xaml
    /// </summary>
    public partial class statusZayavki : Page
    {
        public statusZayavki()
        {
            InitializeComponent();
        }
        private void OnTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = string.Empty;
            textBox.GotFocus -= OnTextBoxGotFocus;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Owner_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Btn_Sozdanie_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
