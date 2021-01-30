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
    public class RegionalHubRepository : IRegionalHubRepository
    {
        private readonly ISession _session;
        private readonly ILogger<RegionalHubRepository> _logger;

        public RegionalHubRepository(ISession session, ILogger<RegionalHubRepository> logger)
        {
            _session = session;
            _logger = logger;
        }
        public async Task<RegionalHub> Load(long id)
        {
            using var transaction = _session.BeginTransaction();
            RegionalHub regionalHub = await _session.GetAsync<RegionalHub>(id);
            transaction.Commit();
            return regionalHub;
        }

        public async Task Save(RegionalHub regionalHub)
        {
            using var transaction = _session.BeginTransaction();
            try
            {
                await _session.SaveAsync(regionalHub);
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
