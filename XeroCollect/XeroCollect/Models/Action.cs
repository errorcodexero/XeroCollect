using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace XeroCollect.Models
{
    class Action
    {
        [PrimaryKey, AutoIncrement]
        public int ActionId { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(2000)]
        public string Description { get; set; }

        [MaxLength(45)]
        public string MatchPhase { get; set; }

        public int Points { get; set; }
        public int OpponentPoints { get; set; }
        public int QualPoints { get; set; }
        public int FoulPoints { get; set; }

        [MaxLength(1)]
        public string CoopFlag { get; set; }

        [MaxLength(255)]
        public string Catagory { get; set; }



    }
}
