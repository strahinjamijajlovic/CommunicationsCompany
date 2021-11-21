using CommunicationsCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationsCompany.Domain.Repositories
{
    public interface IRegionalHubRepository
    {
        public Task Add(RegionalHub entity);

        public Task<RegionalHub> Find(long id);
        public Task Update(RegionalHub entity);
        public Task Remove(long id);
    }
}
