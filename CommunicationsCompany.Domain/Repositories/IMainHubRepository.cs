using CommunicationsCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationsCompany.Domain.Repositories
{
    public interface IMainHubRepository
    {
        public Task Save(MainHub entity);
        public Task<MainHub> Load(long id);
    }
}
