using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class WebResume : Resume
    {
        public WebResume(String login, String resumeSource) : base(login, resumeSource) { }
        public override void GetInformation()
        {
            getTheTextPageInformation();
        }
        public void getTheTextPageInformation()
        {
            base.resumeInformation = "Это информация с указанного сайта";
        }
    }

}
