﻿using System;
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
                new Product = Product1;
                return Product1;
                
            }
            else if(prod == Product2)
            {
                new Product() = Product2;
                return Product2;
            }
            else if(prod == Product3)
            {
                new Product() = Product3;
                return Product3;
            }
            else
            {
                return null;
            }
            return prod;


        }

        public Product RemoveStoreItem(int productNum)
        {
            if(productNum == 1)
            {
                Product1 = null;
                return Product1;
            }
            if (productNum == 1)
            {
                Product2 = null;
                return Product2;
            }
            if (productNum == 1 )
            {
                Product3 = null;
                return Product3;
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
