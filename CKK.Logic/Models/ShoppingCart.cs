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
			
        }

		public ShoppingCartItem AddProduct(Product prod)
        {

        }


	}
}