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

        public Page seasonDatesPage;
        public Page seasonPage;
        public Page resultPrePage;
        public Page resultPage;

        public MainWindow()
        {
            InitializeComponent();

            ClickSeason(null, null);
        }

        public void ClickSeason(object sender, RoutedEventArgs e)
        {
            if (seasonPage == null)
            {
                seasonPage = new Season(this);
            }
            Main.Content = seasonPage;
        }

        public void ClickResult(object sender, RoutedEventArgs e)
        {
            if (resultPrePage == null)
            {
                resultPrePage = new Result_PreSelect(this);
            }
            Main.Content = resultPrePage;
        }

        public void SelectedDates()
        {
            if (seasonDatesPage == null)
            {
                seasonDatesPage = new Season_Dates(this);
            }
            Main.Content = seasonDatesPage;
        }

        public void SelectedResults()
        {
            if (resultPage == null)
            {
                resultPage = new Result();
            }
            Main.Content = resultPage;
        }
    }
}
