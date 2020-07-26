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

namespace EDSLPrototype
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private Page seasonPage;
        private Page resultPage;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void ClickSeason(object sender, RoutedEventArgs e)
        {
            if (seasonPage == null)
            {
                seasonPage = new Season();
            }
            Main.Content = seasonPage;
        }

        private void ClickResult(object sender, RoutedEventArgs e)
        {
            if (resultPage == null)
            {
                resultPage = new Result();
            }
            Main.Content = resultPage;
        }
    }
}
