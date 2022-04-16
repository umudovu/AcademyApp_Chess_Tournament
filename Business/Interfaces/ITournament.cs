using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface ITournament
    {
        Tournament Create(Tournament tournament);
        Tournament Remove(int id);
        Tournament Update(int id,Tournament tournament);


        Tournament GetTournament(int? id);

        List<Tournament> GetAll();
    }
}
