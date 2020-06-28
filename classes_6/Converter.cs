using System;
namespace classes_6
{
    public class Converter
    {
        // Courses of main currensies to ukranian hryvna
        double usd, eur, rub;

        public Converter(double usd, double eur, double rub)
        {
            this.usd = usd;
            this.eur = eur;
            this.rub = rub;
        }

        public void ToUSD(double uah)
        {
            double result = uah * usd;
            Console.WriteLine($"{uah} UAH in USD equals {result:f2}");
        }

        public void ToEUR(double uah)
        {
            double result = uah * eur;
            Console.WriteLine($"{uah} UAH in EUR equals {result:f2}");
        }

        public void ToRUB(double uah)
        {
            double result = uah * rub;
            Console.WriteLine($"{uah} UAH in RUB equals {result:f2}");
        }

        public void ToUAH(double value, string currency)
        {
            double result = 0;
            switch (currency)
            {
                case "USD":
                    result = value / usd;
                    break;
                case "EUR":
                    result = value / eur;
                    break;
                case "RUB":
                    result = value / rub;
                    break;
                default:
                    Console.WriteLine("This currency unavailable");
                    break;
            }
            Console.WriteLine($"{value} {currency} in UAH equals {result:f2}");
        }
    }
}
