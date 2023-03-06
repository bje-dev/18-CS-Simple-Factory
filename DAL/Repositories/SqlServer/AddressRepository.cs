using DAL.Contracts;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories.SqlServer
{
    //Para el patron Factory ponemos la clase de los repositorios como INTERNAL.
    //Poniendo internal solo es accesible desde el dominio de la DAL.
    internal class AddressRepository : IGenericRepository<Address>
    {
        public void Add(Address obj)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Address> GetAll()
        {
            throw new NotImplementedException();
        }

        public Address GetOne(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Update(Address obj)
        {
            throw new NotImplementedException();
        }
    }
}
