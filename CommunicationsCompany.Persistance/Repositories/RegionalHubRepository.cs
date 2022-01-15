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

        public RegionalHubRepository(ISession session)
        {
            _session = session;
        }

        public async Task Add(RegionalHub entity)
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
                    transaction.Rollback();
                }
                finally
                {
                    if (transaction != null)
                        transaction.Dispose(); //just in case
                }
            }
        }

        public async Task<RegionalHub> Find(long id)
        {
            using (var transaction = _session.BeginTransaction())
            {
                RegionalHub entity = await _session.GetAsync<RegionalHub>(id);
                return entity;
            }
        }

        public async Task Update(RegionalHub entity)
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
                    RegionalHub entity = await _session.GetAsync<RegionalHub>(id);
                    await _session.DeleteAsync(entity);
                    transaction.Commit();
                }
                catch (Exception e)
                {
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
