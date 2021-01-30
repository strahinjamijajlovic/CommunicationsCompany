using CommunicationsCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationsCompany.Domain.Repositories
{
    public interface INaturalPersonRepository
    {
        public Task Save(NaturalPerson entity);
        public Task<NaturalPerson> Load(long id);
    }
}
