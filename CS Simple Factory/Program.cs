using DAL.Contracts;
using DAL.Factory;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Simple_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            IGenericRepository<Address> addressRepository = Factory.Current.GetAddressRepository();


            IGenericRepository<Customer> customerRepository = Factory.Current.GetCustomerRepository();
        }
    }
}
