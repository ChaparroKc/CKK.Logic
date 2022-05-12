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
			_customer = cust;
		}

		public int GetCustomerId()
        {
			return _customer.GetId();
        }

		public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
			if( quantity < 1)
            {
				return null;
            }
			if(_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
            {
				ShoppingCartItem _product1 = new ShoppingCartItem(prod, quantity);
			}
			if(_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
            {
				ShoppingCartItem _product2 = new ShoppingCartItem(prod, quantity);
            }
			if(_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
            {
				ShoppingCartItem _product3 = new ShoppingCartItem(prod, quantity);
			}

		}


	

		public ShoppingCartItem AddProduct(Product prod)
        {
			if(_product1 = null)
            {
				ShoppingCartItem _product1 = new ShoppingCartItem(prod);
            }
			if(_product2 = null)
            {
				ShoppingCartItem _product2 = new ShoppingCartItem(prod);
			}
			if(_product3 = null)
            {
				ShoppingCartItem _product3 = new ShoppingCartItem(prod);
			}
            else
            {
				return null;
            }

        }

		public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
			if (quantity < 1)
			{
				return null;
			}
			if (_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
			{
				ShoppingCartItem _product1 = new ShoppingCartItem(prod, quantity);
			}
			if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
			{
				ShoppingCartItem _product2 = new ShoppingCartItem(prod, quantity);
			}
			if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
			{
				ShoppingCartItem _product3 = new ShoppingCartItem(prod, quantity);
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