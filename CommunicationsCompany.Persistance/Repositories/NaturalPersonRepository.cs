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
        public async Task<NaturalPerson> Load(long id)
        {
            using var transaction = _session.BeginTransaction();
            NaturalPerson naturalPerson = await _session.GetAsync<NaturalPerson>(id);
            transaction.Commit();
            return naturalPerson;
        }

        public async Task Save(NaturalPerson naturalPerson)
        {
            using var transaction = _session.BeginTransaction();
            try
            {
                await _session.SaveAsync(naturalPerson);
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
