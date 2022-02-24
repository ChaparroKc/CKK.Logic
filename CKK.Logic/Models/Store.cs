using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int Id;
        private string Name;
        private Product Product1;
        private Product Product2;
        private Product Product3;
        // Product1 = a
        int a;
        // Product2 = b
        int b;
        // Product3 = c
        int c;


        public int GetId()
        {
            return Id;
        }

        public int SetId(int id)
        {
            return Id = id;
        }

        public string GetName()
        {
            return Name;
        }

        public string SetName(string name)
        {
            return Name = name;
        }

        public Product AddStoreItem(Product prod)
        {
            if(Product1 = 0 )
            {
                Product1 = new Product();
            }
            if (Product2 = 0)
            {
                Product2 = new Product();
            }
            if (Product3 = 0)
            {
                Product3 = new Product();
            }
            return prod;
        }

        public int RemoveStoreItem(int productNum)
        {
            return productNum;
        }

        public Product GetStoreItem(int productNum)
        {
            return productNum;
        }

        public Product FindStoreItemById(int id)
        {
            return id;
        }
    }
}
