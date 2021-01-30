using CommunicationsCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationsCompany.Domain.Repositories
{
    public interface ICommNodeRepository
    {
        public Task Save(CommNode entity);
        public Task<CommNode> Load(long id);
    }
}
