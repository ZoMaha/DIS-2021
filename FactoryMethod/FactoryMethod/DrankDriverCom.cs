using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class DrankDriverCom : TransportCompany
    {
        public DrankDriverCom(string name)
            : base(name)
        { }
        public override TransportService Create(string name, int cost)
        {
            return new TaxiServices(Name, cost);
        }

    }
}
