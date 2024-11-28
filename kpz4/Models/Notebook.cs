using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kpz4.Models
{
    public class Notebook
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
    }
}
