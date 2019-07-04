//using GoodyDataLib.Models;
//using GoodyDataLib.Services;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace GoodyAppDesktop
{
    /// <summary>
    /// Interaction logic for JournalWindow.xaml
    /// </summary>
    public partial class JournalWindow : Window
    {
        public ObservableCollection<JournalItem> Rows { get; set; } = new ObservableCollection<JournalItem>();
        public string ConnectionString { get; set; } =
            $"https://goodyreturnevent.azurewebsites.net/api/ReturnUser?code=69UBhi60coeNm3r77ePJt9oP6ZmD4h2HdTakq4qbDD/UxQpLFDKH/A==";


        public JournalWindow()
        {
            InitializeComponent();
        }

        public JournalWindow(double height, double width, double left, double top, WindowState state)
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

        private async void SetContent()
        {
            //try
            //{
            //    EventService @event = new EventService(ConnectionString);
            //    List<EventInfo> infos = await @event.GetDistrictEventsAsync(10, 34, Storage.CurrentDistrict);

            //    for (int i = 0; i < infos.Count; i++)
            //    {
            //        MainTable.Items.Add(new JournalItem
            //        {
            //            ID = infos[i].CreatorID,
            //            Age = infos[i].AuthorAge,
            //            Address = infos[i].Address,
            //            Description = infos[i].Description,
            //            District = infos[i].District,
            //            Resources = infos[i].Resources,
            //            State = infos[i].State,
            //            Time = $"{infos[i].CreatedAt.ToLongDateString()} {infos[i].CreatedAt.ToLongTimeString()}"
            //        });
            //    }

            //    //После работы нейросети может быть отображено сообщение
            //    //MessageBox.Show("Обнаружен подозрительный гражданин!", "Внимание!", MessageBoxButton.OK, MessageBoxImage.Warning);
            //}
            //catch
            //{
            //    //В данным момент ни один сервер не работает
            //}

            LoadScreen.Visibility = Visibility.Hidden;
            MainData.Visibility = Visibility.Visible;
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            Window window = new MainWindow(Height, Width, Left, Top, WindowState);
            window.Show();
            Close();
        }
    }
}
