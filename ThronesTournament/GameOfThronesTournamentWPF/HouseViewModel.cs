using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using WebApiGoT.Models;

namespace GameOfThronesTournamentWPF
{
    class HouseViewModel : INotifyPropertyChanged
    {
        HouseDTO _house;

        public HouseDTO House { get; set; }
        public int NumberUnits { get; set; }

        public HouseViewModel()
        {
            _house = new HouseDTO();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void RaisePropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
