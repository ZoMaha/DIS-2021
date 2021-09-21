using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            String login = "Zo_Maha";
            String resumeSource = "Я просто пишу резюме. Не прикрепляю фалы, не указыва ссылки. Просто пишу.";
            Resume textResume = new TextResume(login, resumeSource);
            textResume.TemplateMethod();
            Console.WriteLine();
            Resume fileResume = new FileResume(login, resumeSource);
            fileResume.TemplateMethod();
            Console.WriteLine();
            Resume webResume = new WebResume(login, resumeSource);
            webResume.TemplateMethod();
            Console.ReadKey();
        }
    }
}
