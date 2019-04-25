using System.Collections.ObjectModel;
using System.ComponentModel;

namespace GoodyAppDesktop
{
    public class SeriesData
    {
        public string DisplayName { get; set; }

        public string Description { get; set; }

        public ObservableCollection<TestClass> Items { get; set; }
    }

    public class TestClass : INotifyPropertyChanged
    {
        public string Category { get; set; }

        private float _number = 0;
        public float Number
        {
            get => _number;
            set
            {
                _number = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("Number"));
                }
            }

        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
