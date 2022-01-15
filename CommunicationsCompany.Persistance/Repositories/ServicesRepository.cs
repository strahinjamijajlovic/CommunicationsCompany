﻿using CommunicationsCompany.Domain.Entities;
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

        public ServicesRepository(ISession session)
        {
            _session = session;
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
                Services entity = await _session.GetAsync<Services>(id);
                return entity;
            }
        }
        public async Task Update(Services entity)
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
                    Services entity = await _session.GetAsync<Services>(id);
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
