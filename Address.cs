using System;
namespace itvdn_001_classes
{
    public class Address
    {
        private int index;
        private string country;
        private string city;
        private string street;
        private int house;
        private int apartment;

        public int Index
        {
            get
            {
                return index;
            }
            set
            {
                index = value;
            }
        }

        public string Country 
        { 
            get
            {
                return country; 
            }
            set 
            { 
                country = value;
            }
        }  

        public string City
        { 
            get
            {
                return city;
            }
            set
            {
                city = value;
            }
        }

        public string Street { get; set; }
        public int House { get; set; }
        public int Apartment { get; set; }

        public Address()
        {
        }
    }
}
