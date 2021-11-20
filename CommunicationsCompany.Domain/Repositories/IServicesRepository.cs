using CommunicationsCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationsCompany.Domain.Repositories
{
    public interface IServicesRepository
    {
        public Task Add(Services entity);

        public Task<Services> Find(long id);


        public Task Remove(Services entity);
    }
}
