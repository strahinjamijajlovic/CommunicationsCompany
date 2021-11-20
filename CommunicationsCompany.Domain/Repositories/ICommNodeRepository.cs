using CommunicationsCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationsCompany.Domain.Repositories
{
    public interface ICommNodeRepository
    {
        public Task Add(CommNode entity);

        public Task<CommNode> Find(long id);


        public Task Remove(CommNode entity);
    }
}
