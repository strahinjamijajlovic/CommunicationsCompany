using CommunicationsCompany.Domain.Entities;
using CommunicationsCompany.Domain.Repositories;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace CommunicationsCompany.Persistance.Repositories
{
    public class DeviceRepository : IDeviceRepository
    {
        private readonly ISession _session;
        private readonly ILogger<DeviceRepository> _logger;

        public DeviceRepository(ISession session, ILogger<DeviceRepository> logger)
        {
            _session = session;
            _logger = logger;
        }

        public async Task Save(Device device)
        {
            using (var transaction = _session.BeginTransaction())
            {
                try
                {
                    await _session.SaveAsync(device);
                    transaction.Commit();
                }
                catch(Exception e)
                {
                    _logger.LogError("Error adding Device, error: {0}", e.Message);
                    transaction.Rollback();
                }
                finally
                {
                    if (transaction != null)
                        transaction.Dispose(); //just in case
                }
            }
        }

        public async Task<Device> Load(long id)
        {
            using (var transaction = _session.BeginTransaction())
            {
                Device device = await _session.GetAsync<Device>(id);
                transaction.Commit();
                return device;
            }
        }
    }
}
