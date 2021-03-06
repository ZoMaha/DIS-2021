using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class AudiCar : AbstractCar
    {
        public AudiCar(string name)
        {
            Name = name;
        }
        public override int MaxSpeed(AbstractEngine engine)
        {
            int ms = engine.max_speed;
            return ms;
        }
        public override String BodyType(AbstractBody body)
        {
            String type = body.bodyType;
            return type;
        }
        public override string ToString()
        {
            return "Автомобиль " + Name;
        }

    }
}
