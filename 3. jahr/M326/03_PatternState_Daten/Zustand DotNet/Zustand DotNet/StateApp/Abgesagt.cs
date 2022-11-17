using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verhaltensmuster.Zustand
{
    public class Abgesagt : IZustand
    {
        public void Benachrichtige()
        {
            //Benachrichtige den Bewerber
        }

        public void Verarbeite()
        {
            //Verarbeitungsschritte
        }
    }
}
