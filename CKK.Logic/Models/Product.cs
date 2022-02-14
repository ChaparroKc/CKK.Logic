using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Product
    {
        private int _id;
        private string _name;
        private decimal _price;
        
        

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

        public void SetName(string _name)
        {
            _name = Name;
        }

        public decimal GetPrice()
        {
            return Price;

        }

        public void SetPrice(decimal _price)
        {
            _price = Price;
        }
    }

}

