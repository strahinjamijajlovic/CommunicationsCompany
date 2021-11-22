using CommunicationsCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationsCompany.Domain.Repositories
{

    public interface ILegalEntityRepository
    {
        public Task Add(LegalEntity entity);
        public Task<LegalEntity> Find(long id);
        public Task Update(LegalEntity entity);
        public Task Remove(long id);
    }
}
