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
        public async Task<LegalEntity> Load(long id)
        {
            using var transaction = _session.BeginTransaction();
            LegalEntity legalEntity = await _session.GetAsync<LegalEntity>(id);
            transaction.Commit();
            return legalEntity;
        }

        public async Task Save(LegalEntity legalEntity)
        {
            using var transaction = _session.BeginTransaction();
            try
            {
                await _session.SaveAsync(legalEntity);
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
                    transaction.Dispose();
            }
        }
    }
}
