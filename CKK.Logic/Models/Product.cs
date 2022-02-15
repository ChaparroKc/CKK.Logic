using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Product
    {
        private int Id;
        private string Name;
        private decimal Price;
        
        
        

        public int GetId()
        {
            return Id;
        }

        public int SetId(int, id)
        {
            Id = id;
        }

        public string GetName()
        {
            return Name;
        }

        public string SetName(string, name)
        {
            Name = name;
        }

        public decimal GetPrice()
        {
            return Price;

        }

        public decimal SetPrice(decimal, price)
        {
            Price = price;
        }
    }

}

