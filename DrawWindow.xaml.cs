using System;
using System.Windows;

namespace EDSLPrototype
{
    /// <summary>
    /// Interaction logic for DrawWindow.xaml
    /// </summary>
    public partial class DrawWindow : Window
    {
        public DrawWindow()
        {
            InitializeComponent();
            Browser.Navigate(new Uri(System.IO.Path.GetFullPath("./Reports/Draw.pdf"), UriKind.Absolute));
        }
    }
}
