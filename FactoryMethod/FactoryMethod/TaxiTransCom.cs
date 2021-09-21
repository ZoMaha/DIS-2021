using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class TaxiTransCom : TransportCompany
    {
        public TaxiTransCom(string name) 
            : base(name)
        { }
        public override TransportService Create(string name, int category)
        {
            return new TaxiServices(Name, category);
        }
    }

}
