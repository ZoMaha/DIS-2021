using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class AdditionalLights : DecoratorOptions
    {

        public AdditionalLights(AutoBase auto, string title) : base(auto, title)
        {
            AutoProperty = auto;
            Name = auto.Name + ". Яркий";
            Description = auto.Description + ". " + this.Title + ". Повышенная производительность элементов освещения";

        }
        public override double GetCost()
        {
            return AutoProperty.GetCost() + 231.26;
        }

    }
}
