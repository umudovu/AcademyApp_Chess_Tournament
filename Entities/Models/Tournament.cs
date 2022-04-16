using Entities.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
    public class Tournament : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Degree { get; set; }
    }
}
