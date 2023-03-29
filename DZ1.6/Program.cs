using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DZ1._6
{
    class Program
    {
        static void Main(string[] args)
        {
            Address adress = new Address("1", " 2", " 3", " 4", " 5", " 6");
            Console.WriteLine(adress.index + adress.country + adress.city + adress.street + adress.house + adress.apartment);
            Console.ReadLine();
        }
        class Address
        {
            public string index { get; set; }
            public string country { get; set; }
            public string city { get; set; }
            public string street { get; set; }
            public string house { get; set; }
            public string apartment { get; set; }
            public Address(string index, string country, string city, string street, string house, string apartment)
            {
                this.index = index;
                this.country = country;
                this.city = city;
                this.street = street;
                this.house = house;
                this.apartment = apartment;
            }
        }
    }
}
