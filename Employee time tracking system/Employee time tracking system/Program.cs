using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_time_tracking_system
{
    class Program
    {
        static void Main(string[] args)
        {

            ////Цепочка обязанностей
            Receiver receiverLunch = new Receiver(false, true);
            Receiver receiverComp = new Receiver(true, false);
            Receiver receiverGlitch = new Receiver(false, false);
            //объекты причин
            ReasonHandler completionHandler = new CompletionHandler();
            ReasonHandler lunchHandler = new LunchHandler();
            ReasonHandler glitchHadler = new GlitchHandler();
            //Укзываем порядок цепочки
            lunchHandler.Successor = completionHandler;
            completionHandler.Successor = glitchHadler;
            //Проверка всех 3х вариантов
            Console.WriteLine("--Варианты завершения или прервания рабочего сеанса\n");
            lunchHandler.Handle(receiverLunch);
            lunchHandler.Handle(receiverComp);
            lunchHandler.Handle(receiverGlitch);

            //Одиночка
            //логин пользователя должен считываться со смарт-карты
            Console.WriteLine("\n\n--Один пользователь");
            Console.WriteLine("Считанный логин (нужно ввести)");
            User user = UserEmployeer.ObjectUser;
            user.login = Console.ReadLine();
            User user2 = UserEmployeer.ObjectUser;
            Console.WriteLine("Логин пользователя: {0}", user2.login);


            //Шаблонный метод
            //При завершении рабочего сеанса пользователь выбирает как получить отчет
            Console.WriteLine("\n\n--Варианты получения отчета\n");
            ReportStrategy action = new TextReport();
            Report res = new Report(action);
            res.GetInformationAction();
            res.PrintInformation();

            action = new FileReport();
            res = new Report(action);
            res.GetInformationAction();
            res.PrintInformation();

            Console.ReadKey();
        }
    }
}
