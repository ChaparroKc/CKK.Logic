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
				_product1.SetQuantity(_product1.GetQuantity() + quantity);
				
				return _product1;
				
			}
            
			if(_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
            {
				_product2.SetQuantity(_product2.GetQuantity() + quantity);
				return _product2;
				
            }
			if(_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
            {
				_product3.SetQuantity(_product3.GetQuantity() + quantity);
				return _product3;
				
			}
			if(_product1 == null)
            {
				ShoppingCartItem _product1 = new ShoppingCartItem(prod, 1);
				return _product1;
            }
			if(_product2 == null)
            {
				ShoppingCartItem _product2 = new ShoppingCartItem(prod, 1);
				return _product2;
			}
			if(_product3 == null)
            {
				ShoppingCartItem _product3 = new ShoppingCartItem(prod, 1);
				return _product3;
			}
            else
            {
				return null;
            }

		}


	

		public ShoppingCartItem AddProduct(Product prod)
        {
			return AddProduct(prod, 1);		

        }

		public ShoppingCartItem RemoveProduct(Product prod, int quantity)
        {
			if (quantity < 1)
			{
				return null;
			}
			if (_product1 != null && _product1.GetProduct().GetId() == prod.GetId())
			{
				_product1.SetQuantity(_product1.GetQuantity() - quantity);
				return _product1;

			}

			if (_product2 != null && _product2.GetProduct().GetId() == prod.GetId())
			{
				_product2.SetQuantity(_product2.GetQuantity() - quantity);
				return _product2;

			}
			if (_product3 != null && _product3.GetProduct().GetId() == prod.GetId())
			{
				_product3.SetQuantity(_product3.GetQuantity() - quantity);
				return _product3;

			}
			if(_product1 == null)
            {
				ShoppingCartItem _product1 = new ShoppingCartItem(prod, 1);
				return _product1;
            }
			if(_product2 == null)
            {
				ShoppingCartItem _product2 = new ShoppingCartItem(prod, 1);
				return _product2;
			}
			if(_product3 == null)
            {
				ShoppingCartItem _product3 = new ShoppingCartItem(prod, 1);
				return _product3;
			}
            else
            {
				return null;
            }
			
		}

		public ShoppingCartItem GetProductById(int id)
        {
			
			if (id == 1 )
            {
				return _product1;
            }
			if (id = 2)
            {
				return _product2;
            }
			if (id = 3)
            {
				return _product3;
			}
        }

		public decimal GetTotal()
        {
			decimal total = 0;
			if (_product1 != null)
            {
				total += _product1.GetTotal();
            }
			if (_product2 != null)
            {
				total += _product2.GetTotal();
            }
			if( _product3 != null)
            {
				total *= _product3.GetTotal();
            }
			return total;
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