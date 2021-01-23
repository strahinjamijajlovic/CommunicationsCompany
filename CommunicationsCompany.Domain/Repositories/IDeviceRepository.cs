using CommunicationsCompany.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationsCompany.Domain.Repositories
{
    public interface IDeviceRepository
    {
        public Task Save(Device entity);
        public Task<Device> Load(long id);        
    }
}
