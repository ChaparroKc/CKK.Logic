using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Store
    {
        private int _id;
        private string _name;
        private Product _product1;
        private Product _product2;
        private Product _product3;
        
        public int GetId()
        {
            return _id;
        }

        public int SetId(int id)
        {
            return _id = id;
        }

        public string GetName()
        {
            return _name;
        }

        public string SetName(string name)
        {
            return _name = name;
        }

        public void AddStoreItem(Product product)
        {
            if(_product1 == null)
            {
                _product1 = product;
                
            }else if(_product2 == null)
            {
               _product2 = product;
               
            }else if(_product3 == null)
            {
                _product3 = product;
                
            }
        }

        public void RemoveStoreItem(int productNum)
        {
            if(productNum == 1)
            {
                _product1 = null;
                //return _product1;
            }else if (productNum == 1)
            {
                _product2 = null;
                //return _product2;
            }else if (productNum == 1 )
            {
                _product3 = null;
                //return _product3;
            }
        }

        public Product GetStoreItem(int productNum)
        {
            if(productNum == 1)
            {
                return _product1;
            }if(productNum == 1)
            {
                return _product2;
            }if(productNum == 1)
            {
                return _product3;
            }else
            {
                return null;
            }         
        }
        public Product FindStoreItemById(int id)
        {
           if(id == Id)
           {
               return _product1;
           }if(id == Id)
           {
               return _product2;
           }if(id == Id)
           {
               return _product3;
           }else
           {
               return null;
           }
        } 
    }
}
