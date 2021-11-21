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

        public async Task Add(MainHub entity)
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

        public async Task<MainHub> Find(long id)
        {
            using (var transaction = _session.BeginTransaction())
            {
                MainHub entity = await _session.GetAsync<MainHub>(id);
                return entity;
            }
        }

        public async Task Update(MainHub entity)
        {
            using (var transaction = _session.BeginTransaction())
            {
                await _session.UpdateAsync(entity);
                transaction.Commit();
            }

        }

        public async Task Remove(long id)
        {
            using (var transaction = _session.BeginTransaction())
            {
                try
                {
                    MainHub entity = await _session.GetAsync<MainHub>(id);
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
