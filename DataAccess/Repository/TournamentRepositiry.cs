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
            throw new NotImplementedException();
        }

        public bool Delete(Tournament entity)
        {
            throw new NotImplementedException();
        }

        public List<Tournament> GetAll(Predicate<Tournament> filter = null)
        {
            throw new NotImplementedException();
        }

        public Tournament GetOne(Predicate<Tournament> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(Tournament entity)
        {
            throw new NotImplementedException();
        }
    }
}
