namespace Lab2.Models
{
    public class Licz(double val)
    {
        private double value = val;

        /*   public Licz(double val)
           {
               value = val;
           }*/

        public void Add(double value)
        {
            this.value += value;
        }

        public void DisplayValue()
        {
            Console.WriteLine(value);
        }
    }
}

namespace Lab2.Models
{
    internal class Person
    {

        private string name;
        private string surname;
        private int age;
        private string pesel;

        public string Name
        {
            get { return name; }
            set
            {
                Console.Write(value);
                name = value;
            }
        }

        public string Surname
        {
            get { return surname; }
            set
            {
                surname = value;
            }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value < 0) age = 0;
                else age = value;
            }
        }

        public string Pesel => pesel;//{ get { return pesel; } }


        public Person()
        {
            name = "Test";
        }


        public Person(string name2)
        {
            name = name2;
        }

        public Person(int name2)
        {
            name = name2.ToString();
        }

        public void Welcome()
        {
            Console.WriteLine($"Witaj. Jestem {name}");
        }

        public void Welcome(string name2)
        {
            Console.WriteLine("Witaj");
        }

        public void Welcome(int x)
        {
            Console.WriteLine("Witaj");
        }

        public string Welcome(string name2, string name3)
        {
            Console.WriteLine("Witaj");
            return "Test";
        }

    }
}
﻿

    internal class Sumator
    {
        public int[] Numbers { get; set; } = new int[] { 10, 20, 30 };

        public int Sum() { return Numbers.Sum(); }
        public double SumDiv3() { return Numbers.Where(x => x % 3 == 0).Sum(); }

        public int Count() { return Numbers.Count(); }
        public void Display(int low, int high)
        {
            if (low < 0)
                low = 0;
            if (high > Numbers.Length - 1)
                high = Numbers.Length - 1;

            for (int i = low; i <= high; i++)
            {
                Console.WriteLine(Numbers[i]);
            }
        }
    }

