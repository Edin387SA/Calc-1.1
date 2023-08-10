using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digitron!:D");

        while (true)
        {
            Console.WriteLine("\nIzaberite operaciju:");
            Console.WriteLine("1 - Sabiranje");
            Console.WriteLine("2 - Oduzimanje");
            Console.WriteLine("3 - Množenje");
            Console.WriteLine("4 - Dijeljenje");
            Console.WriteLine("5 - Izlaz");

            // Unos korisnikove opcije
            int opcija;
            while (!int.TryParse(Console.ReadLine(), out opcija) || opcija < 1 || opcija > 5)
            {
                Console.WriteLine("Unesite validan broj opcije (1-5).");
            }

            if (opcija == 5)
            {
                Console.WriteLine("Hvala na korištenju digitrona!");
                break;
            }

            Console.Write("Unesite prvi broj: ");
            double broj1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Unesite drugi broj: ");
            double broj2 = Convert.ToDouble(Console.ReadLine());

            double rezultat = 0;

            // Izvršavanje odabrane operacije
            switch (opcija)
            {
                case 1:
                    rezultat = broj1 + broj2;
                    break;
                case 2:
                    rezultat = broj1 - broj2;
                    break;
                case 3:
                    rezultat = broj1 * broj2;
                    break;
                case 4:
                    if (broj2 != 0)
                        rezultat = broj1 / broj2;
                    else
                        Console.WriteLine("Dijeljenje nulom nije dozvoljeno.");
                    break;
            }

            // Ispis rezultata
            Console.WriteLine("Rezultat: " + rezultat);
        }
    }
}
