using System;
namespace ConsoleApp2
{

    class car
    {
        public string brand;
        public int FoundationYear;
        public car()
        {
            brand = "audi";
            FoundationYear = 2000;
        }
        static void Main(string[] args)
        {
            car mycar = new car();
            mycar.Print();
        }
        public void Print()
        {
            Console.WriteLine($"Бренд: {brand} Дата выпуска: {FoundationYear} ");
        }
    }
}