using System.Windows;
using System.Windows.Input;

namespace GoodyAppDesktop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(double height, double width, double left, double top, WindowState state)
        {
            InitializeComponent();
            Height = height;
            Width = width;
            WindowStartupLocation = WindowStartupLocation.Manual;
            WindowState = state;
            Left = left;
            Top = top;

            HelloLabel.Text = $"Добро пожаловать, {Storage.Name}!";
        }
        
        #region Open Graphics
        private void OpenGraphics(object sender, MouseButtonEventArgs e)
        {
            Window window = new GraphicsWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }

        private void OpenGraphicsByImage(object sender, RoutedEventArgs e)
        {
            Window window = new GraphicsWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }
        #endregion

        #region Open Stats
        private void OpenStats(object sender, MouseButtonEventArgs e)
        {
            Window window = new StatWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }

        private void OpenStatsByImage(object sender, RoutedEventArgs e)
        {
            Window window = new StatWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }
        #endregion

        #region Open Journal
        private void OpenJournal(object sender, MouseButtonEventArgs e)
        {
            Window window = new JournalWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }

        private void OpenJournalByImage(object sender, RoutedEventArgs e)
        {
            Window window = new JournalWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }
        #endregion

        #region Open Maps
        private void OpenMaps(object sender, MouseButtonEventArgs e)
        {
            Window window = new MapsWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }

        private void OpenMapsByImage(object sender, RoutedEventArgs e)
        {
            Window window = new MapsWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }
        #endregion
        
        #region Open Menu
        private void OpenMenu(object sender, MouseButtonEventArgs e)
        {
            Window window = new MenuWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }

        private void OpenMenuByImage(object sender, RoutedEventArgs e)
        {
            Window window = new MenuWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }
        #endregion
    }
}
