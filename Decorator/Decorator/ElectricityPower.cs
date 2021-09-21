using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class ElectricityPower : DecoratorOptions
    {

        public ElectricityPower(AutoBase auto, string title) : base(auto, title)
        {
            AutoProperty = auto;
            Name = auto.Name + ". Электроприводный";
            Description = auto.Description + ". " + this.Title + ". Экологичный электродвигатель";

        }
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 436.15;
        }
    }

}
