using System;

namespace classes_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice2321 = new Invoice(31232, "Dmitry Medvedev", "Swift");
            invoice2321.Article = "iPhone";
            invoice2321.Quantity = 10;
            Console.WriteLine($"Customer: {invoice2321.Customer}");
            Console.WriteLine($"Article: {invoice2321.Article}");
            Console.WriteLine($"Quantity: {invoice2321.Quantity}");
            invoice2321.TaxCalculator();
        }
    }
}
