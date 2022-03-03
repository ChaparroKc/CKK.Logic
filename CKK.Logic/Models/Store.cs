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
        private Product product1;
        private Product product2;
        private Product product3;
        


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
            if(product1 == null)
            {
                product1 = prod;
                return product1;
            }
            else if(product2 == null)
            {
               product2 = prod;
               return product2;
            }
            else if(product3 == null)
            {
                product3 = prod;
                return product3;
            }
            
        }

        public Product RemoveStoreItem(int productNum)
        {
            if(productNum == 1)
            {
                product1 = null;
                return product1;
            }
            if (productNum == 1)
            {
                product2 = null;
                return product2;
            }
            if (productNum == 1 )
            {
                product3 = null;
                return product3;
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
                return product1;
            }
            if(productNum == 1)
            {
                return product2;
            }
            if(productNum == 1)
            {
                return product3;
            }
            else
            {
                return null;
            }
        }
        public Product FindStoreItemById(int id)
        {
           if(Id == id)
            {
                return product1;
            }
           if(Id == id)
            {
                return product2;
            }
           if(Id == id)
            {
                return product3;
            }
            else
            {
                return null;
            }
        } 
    }
}
