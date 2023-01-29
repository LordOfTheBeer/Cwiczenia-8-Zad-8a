using System.Xml;

namespace Cwiczenia_8_Zad_8a
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Obliczanie Oceny Semestralnej. \n (Podaj min. 3 oceny)");
            Console.WriteLine(" ");
            double nota;
            double Średnia = 0;

            List<double> Oceny = new List<double>();

            do
            {
                Console.WriteLine("Podaj swoją ocenę (lub 0 - aby zakonczyć)");
                nota = Convert.ToDouble(Console.ReadLine());
                if (nota !=0) Oceny.Add(nota);
                Console.WriteLine(" ");

            } while (nota != 0);

            Oceny.Sort();

            Oceny.RemoveAt(0);

            Oceny.RemoveAt(Oceny.Count - 1);

            for (int j = 0; j < Oceny.Count; j++)
                Średnia += Oceny[j];
            Console.WriteLine("Średnia = {0:f2}", Średnia / Oceny.Count);
            
                
            



            Console.ReadKey();
        }
    }
}