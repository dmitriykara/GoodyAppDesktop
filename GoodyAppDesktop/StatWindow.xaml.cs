using System.Collections.ObjectModel;
using System.Windows;

namespace GoodyAppDesktop
{
    /// <summary>
    /// Interaction logic for StatWindow.xaml
    /// </summary>
    public partial class StatWindow : Window
    {
        public ObservableCollection<StatRecord> StatRecords = new ObservableCollection<StatRecord>();

        public StatWindow()
        {
            InitializeComponent();
        }

        public StatWindow(double height, double width, double left, double top, WindowState state)
        {
            InitializeComponent();
            Height = height;
            Width = width;
            WindowStartupLocation = WindowStartupLocation.Manual;
            WindowState = state;
            Left = left;
            Top = top;

            StatList.Items.Add(new StatRecord
            {
                Header = "Средний возраст:",
                MainText = "24.5 года",
                ImageData = "Resources/queue.png"
            });

            StatList.Items.Add(new StatRecord
            {
                Header = "Среднее время ответа:",
                MainText = "9 минут",
                ImageData = "Resources/timer.png"
            });

            StatList.Items.Add(new StatRecord
            {
                Header = "Среднее время помощи:",
                MainText = "17 минут",
                ImageData = "Resources/timer.png"
            });
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }
    }

    public class StatRecord
    {
        public string Header { get; set; }
        public string MainText { get; set; }
        public string ImageData { get; set; }
    }
}
