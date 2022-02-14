using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class StoreItem
    {
        private Product _product;
        private int _quantity;

        public StoreItem(Product product, int Quantity)
        {
            _product = Product;
            _quantity = Quantity;

        }
        
        public int GetQuantity()
        {
            return _quantity; 

        }

        public void SetQuantity(int Quantity)
        {
            return _quantity;
        }
        public  Product GetProduct()
        {
            return _product;
        }

        public void SetProduct(Product _product)
        {
            return Product;
        }

       
    }
}
