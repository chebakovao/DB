using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBChebakov.Model
{
    public class PicketValue : PropChange
    {
        int id;
        Picket picket;
        double amplitude, h_value;

        public int Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(nameof(Id));
            }
        }

        public double Amplitude
        {
            get { return amplitude; }
            set
            {
                amplitude = value;
                OnPropertyChanged(nameof(Amplitude));
            }
        }

        public double H_value
        {
            get { return h_value; }
            set
            {
                h_value = value;
                OnPropertyChanged(nameof(H_value));
            }
        }

        public Picket Picket
        {
            get { return picket; }
            set
            {
                picket = value;
                OnPropertyChanged(nameof(Picket));
            }
        }
    }
}
