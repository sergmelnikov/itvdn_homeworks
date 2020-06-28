using System;

namespace classes_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Converter conv = new Converter(0.037, 0.033, 2.62);
            conv.ToEUR(100);
            conv.ToUSD(100);
            conv.ToRUB(100);
            conv.ToUAH(100, "USD");
            conv.ToUAH(100, "EUR");
            conv.ToUAH(100, "RUB");
        }
    }
}
