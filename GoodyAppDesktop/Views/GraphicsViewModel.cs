using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace GoodyAppDesktop
{
    public class GraphicsViewModel : INotifyPropertyChanged
    {
        public List<SeriesData> Series { get; set; }

        public ObservableCollection<TestClass> Users { get; set; }
        public ObservableCollection<TestClass> Categories { get; set; }
        public ObservableCollection<TestClass> Requested { get; set; }
        public ObservableCollection<TestClass> Solved { get; set; }

        public GraphicsViewModel()
        {
            Series = new List<SeriesData>();

            Users = new ObservableCollection<TestClass>();
            Categories = new ObservableCollection<TestClass>();
            Requested = new ObservableCollection<TestClass>();
            Solved = new ObservableCollection<TestClass>();

            Users.Add(new TestClass() { Category = "Пенсионеры", Number = 66 });
            Users.Add(new TestClass() { Category = "Подростки (мужчины)", Number = 23 });
            Users.Add(new TestClass() { Category = "Подростки (женщины)", Number = 12 });
            Users.Add(new TestClass() { Category = "Мужчины (взрослые)", Number = 94 });
            Users.Add(new TestClass() { Category = "Женщины (взрослые)", Number = 45 });
            Users.Add(new TestClass() { Category = "Люди с особенностями развития", Number = 29 });

            Categories.Add(new TestClass() { Category = "Помощь животным", Number = 10083 });
            Categories.Add(new TestClass() { Category = "Физическая помощь", Number = 32783 });
            Categories.Add(new TestClass() { Category = "Автомобили", Number = 8037 });

            Requested.Add(new TestClass() { Category = "Пенсионеры", Number = 271 });
            Requested.Add(new TestClass() { Category = "Подростки (мужчины)", Number = 523 });
            Requested.Add(new TestClass() { Category = "Подростки (женщины)", Number = 347 });
            Requested.Add(new TestClass() { Category = "Мужчины (взрослые)", Number = 1844 });
            Requested.Add(new TestClass() { Category = "Женщины (взрослые)", Number = 1385 });
            Requested.Add(new TestClass() { Category = "Люди с особенностями развития", Number = 623 });

            Solved.Add(new TestClass() { Category = "Пенсионеры", Number = 906 });
            Solved.Add(new TestClass() { Category = "Подростки (мужчины)", Number = 384 });
            Solved.Add(new TestClass() { Category = "Подростки (женщины)", Number = 363 });
            Solved.Add(new TestClass() { Category = "Мужчины (взрослые)", Number = 1023 });
            Solved.Add(new TestClass() { Category = "Женщины (взрослые)", Number = 2141 });
            Solved.Add(new TestClass() { Category = "Люди с особенностями развития", Number = 130 });

            Series.Add(new SeriesData() { DisplayName = "Users", Items = Users });
            Series.Add(new SeriesData() { DisplayName = "Categories", Items = Categories});
            Series.Add(new SeriesData() { DisplayName = "Requested", Items = Requested });
            Series.Add(new SeriesData() { DisplayName = "Solved", Items = Solved });
        }

        private object selectedItem = null;
        public object SelectedItem
        {
            get => selectedItem;
            set
            {
                selectedItem = value;
                NotifyPropertyChanged("SelectedItem");
            }
        }
        
        private void NotifyPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(property));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
