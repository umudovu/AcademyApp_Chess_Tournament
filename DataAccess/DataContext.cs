using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DataContext
    {
        public static List<Player> Players { get; set; }
        public static List<Tournament> Tournaments { get; set; }

        static DataContext()
        {
            Players=new List<Player>();
            Tournaments=new List<Tournament>();
        }
    }
}
