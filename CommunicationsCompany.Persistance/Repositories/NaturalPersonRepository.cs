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
    public class NaturalPersonRepository : INaturalPersonRepository
    {
        private readonly ISession _session;
        private readonly ILogger<NaturalPersonRepository> _logger;

        public NaturalPersonRepository(ISession session, ILogger<NaturalPersonRepository> logger)
        {
            _session = session;
            _logger = logger;
        }

        public async Task Add(NaturalPerson entity)
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

        public async Task<NaturalPerson> Find(long id)
        {
            using (var transaction = _session.BeginTransaction())
            {
                NaturalPerson entity = await _session.GetAsync<NaturalPerson>(id);
                return entity;
            }
        }

        public async Task Remove(long id)
        {
            using (var transaction = _session.BeginTransaction())
            {
                try
                {
                    NaturalPerson entity = await _session.GetAsync<NaturalPerson>(id);
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
