using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class DrankDriver : TransportService
    {
        public double Cost { get; set; }
        public DrankDriver(string name, int cost) :
        base(name)
        {
            Cost = cost;
        }
        public override double CostTransportation(double distance)
        {
            return distance * Cost;
        }
        public override string ToString()
        {
            string s = String.Format("Фирма {0}, доставка по цене {1}", Name, Cost);
            return s;
        }

    }
}
