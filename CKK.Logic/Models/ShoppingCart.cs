using System;

namespace CKK.Logic.Models
{ 
	public class ShoppingCart
	{	
		private Customer _customer;
		private ShoppingCartItem _product1;
		private ShoppingCartItem _product2;
		private ShoppingCartItem _product3;

		public ShoppingCart(cust customer)
		{
			Customer = _customer;
		}

		public int GetCustomerId()
        {
			return _customer;
        }

		public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
			if (prod == 1)
            {
				_product1 += quantity;

            }
			if (prod == 2)
            {
				_product2 += quantity;
            }
			if (prod == 3)
            {
				_product3 += quantity;
            }
            else
            {
				return null;
            }
        }

		public ShoppingCartItem AddProduct(Product prod)
        {

        }


	}
}