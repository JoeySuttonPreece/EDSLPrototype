using System;
using System.Collections.Generic;
using System.Text;
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
    /// Interaction logic for Season_Dates.xaml
    /// </summary>
    public partial class Season_Dates : Page
    {
        MainWindow window;

        public Season_Dates(Window _window)
        {
            InitializeComponent();
            window = (MainWindow)_window;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            window.Main.Content = window.seasonPage;
        }
    }
}
