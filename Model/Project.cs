using System.Collections.ObjectModel;
using System.Windows.Media;

namespace DBChebakov.Model
{
    public class Project : PropChange
    {
        private int id;
        private string name;
        Customer customer;
        ObservableCollection<Area> areas;

        public override string ToString()
        {
            return $"{name}";
        }

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public string? Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }


        public Customer Customer
        {
            get { return customer; }
            set
            {
                customer = value;
                OnPropertyChanged(nameof(Customer));
            }
        }

        public ObservableCollection<Area> Areas
        {
            get { return areas; }
            set
            {
                areas = value;
                OnPropertyChanged(nameof(Areas));
            }
        }
    }
}