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

        public addApplication(Page parentPage)
        {
            InitializeComponent();
            _parentPage = parentPage;
        }

        public addApplication(Frame parentFrame)
        {
            InitializeComponent();
            _parentFrame = parentFrame;
        }

        private void Owner_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        private void OnTextBoxGotFocus(object sender, RoutedEventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            textBox.Text = string.Empty;
            textBox.GotFocus -= OnTextBoxGotFocus;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            if (_parentPage != null && _parentPage.NavigationService != null)
            {
                if (_parentPage.NavigationService.CanGoBack)
                {
                    _parentPage.NavigationService.GoBack();
                }
            }
            else if (_parentFrame != null && _parentFrame.NavigationService != null)
            {
                if (_parentFrame.NavigationService.CanGoBack)
                {
                    _parentFrame.NavigationService.GoBack();
                }
            }

            this.Close(); // Закройте текущее окно после возврата на страницу Zayavki
        }
    }
}
