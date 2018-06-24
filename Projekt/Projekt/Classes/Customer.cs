﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt.Classes
{
    public class Customer
    {
        string customerCompanyName;
        string customerName;
        string customerSurname;

        public Customer(string customerCompanyName, string customerName, string customerSurname)
        {
            this.customerCompanyName = customerCompanyName;
            this.customerName = customerName;
            this.customerSurname = customerSurname;

        }

        public string CustomerCompanyName
        {
            get
            {
                return customerCompanyName;
            }

            set
            {
                customerCompanyName = value;
            }
        }

        public string CustomerName
        {
            get
            {
                return customerName;
            }

            set
            {
                customerName = value;
            }
        }

        public string CustomerSurname
        {
            get
            {
                return customerSurname;
            }

            set
            {
                customerSurname = value;
            }
        }


    }
}
