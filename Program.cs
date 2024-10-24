namespace Laboratorium1
{
    //internal class Program
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Podaj liczbę");
    //        var input = Console.ReadLine();

    //        Console.WriteLine(IsEven(int.Parse(input)) ? "Parzysta" : "Nieparzysta");

    //    }


    //    static bool IsEven(int input)
    //    {
    //        return input % 2 == 0;
    //    }


    //    }
    //}
    class Program
    {
        static void Main()
        {
            int zakrespoczatkowy = 1;
            int zakreskoncowy = 30;

            Console.WriteLine("Liczby Parzyste miedzy {0} a {1} to", zakrespoczatkowy, zakreskoncowy);


            for (int i = zakrespoczatkowy; i <= zakreskoncowy; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}