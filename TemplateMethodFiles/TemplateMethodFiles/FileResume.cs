using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class FileResume : Resume
    {
        public FileResume(String login, String resumeSource) : base(login, resumeSource) { }
        public override void GetInformation()
        {
            getTheFileInformation();
        }
        public void getTheFileInformation()
        {            
            base.resumeInformation = "Это информация из прикрепленного файла";
        }
    }

}
