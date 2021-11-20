using CommunicationsCompany.Domain.Entities;
using CommunicationsCompany.Domain.Repositories;
using Microsoft.Extensions.Logging;
using NHibernate;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CommunicationsCompany.Persistance.Repositories
{
    public class ServicesRepository : IServicesRepository
    {
        private readonly ISession _session;
        private readonly ILogger<ServicesRepository> _logger;

        public ServicesRepository(ISession session, ILogger<ServicesRepository> logger)
        {
            _session = session;
            _logger = logger;
        }

        public async Task Add(Services entity)
        {
            using (var transaction = _session.BeginTransaction())
            {
                try
                {
                    await _session.SaveAsync(entity);
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    _logger.LogError("Error adding CommNode, error: {0}", e.Message);
                    transaction.Rollback();
                }
                finally
                {
                    if (transaction != null)
                        transaction.Dispose(); //just in case
                }
            }
        }

        public async Task<Services> Find(long id)
        {
            using (var transaction = _session.BeginTransaction())
            {
                Services device = await _session.GetAsync<Services>(id);
                return device;
            }
        }

        public async Task Remove(Services entity)
        {
            using (var transaction = _session.BeginTransaction())
            {
                try
                {
                    await _session.DeleteAsync(entity);
                    transaction.Commit();
                }
                catch (Exception e)
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
    }
}
