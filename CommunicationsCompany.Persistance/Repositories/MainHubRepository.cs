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
    public class MainHubRepository : IMainHubRepository
    {
        private readonly ISession _session;
        private readonly ILogger<MainHubRepository> _logger;

        public MainHubRepository(ISession session, ILogger<MainHubRepository> logger)
        {
            _session = session;
            _logger = logger;
        }
        public async Task<MainHub> Load(long id)
        {
            using var transaction = _session.BeginTransaction();
            MainHub mainHub = await _session.GetAsync<MainHub>(id);
            transaction.Commit();
            return mainHub;
        }

        public async Task Save(MainHub mainHub)
        {
            using var transaction = _session.BeginTransaction();
            try
            {
                await _session.SaveAsync(mainHub);
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
