using System.Windows;

namespace GoodyAppDesktop
{
    /// <summary>
    /// Interaction logic for MenuWindow.xaml
    /// </summary>
    public partial class MenuWindow : Window
    {
        public MenuWindow()
        {
            InitializeComponent();
        }

        public MenuWindow(double height, double width, double left, double top, WindowState state)
        {
            InitializeComponent();
            Height = height;
            Width = width;
            WindowState = state;
            WindowStartupLocation = WindowStartupLocation.Manual;
            Left = left;
            Top = top;

            SetContent();
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }

        private void SetContent()
        {
            for (int i = 0; i < Storage.Districts.Count; i++)
            {
                DistrictList.Items.Add(new DistrictItem
                {
                    ID = i,
                    DName = Storage.Districts[i],
                    ImageString = "Resources/skyscrapers.png"
                });
            }
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }

        private void DistrictList_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            Storage.CurrentDistrict = Storage.Districts[DistrictList.SelectedIndex];
        }
    }

    public class DistrictItem
    {
        public int ID { get; set; }
        public string DName { get; set; }
        public string ImageString { get; set; }
    }
}
