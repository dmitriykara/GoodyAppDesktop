using System.Windows;

namespace GoodyAppDesktop
{
    /// <summary>
    /// Interaction logic for GraphicsWindow.xaml
    /// </summary>
    public partial class GraphicsWindow : Window
    {
        public GraphicsWindow()
        {
            InitializeComponent();
        }

        public GraphicsWindow(double height, double width, double left, double top, WindowState state)
        {
            InitializeComponent();
            Height = height;
            Width = width;
            WindowStartupLocation = WindowStartupLocation.Manual;
            Left = left;
            Top = top;

            CategoryChart.Visibility = Visibility.Hidden;
            CompareChart.Visibility = Visibility.Hidden;
            DataContext = new GraphicsViewModel();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }

        private void ComboBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (ChartSelector.SelectedIndex == 0)
            {
                UsersChart.Visibility = Visibility.Visible;
                CategoryChart.Visibility = Visibility.Hidden;
                CompareChart.Visibility = Visibility.Hidden;
            }
            if (ChartSelector.SelectedIndex == 1)
            {
                UsersChart.Visibility = Visibility.Hidden;
                CategoryChart.Visibility = Visibility.Visible;
                CompareChart.Visibility = Visibility.Hidden;
            }
            if (ChartSelector.SelectedIndex == 2)
            {
                UsersChart.Visibility = Visibility.Hidden;
                CategoryChart.Visibility = Visibility.Hidden;
                CompareChart.Visibility = Visibility.Visible;
            }
        }
    }
}
