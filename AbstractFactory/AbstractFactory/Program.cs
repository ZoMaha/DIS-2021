using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            //Реализация паттерна Одиночка
            CarFactory ford_car = FordFactory.ObjectFordFactory;
            //CarFactory ford_car = new FordFactory();
            Client c1 = new Client(ford_car);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час, тип кузова: {2}",
            c1.ToString(), c1.RunMaxSpeed(), c1.GetBodyType());

            CarFactory audi_car = new AudiFactory();
            Client c2 = new Client(audi_car);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час, тип кузова: {2}",
            c2.ToString(), c2.RunMaxSpeed(), c2.GetBodyType());


            //Доступ к экземпляру класса Форд
            CarFactory ford2_car = FordFactory.ObjectFordFactory;
            Client c3 = new Client(ford_car);
            Console.WriteLine("Максимальная скорость {0} составляет {1} км/час, тип кузова: {2}", c3.ToString(), c3.RunMaxSpeed(), c3.GetBodyType());

        }
    }
}
