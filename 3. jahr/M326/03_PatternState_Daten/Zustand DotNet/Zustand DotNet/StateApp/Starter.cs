//using Verhaltensmuster.Vermittler;

namespace Verhaltensmuster.Zustand
{
    public static class Starter
    {
        public static void Start()
        {
            Bewerbung b = new Bewerbung();
            b.Zustand = new Eingestellt(); //Nicht erlaubter Zustand
            b.Zustand = new Interviewt(); //Erlaubter Zustand
            b.Benachrichtige();
            b.Verarbeite();

        }
    }
}
