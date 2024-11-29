using PR_16_Ladonina.ApplicationData;
using PR_16_Ladonina.Page;
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

namespace PR_16_Ladonina
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            AppFrame.FrameMain = myFrame;
            myFrame.Navigate(new PageTovar());
        }

        private void myFrame_Navigated(object sender, NavigationEventArgs e)
        {

        }
    }
}
