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
            if(prod == Product1)
            {
               Product1 = prod;
                return prod;
            }
            else if(prod == Product2)
            {
                Product2 = prod;
                return prod;
            }
            else if(prod == Product3)
            {
                Product3 = prod;
                return prod;
            }
            else
            {
                return null;
            }


        }

        public int RemoveStoreItem(int productNum)
        {
            if(productNum == 1)
            {
                Product;
                return productNum;
            }
            else
            {
                return null;
            }
        }

        public Product GetStoreItem(int productNum)
        {
            if(productNum == 1)
            {
                return Product1;
            }
            if(productNum == 1)
            {
                return Product2;
            }
            if(productNum == 1)
            {
                return Product3;
            }
            else
            {
                return null;
            }
        }
        public Product FindStoreItemById(int id)
        {
            return FindStoreItemById(id);
        }
    }
}
