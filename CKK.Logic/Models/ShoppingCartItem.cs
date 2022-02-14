using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class ShoppingCartItem
    {
        private Product _product;
        private int _quantity;

        public ShoppingCartItem(Product product, int Quantity)
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
             _quantity = Quantity;
        }

        public Product GetProduct()
        {
            return _product;
        }

        public void SetProduct(string Product)
        {
            _product = Product;
        }

    }
}
