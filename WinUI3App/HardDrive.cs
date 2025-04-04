using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI3App
{
    // Represents a Hard Drive with properties that notify UI when changed
    public class HardDrive : INotifyPropertyChanged
    {
        // Properties for the Hard Drive with change notification
        private string _model;
        public string Model
        {
            get { return _model; }
            set
            {
                if (_model != value)
                {
                    _model = value;
                    OnPropertyChanged(nameof(Model));
                }
            }
        }

        private string _manufacturer;
        public string Manufacturer
        {
            get { return _manufacturer; }
            set
            {
                if (_manufacturer != value)
                {
                    _manufacturer = value;
                    OnPropertyChanged(nameof(Manufacturer));
                }
            }
        }

        private string _type;
        public string Type
        {
            get { return _type; }
            set
            {
                if (_type != value)
                {
                    _type = value;
                    OnPropertyChanged(nameof(Type));
                }
            }
        }

        private double _capacity;
        public double Capacity
        {
            get { return _capacity; }
            set
            {
                if (_capacity != value)
                {
                    _capacity = value;
                    OnPropertyChanged(nameof(Capacity));
                }
            }
        }



        // Constructor to initialize a Hard Drive object
        public HardDrive(string model, string manufacturer, string type, double capacity)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Type = type;
            this.Capacity = capacity;
        }

        // Event that is triggered when a property value changes
        public event PropertyChangedEventHandler PropertyChanged;

        // Method to notify UI that a property has changed
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
