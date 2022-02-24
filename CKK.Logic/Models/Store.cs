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
            return prod;
        }

        public int RemoveStoreItem(int productNum)
        {
            return productNum;
        }

        public Product GetStoreItem(int productNum)
        {
            return GetStoreItem(productNum);
        }

        public Product FindStoreItemById(int id)
        {
            return FindStoreItemById(id);
        }
    }
}
