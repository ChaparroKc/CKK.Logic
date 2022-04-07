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
			return _customer;
        }

		public ShoppingCartItem AddProduct(Product prod, int quantity)
        {
			if( quantity < 1)
            {
				return null;
            }
			if (prod != null && _product1.StoreItem() = _product1.ShoppingCartItem())
            {
				return ShoppingCartItem._product(SetQuantity) += quantity;
            }
			if (_product2 != null && ShoppingCartItem.GetProduct() = Product.GetId())
			{
				return _product2.GetQuantity += quantity;
			}
			if (_product3 != null && ShoppingCartItem.GetProduct() = Product.GetId())
			{
				return _product3.GetQuantity += quantity;
			}
            else
            {
				if (_product1 = null)
                {
					return _product1.ShoppingCartItem(prod, quantity);
                }
				if (_product2 = null)
				{
					return _product2.ShoppingCartItem(prod, quantity);
				}
				if (_product3 = null)
				{
					return _product3.ShoppingCartItem(prod, quantity);
				}

			}


		}

		public ShoppingCartItem AddProduct(Product prod)
        {
			if(_product1 = null)
            {
				return _product1.ShoppintCartItem(prod);
            }
			if(_product2 = null)
            {
				return _product2.ShoppingCartItem(prod);
            }
			if(_product3 = null)
            {
				return _product3.ShoppingCartItem(prod);
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