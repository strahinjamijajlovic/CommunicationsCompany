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
    public class LegalEntityRepository : ILegalEntityRepository
    {
        private readonly ISession _session;
        private readonly ILogger<LegalEntityRepository> _logger;

        public LegalEntityRepository(ISession session, ILogger<LegalEntityRepository> logger)
        {
            _session = session;
            _logger = logger;
        }

        public async Task Add(LegalEntity entity)
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

        public async Task<LegalEntity> Find(long id)
        {
            using (var transaction = _session.BeginTransaction())
            {
                LegalEntity device = await _session.GetAsync<LegalEntity>(id);
                return device;
            }
        }

        public async Task Remove(LegalEntity entity)
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
