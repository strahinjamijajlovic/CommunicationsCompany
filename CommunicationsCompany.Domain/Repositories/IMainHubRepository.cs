using CommunicationsCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationsCompany.Domain.Repositories
{
    public interface IMainHubRepository
    {
        public Task Add(MainHub entity);

        public Task<MainHub> Find(long id);
        public Task Update(MainHub entity);
        public Task Remove(long id);
    }
}
