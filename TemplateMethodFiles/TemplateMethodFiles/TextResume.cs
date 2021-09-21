using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethod
{
    class TextResume : Resume
    {
        public TextResume(String login, String resumeSource) : base(login, resumeSource) { }
        public override void GetInformation()
        {
            base.resumeInformation = resumeSource;
        }
    }

}
