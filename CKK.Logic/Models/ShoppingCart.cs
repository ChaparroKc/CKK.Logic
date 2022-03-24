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
			Customer = cust;
		}

		public int GetCustomerId()
        {
			return _customer;
        }

		public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
			if (prod = _product1)
            {
				ShoppingCart(quantity) += quantity;

            }
			if (prod = _product2)
            {
				ShoppingCart(quantity) += quantity;
            }
			if (prod = _product3)
            {
				ShoppingCart(quantity) += quantity;
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
				ShoppingCartItem(prod) = _product1;
					
            }
			if (prod == 2)
            {
				ShoppingCartItem(prod) = _product2;
            }
			if (prod == 3)
            {
				ShoppingCartItem(prod) = _product3;
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
				ShoppingCartItem(quantity) -= quantity;

            }
			if (prod == 2)
            {
				ShoppingCartItem(quantity) -= quantity;
            }
			if (prod == 3)
            {
				ShoppingCartItem(quantity) -= quantity;
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