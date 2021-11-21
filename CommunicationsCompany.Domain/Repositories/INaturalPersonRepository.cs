using CommunicationsCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationsCompany.Domain.Repositories
{
    public interface INaturalPersonRepository
    {
        public Task Add(NaturalPerson entity);

        public Task<NaturalPerson> Find(long id);

        public Task Remove(long id);
    }
}
