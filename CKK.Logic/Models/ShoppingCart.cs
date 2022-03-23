using System;

namespace CKK.Logic.Models
{ 
	public class ShoppingCart
	{	
		private Customer _customer;
		private ShoppingCartItem _product1;
		private ShoppingCartItem _product2;
		private ShoppingCartItem _product3;

		public ShoppingCart(Customer cust)
		{
			cust = _customer;
		}

		public int GetCustomerId()
        {
			return _customer;
        }

		public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
			if (prod = 1)
            {
				quantity += quantity;

            }
			if (prod = 2)
            {
				quantity += quantity;
            }
			if (prod = 3)
            {
				quantity += quantity;
            }
            else
            {
				return null;
            }
        }

		public ShoppingCartItem AddProduct(Product prod)
        {
			if (prod == 1)
            {
				_product1 = prod;
					
            }
			if (prod == 2)
            {
				_product2 = prod;
            }
			if (prod == 3)
            {
				_product3 = prod;
            }
			else
            {
				return null;
            }

        }

		public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
			if (prod == 1)
            {
				_product1 = quantity;

            }
			if (prod == 2)
            {
				_product2 = quantity;
            }
			if (prod == 3)
            {
				_product3 = quantity;
            }
            else
            {
				return null;
            } 
        }

		public ShoppingCartItem GetProductById(int id)
        {
			if ( id == 1)
            {
				return _product1;
            }
			if ( id == 2)
            {
				return _product2;
            }
			if ( id == 3)
            {
				return _product3;
			}
        }

		public decimal GetTotal()
        {
			return quantity * Product.GetPrice();
        }

		public ShoppingCartItem GetProduct(int productNum)
        {
			if (productNum == 1)
            {
				return _product1;
            }
			if (productNum == 2)
            {
				return _product2;
            }
			if (productNum == 3)
            {
				return _product3;
            }
        }




	}
}