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
        
        int id;
        string name;
        decimal price;
        

        public int GetId()
        {
            return id;
        }

        public void SetId(int id)
        {
            _id = id;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            _name = name;
        }

        public decimal GetPrice()
        {
            return price;

        }

        public void SetPrice(decimal price)
        {
            _price = price;
        }
    }

}

