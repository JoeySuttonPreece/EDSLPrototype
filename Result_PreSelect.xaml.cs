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
    /// Interaction logic for Result_PreSelect.xaml
    /// </summary>
    public partial class Result_PreSelect : Page
    {
        MainWindow window;
        bool selected1;
        bool selected2;
        bool selected3;

        public Result_PreSelect(Window _window)
        {
            InitializeComponent();
            window = (MainWindow)_window;
        }

        private void CheckTransition()
        {
            if (selected1 && selected2 && selected3)
            {
                window.SelectedResults();
            }
        }

        private void ResultSeasonSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            selected1 = true;
            CheckTransition();
        }

        private void ResultDivisionSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            selected2 = true;
            CheckTransition();
        }

        private void ResultRoundSelect_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            selected3 = true;
            CheckTransition();
        }
    }
}
