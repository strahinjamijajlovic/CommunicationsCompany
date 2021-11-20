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
    public class CommNodeRepository : ICommNodeRepository
    {
        private readonly ISession _session;
        private readonly ILogger<CommNodeRepository> _logger;

        public CommNodeRepository(ISession session, ILogger<CommNodeRepository> logger)
        {
            _session = session;
            _logger = logger;
        }

        public async Task Add(CommNode entity)
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

        public async Task<CommNode> Find(long id)
        {
            using (var transaction = _session.BeginTransaction())
            {
                CommNode device = await _session.GetAsync<CommNode>(id);
                return device;
            }
        }

        public async Task Remove(CommNode entity)
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
