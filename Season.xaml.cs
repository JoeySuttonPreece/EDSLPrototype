using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for Season.xaml
    /// </summary>
    public partial class Season : Page
    {
        MainWindow window;

        public Season(Window _window)
        {
            InitializeComponent();
            DataContext = this;
            window = (MainWindow)_window;
        }

        private void Dates_Click(object sender, RoutedEventArgs e)
        {
            window.SelectedDates();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            if ((string)button.Content != "View Draw")
            {
                button.Content = "View Draw";
            } else
            {
                new DrawWindow().Show();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            SeasonDivisionSelect.IsEnabled = true;
        }
    }
}
