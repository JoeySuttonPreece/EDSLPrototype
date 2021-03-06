﻿using System;
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
    /// Interaction logic for Result.xaml
    /// </summary>
    public partial class Result : Page
    {
        public Result()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void CreateLadder_Click(object sender, RoutedEventArgs e)
        {
            ViewLadder.IsEnabled = true;
        }

        private void ViewLadder_Click(object sender, RoutedEventArgs e)
        {
            new LadderWindow().Show();
        }
    }
}
