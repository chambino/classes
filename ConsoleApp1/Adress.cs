using System;
using System.Collections.Generic;
using System.Text;

namespace Human
{
    class Adress_
    {
        private string country;
        private string region;
        private string street;

        public string Country { set; get; }
        public string Region { set; get; }
        public int Street { set; get; }

        public void Adress1(string Country, string Region, string Street)
        {
            region = Region;
            country = Country;
            street = Street;
            
        }

        public void GetInfo()
        {
            Console.WriteLine("Country = {0} Region = {1} Street = {2}", this.country, this.region, this.street); 
        }


    }
}
