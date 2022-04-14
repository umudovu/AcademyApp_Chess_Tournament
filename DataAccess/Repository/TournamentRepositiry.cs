using DataAccess.Interfaces;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class TournamentRepositiry : IRepository<Tournament>
    {
        public bool Create(Tournament entity)
        {
            try
            {
                DataContext.Tournaments.Add(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public bool Update(Tournament entity)
        {
            try
            {
                Tournament IsExsist = GetOne(p => p.Id== entity.Id);
                IsExsist=entity;
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool Delete(Tournament entity)
        {
            try
            {
                DataContext.Tournaments.Remove(entity);
                return true;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<Tournament> GetAll(Predicate<Tournament> filter = null)
        {
            try
            {
                return filter==null ? DataContext.Tournaments :
                DataContext.Tournaments.FindAll(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }

        public Tournament GetOne(Predicate<Tournament> filter = null)
        {
            try
            {
                return filter==null ? DataContext.Tournaments[0] :
                DataContext.Tournaments.Find(filter);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
