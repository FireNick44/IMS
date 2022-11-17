using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Verhaltensmuster.Zustand
{
    public class Bewerbung
    {
        private IZustand zustand;

        public Bewerbung()
        {
            zustand = new Eingegangen();
        }

        public IZustand Zustand
        {
            get { return zustand; }
            set
            {
  		        if (value != zustand)
		        {
			        if (!IstZustandErlaubt(value))
				        Console.WriteLine("Diese Zustandsänderung ist nicht erlaubt");
			        else
				        zustand = value;
		        }              
            }
        }

        private bool IstZustandErlaubt(IZustand neuerZustand)
        {
            if (zustand is Eingegangen)
                return neuerZustand is Unvollstaendig || neuerZustand is Interviewt;
            if (zustand is Unvollstaendig)
                return neuerZustand is Abgesagt || neuerZustand is Eingegangen;
            if (zustand is Interviewt)
                return neuerZustand is Abgesagt || neuerZustand is Eingeladen;
            if (zustand is Abgesagt)
                return false;
            if (zustand is Eingeladen)
                return neuerZustand is Talentpool || neuerZustand is Eingestellt || neuerZustand is Abgesagt;
            if (zustand is Talentpool)
                return false;
            if (zustand is Eingestellt)
                return false;
            return false;
        }

        public void Benachrichtige()
        {
            zustand.Benachrichtige();
        }

        public void Verarbeite()
        {
            zustand.Verarbeite();
        }
    }
}
