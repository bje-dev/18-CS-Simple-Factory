using DAL.Contracts;
using DAL.Repositories;
using DAL.Repositories.File;
using DAL.Repositories.SqlServer;
using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Factory
{
   

        public sealed class Factory
        {
            private readonly static Factory _instance = new Factory();

        private readonly string backend; 

            public static Factory Current
            {
                get
                {
                    return _instance;
                }
            }

            private Factory()
            {
            backend = ConfigurationManager.AppSettings["backend"];
            }

        //PARA DESACOPLAR LO MAS POSIBLE ESTE METODO ESTARA LIGADO A LO SETEADO EN APPCONFIG
        //SI SE SETEA SQL SE GUARDARAN LOS DATOS EN SQL SINO EN UN ARCHIVO FILE
     
        public IGenericRepository<Address> GetAddressRepository()
        {
            string backend = ConfigurationManager.AppSettings["backend"];

            if(backend == "SQL")
            {
                return new Repositories.SqlServer.AddressRepository();
                
            }else
            {
                return new DAL.Repositories.File.AddressRepository();
            }


        }

        public IGenericRepository<Customer> GetCustomerRepository()
        {
            return new CustomerRepository();
        }




    }





}
