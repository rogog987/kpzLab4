using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz4.Models
{
    public class Notebook : ICloneable
    {
        public string CPU { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string GPU { get; set; }
        public string Display { get; set; }

        public void ShowConfiguration()
        {
            Console.WriteLine("Notebook Configuration:");
            Console.WriteLine($"CPU: {CPU}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"Storage: {Storage}");
            Console.WriteLine($"GPU: {GPU}");
            Console.WriteLine($"Display: {Display}");
        }

        // Метод для клонування (глибоке копіювання)
        public object Clone()
        {
            return new Notebook
            {
                CPU = this.CPU,
                RAM = this.RAM,
                Storage = this.Storage,
                GPU = this.GPU,
                Display = this.Display
            };
        }
    }
}
