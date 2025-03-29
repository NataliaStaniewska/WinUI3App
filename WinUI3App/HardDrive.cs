using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI3App
{
    internal class HardDrive
    {
        public string model {  get; set; }
        public string manufacturer {  get; set; }
        public string type { get; set; }
        public int capacity { get; set; }
        

        public HardDrive(string model, string manufacturer, string type, int capacity)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.type = type;
            this.capacity = capacity;
        }

        
        public void GetInfo()
        {
            Console.WriteLine("Model: " + this.model);
            Console.WriteLine("Manufacturer: " + this.manufacturer);
            Console.WriteLine("Type: " + this.type);
            Console.WriteLine("Capacity GB: " + this.capacity);

        }
    }
}
