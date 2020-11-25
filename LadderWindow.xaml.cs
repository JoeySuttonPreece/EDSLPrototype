using System;
using System.Windows;

namespace EDSLPrototype
{
    /// <summary>
    /// Interaction logic for LadderWindow.xaml
    /// </summary>
    public partial class LadderWindow : Window
    {
        public LadderWindow()
        {
            InitializeComponent();
            Browser.Navigate(new Uri(System.IO.Path.GetFullPath("./Reports/Ladder.pdf"), UriKind.Absolute));
        }
    }
}
