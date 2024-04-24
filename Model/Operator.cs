using System.Collections.ObjectModel;

namespace DBChebakov.Model
{
    public class Operator : PropChange
    {
        private int id;
        private string name;
        ObservableCollection<Picket>? pickets;

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

        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(nameof(Name));
            }
        }

        public ObservableCollection<Picket>? Pickets
        {
            get { return pickets; }
            set
            {
                pickets = value;
                OnPropertyChanged(nameof(Pickets));
            }
        }
    }
}
