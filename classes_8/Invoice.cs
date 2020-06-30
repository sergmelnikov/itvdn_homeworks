using System;
namespace classes_8
{
    public class Invoice
    {
        private readonly int account;
        private readonly string customer, provider;

        public int Account { get; }
        public string Customer
        {
            get
            {
                return customer;
            }
        }

        public string Provider { get; }

        private string article;
        private int quantity;

        public string Article
        {
            set 
            {
                if (value != null)
                {
                    article = value;
                }
            }
            get
            {
                return article;
            }
        }

        public int Quantity
        { 
            set
            {
                if (value > 0)
                {
                    quantity = value;
                }
            }
            get
            {
                return quantity;
            }
        }

        public void TaxCalculator()
        {
            double price = 0;
            switch (article)
            {
                case "iPhone":
                    price = 699;
                    break;
                case "MacBook":
                    price = 999;
                    break;
                case "iMac":
                    price = 1299;
                    break;
                default:
                    Console.WriteLine("Unavailable article");
                    break;
            }
            price *= quantity;
            Console.WriteLine($"Price: ${price}. With tax: ${price * 1.2}");
        }

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
    }
}
