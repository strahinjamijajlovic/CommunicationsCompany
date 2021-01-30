using CommunicationsCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationsCompany.Domain.Repositories
{
    public interface IRegionalHubRepository
    {
        public Task Save(RegionalHub entity);
        public Task<RegionalHub> Load(long id);
    }
}
