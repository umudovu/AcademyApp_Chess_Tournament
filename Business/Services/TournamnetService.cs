using Business.Interfaces;
using DataAccess.Repository;
using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Services
{
    public class TournamnetService : ITournament
    {
        public static int Count;
        private TournamentRepositiry _tournamentRepositiry;

        public TournamnetService()
        {
            _tournamentRepositiry=new TournamentRepositiry();
        }
        public Tournament Create(Tournament tournament)
        {
            Count++;
            tournament.Id=Count;
            _tournamentRepositiry.Create(tournament);
            return tournament;


        }

        
        public Tournament Remove(int id)
        {
            Tournament Exsist = _tournamentRepositiry.GetOne(t=>t.Id==id);
            _tournamentRepositiry.Delete(Exsist);
            return Exsist;
        }

        public Tournament Update(int id,Tournament tournament)
        {
            tournament = _tournamentRepositiry.GetOne(p => p.Id==id);
            if (tournament==null)
            {
                return null;
            }
            _tournamentRepositiry.Update(tournament);
            return tournament;
        }
        public Tournament GetTournament(int? id)
        {
            if (id==null)
            {
                return null;
            }
           return _tournamentRepositiry.GetOne(t=>t.Id==id);
        }

        public List<Tournament> GetAll()
        {
            return _tournamentRepositiry.GetAll();
        }
    }
}
