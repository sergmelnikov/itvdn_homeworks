using System;

namespace itvdn_001_classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Address myAddress = new Address();
            myAddress.Index = 140501;
            myAddress.Country = "Russia";
            myAddress.City = "Lukhovitsy";
            myAddress.Street = "Mira";
            myAddress.House = 13;
            myAddress.Apartment = 17;

            Console.WriteLine(myAddress.Index);
            Console.WriteLine(myAddress.Country);
            Console.WriteLine(myAddress.City);
            Console.WriteLine(myAddress.Street);
            Console.WriteLine(myAddress.House);
            Console.WriteLine(myAddress.Apartment);
        }
    }
}
