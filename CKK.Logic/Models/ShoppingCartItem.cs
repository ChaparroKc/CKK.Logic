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

        public ShoppingCartItem(Product product, int quantity)
        {
            product = _product;
            quantity = _quantity;
        }
        
        public int GetQuantity()
        {
            return _quantity;
        }
        
        public void SetQuantity(int quantity)
        {
             quantity = _quantity;
        }

        public Product GetProduct()
        {
            return _product;
        }

        public void SetProduct(Product product)
        {
            _product = product;
        }
        public decimal GetTotal()
        {
            return Product.GetPrice() * ShoppingCartItem.GetQuantity();
        }
    }
}
