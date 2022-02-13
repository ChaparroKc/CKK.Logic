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

        _id = Id;
        _name = Name;
        _price = Price;

        public int GetId()
        {
            return Id;
        }

        public void SetId(int Id)
        {
            _id = Id;
        }

        public string GetName()
        {
            return Name;
        }

        public void SetName(string Name)
        {
            _name = Name;
        }

        public decimal GetPrice()
        {
            return Price;

        }

        public void SetPrice(decimal Price)
        {
            _price = Price;
        }
    }

}

