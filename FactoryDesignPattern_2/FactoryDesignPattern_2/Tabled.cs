using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern_2
{
    internal class Tabled:IProduct
    {
        int inch;
        public Tabled(int inch)
        {
            this.inch = inch;
        }

       

        public string GetName(string productName)
        {

            return inch + productName + "Tablet Üretildi";
            
        }

        public double GetPrice()
        {
            return 9999.25;
        }
    }
}
