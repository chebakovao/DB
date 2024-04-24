using System.Collections.ObjectModel;

namespace DBChebakov.Model
{
    public class Customer : PropChange
    {
        private int id;
        private string name;
     
        ObservableCollection<Project> projects;

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


        public ObservableCollection<Project> Projects
        {
            get { return projects; }
            set
            {
                projects = value;
                OnPropertyChanged(nameof(Projects));
            }
        }
    }
}