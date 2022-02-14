using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CKK.Logic.Models
{
    public class Customer
    {
        private int _id;
        private string _name;
        private string _address;

        _id = Id;
        
       
        public int GetId()
        {
            return Id;
        }

        public int SetId(int Id)
        {
            _id = Id;
        }

        public string GetName()
        {
            return Name;
        }
        
        public string SetName(string Name)
        {
            _name = Name;
        }

        public string GetAddress()
        {
            return Address;
        }

        public string SetAddress(string Address)
        {
            _address = Address;
        }
    }
}
