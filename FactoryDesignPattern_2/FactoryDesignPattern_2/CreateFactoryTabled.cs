using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern_2
{
    internal class CreateFactoryTabled : IFactory
    {
        int inch;

        public CreateFactoryTabled(int inch)
        {
            this.inch = inch;
        }
        public IProduct CreatePrudct()
        {
            return new Television(inch);
        }
    }
}