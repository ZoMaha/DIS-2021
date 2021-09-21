using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    abstract class Resume
    {
        public String login;
        public String resumeSource;
        public String resumeInformation = "";
        public Resume(String login, String resumeSource)
        {
            this.login = login;
            this.resumeSource = resumeSource;
        }
        public void TemplateMethod() // вызов шагов алгоритма
        {
            InitializeResume(login, resumeSource);
            GetInformation();
            Print(resumeInformation);
        }
        private void InitializeResume(String login, String resumeSource)
        {
            this.login = login;
            this.resumeSource = resumeSource;
        }
        public void Print(String resumeInformation)
        {
            Console.WriteLine("Резюме пользователя {0}: \n {1}", login, resumeInformation);
        }
        public abstract void GetInformation();

    }
}
