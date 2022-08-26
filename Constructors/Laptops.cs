using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Laptops
    {
        public string brand;
        public string processor;
        public string storageCapacity;
        public string model;
        public double screenSize;
        public string RAM;

        public Laptops( string name) 
        {
            Console.WriteLine(name);
        }
    }
}
