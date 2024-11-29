using PR_16_Ladonina.ApplicationData;
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

namespace PR_16_Ladonina.Page
{
    /// <summary>
    /// Логика взаимодействия для PageTovar.xaml
    /// </summary>
    public partial class PageTovar 
    {
        public PageTovar()
        {
            InitializeComponent();
            GtGridTovar.ItemsSource = AlisaEntities1.GetContext().Tovar.ToList();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            AppFrame.FrameMain.Navigate(new PageRedact (null));
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var tovarForRemoving = GtGridTovar.SelectedItems.Cast<Tovar>().ToList();
            if (MessageBox.Show($"Вы точно хотите удалить следующее {tovarForRemoving.Count()} элементов?", "Внимание",
                MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                try
                {
                    AlisaEntities1.GetContext().Tovar.RemoveRange(tovarForRemoving);
                    AlisaEntities1.GetContext().SaveChanges();
                    MessageBox.Show("Данные удалены");

                    GtGridTovar.ItemsSource = AlisaEntities1.GetContext().Tovar.ToList();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString());
                }
            }

        }

        private void BtnEdit_Click(object sender, RoutedEventArgs e)
        {
         
        }

        private void Page_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            AlisaEntities1.GetContext().ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
            GtGridTovar.ItemsSource = AlisaEntities1.GetContext().Tovar.ToList();
        }
    }
}
