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

        public void SetId(id int)
        {
            Id = id;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(name string)
        {
            Name = name;
        }

        public decimal GetPrice()
        {
            return Price;

        }

        public void SetPrice(price decimal)
        {
            Price = price;
        }
    }

}

