using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    /*
    class FordFactory : CarFactory
    {
        public override AbstractCar CreateCar()
        {
            return new FordCar("Форд");
        }
        public override AbstractEngine CreateEngine()
        {
            return new FordEngine();
        }
        public override AbstractBody CreateBody()
        {
            return new FordBody();
        }

    }
*/

 //Реализация паттерна Одиночка
    class FordFactory : CarFactory
    {
        FordFactory() { }
        static Lazy<FordFactory> objectFordFactory = new Lazy<FordFactory>(() => new FordFactory());
        public static FordFactory ObjectFordFactory
        {
            get
            {
                return objectFordFactory.Value;
            }
        }

        public override AbstractCar CreateCar()
        {
            return new FordCar("Форд");
        }
        public override AbstractEngine CreateEngine()
        {
            return new FordEngine();
        }
        public override AbstractBody CreateBody()
        {
            return new FordBody();
        }
    }
 
}
