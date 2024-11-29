using PR_16_Ladonina.ApplicationData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

namespace PR_16_Ladonina.Page
{
    /// <summary>
    /// Логика взаимодействия для PageRedact.xaml
    /// </summary>
    public partial class PageRedact 
    {
        private Tovar _currentAlisa = new Tovar();
        public PageRedact(Tovar selectedparavarka)
        {
            InitializeComponent();
            if (selectedparavarka != null)
                _currentAlisa = selectedparavarka;

            DataContext = _currentAlisa;
     
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            StringBuilder errors = new StringBuilder();

            if (string.IsNullOrWhiteSpace(_currentAlisa.Naimen))
                errors.AppendLine("Укажите название товара");
            if (_currentAlisa.Cena <= 0)
                errors.AppendLine("Цена не может быть меньше 0");
            if (_currentAlisa. Kol <= 0)
                errors.AppendLine("Выберите вид");
      

            if (errors.Length > 0)
            {
                MessageBox.Show(errors.ToString());
                return;
            }
            if (_currentAlisa.id == 0)
            {
                AlisaEntities1.GetContext().Tovar.Add(_currentAlisa);
            }
            try
            {
                AlisaEntities1.GetContext().SaveChanges();
                MessageBox.Show("Информация сохранена");
                AppFrame.FrameMain.GoBack();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }

        }
    }
}
