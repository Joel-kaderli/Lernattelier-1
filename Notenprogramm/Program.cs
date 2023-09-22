namespace Notenprogramm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variablen
            bool weitereNotenErgebnis = true;
            double aktuelleNote = 0;
            double notenschnitt = 0;
            int anzahlNoten = 0;
            bool eingabeValidiert;

            while (weitereNotenErgebnis)
            {
                try
                {
                    Console.WriteLine("Deine Note: ");
                    double note = Convert.ToDouble(Console.ReadLine());
                    if (note < 0)
                    {
                        throw new Exception();
                    }
                    if (note >= 6 || note < 1)
                    {
                        throw new Exception();
                    }
                }
                catch
                {
                    Console.WriteLine("Fehler");
                }
                 notenschnitt = (notenschnitt * anzahlNoten + aktuelleNote) / ++anzahlNoten;
                Console.WriteLine("Ihr akueller Notenschnitt " + notenschnitt);

            }
        }
    }
}