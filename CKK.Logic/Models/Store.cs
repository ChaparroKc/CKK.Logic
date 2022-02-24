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
            if (a != 1)
            {
                Product Product1 = new Product();
                a++;
            }
            if (b != 1)
            { 
                Product Product2 = new Product();
                b++;
            }
            if (c != 1)
            {
                Product Product3 = new Product();
                c++;
            }
            return prod;
        }

        public int RemoveStoreItem(int productNum)
        {

        }

        public Product GetStoreItem(int productNum)
        {

        }

        public Product FindStoreItemById(int id)
        {
            
        }
    }
}
