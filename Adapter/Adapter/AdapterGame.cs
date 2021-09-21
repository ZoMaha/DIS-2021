using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    class AdapterGame : IGame
    {
        Monet mot;
        public AdapterGame(Monet mt) 
        { 
            mot = mt; 
        }
        public int Brosok() 
        { 
            return mot.BrosokM(); 
        }
    }
}
