using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace XeroCollect.Models
{
    class TeamMatch
    {

        [PrimaryKey, AutoIncrement]
        public int TeamMatchId { get; set; }

        public int TeamId { get; set; }

        public int MatchId { get; set; }

        [MaxLength(45)]
        public string Alliance { get; set; }

        public int Position { get; set; }

        [MaxLength(45)]
        public string ScoutName { get; set; }
    }
}
