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
        private Product _product1;
        private Product _product2;
        private Product _product3;
        


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

        public Product AddStoreItem(Product product)
        {
            if(_product1 == null)
            {
                _product1 = product;
                return _product1;
            }else if(_product2 == null)
            {
               _product2 = product;
               return _product2;
            }else if(_product3 == null)
            {
                _product3 = product;
                return _product3;
            }else
            {
                return null;
            }
            
            
            
            
        }

        public Product RemoveStoreItem(int productNum)
        {
            if(productNum == 1)
            {
                _product1 = null;
                return _product1;
            }
            if (productNum == 1)
            {
                _product2 = null;
                return _product2;
            }
            if (productNum == 1 )
            {
                _product3 = null;
                return _product3;
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
                return _product1;
            }
            if(productNum == 1)
            {
                return _product2;
            }
            if(productNum == 1)
            {
                return _product3;
            }
            else
            {
                return null;
            }
        }
        public Product FindStoreItemById(int id)
        {
           if(id == 1)
            {
                return _product1;
            }
           if(id == 1)
            {
                return _product2;
            }
           if(id == 1)
            {
                return _product3;
            }
            else
            {
                return null;
            }
        } 
    }
}
