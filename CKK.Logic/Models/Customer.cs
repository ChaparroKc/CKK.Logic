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

        public int SetId(int id)
        {
            Id = id;
        }

        public string GetName()
        {
            return Name;
        }
        
        public string SetName(string name)
        {
            Name = name;
        }

        public string GetAddress()
        {
            return Address;
        }

        public string SetAddress(string address)
        {
            Address = Address;
        }
    }
}
