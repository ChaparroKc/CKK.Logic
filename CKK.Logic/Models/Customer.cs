using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Customer
    {
        private int Id;
        private string Name;
        private string Address;

        
        
       
        public int GetId()
        {
            return Id;
        }

        public int SetId(int _id)
        {
            _id = Id;
        }

        public string GetName()
        {
            return Name;
        }
        
        public string SetName(string _name)
        {
            _name = Name;
        }

        public string GetAddress()
        {
            return Address;
        }

        public string SetAddress(string _address)
        {
            _address = Address;
        }
    }
}
