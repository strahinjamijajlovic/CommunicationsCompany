using CommunicationsCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationsCompany.Domain.Repositories
{
    public interface ILegalEntityRepository
    {
        public Task Save(LegalEntity entity);
        public Task<LegalEntity> Load(long id);
    }
}
