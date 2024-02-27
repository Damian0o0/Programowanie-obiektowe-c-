namespace sprawdzian
{
    internal class Program
    {
    }
    static class Autor
    {
        public static string imie = "Ninja";
        public static string jezyk = "C++";
        public static int artykuly = 420;

        public static void informacje()
        {
            Console.WriteLine("Informacje na temat autora: ");
        }
    }
    public class kox
    {
        static public void Main()
        {
            Autor.informacje();

            Console.WriteLine("Imie autora: {0} ", Autor.imie);
            Console.WriteLine("Język programowania: {0} ", Autor.jezyk);
            Console.WriteLine("Łączna liczba artykułów : {0} ", Autor.artykuly);
            Console.WriteLine("---------------------------------------------");
            //pole trojkata
            int bok1 = 1, bok2 = 5, bok3 = 3;
            Console.WriteLine($"Wartosc boku1 = {bok1}, boku2 = {bok2}, boku3 = {bok3}");
            double asfs = (bok1 + bok2 + bok3) / 2;
            double Pole = Math.Sqrt(asfs * (asfs - bok1) * (asfs - bok2) * (asfs - bok3));
            Console.Write("Pole tego trójkąta to = " + Pole);
            Console.ReadKey();
        }
    }
}