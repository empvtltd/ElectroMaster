using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElectroMaster
{
    class Customer
    {
        private String CustomerId = null;
        private String Name = null;
        private String Address = null;
        private int Phone = 0;
        private String Email = null;



        public String getCustomerId()
        {
            return CustomerId;
        }
        public void setCustomerID(String customerId)
        {
            this.CustomerId = customerId;
        }

        public String getName()
        {
            return Name;
        }
        public void setName(String name)
        {
            this.Name = name;
        }

        public String getAddress()
        {
            return Address;
        }
        public void setAddress(String address)
        {
            this.Address = address;
        }

        public int getPhone()
        {
            return Phone;
        }
        public void setPhone(int phone)
        {
            this.Phone = phone;
        }

        public String getEmail()
        {
            return Email;
        }
        public void setEmail(String email)
        {
            this.Email = email;
        }
    }
 }