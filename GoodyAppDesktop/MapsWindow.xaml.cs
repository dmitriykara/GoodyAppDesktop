using System.Collections.Generic;
using System.Windows;

namespace GoodyAppDesktop
{
    /// <summary>
    /// Interaction logic for MapsWindow.xaml
    /// </summary>
    public partial class MapsWindow : Window
    {
        public List<double> X { get; set; }
        public List<double> Y { get; set; }

        public MapsWindow()
        {
            InitializeComponent();
        }

        public MapsWindow(double height, double width, double left, double top, WindowState state)
        {
            InitializeComponent();
            Height = height;
            Width = width;
            WindowStartupLocation = WindowStartupLocation.Manual;
            WindowState = state;
            Left = left;
            Top = top;

            SetContent();
        }

        public void SetContent()
        {
            X = new List<double>() { 55.75370903771494 };
            Y = new List<double>() { 37.61981338262558 };


        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }
    }
}
