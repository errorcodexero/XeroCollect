using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace XeroCollect.Models
{
    class Match
    {
        [PrimaryKey, AutoIncrement]
        public int MatchId { get; set; }
        public int EventId { get; set; }

        [MaxLength(45)]
        public string TBAMatchKey { get; set; }

        [MaxLength(45)]
        public string NatchSetNumber { get; set; }

        [MaxLength(45)]
        public string NatchNumber { get; set; }

        [MaxLength(45)]
        public string MatchStatus { get; set; }

        // Red Alliance Data

        public int RedOneId { get; set; }
        public int RedTwoId { get; set; }
        public int RedThreeId { get; set; }
                   
        public int RedAutoScore { get; set; }
        public int RedTeleopScore { get; set; }
        public int RedTotalScore { get; set; }
        public int RedFoulPoints { get; set; }

        public int RedQp { get; set; }

        // Blue Alliance Data

        public int BlueOneId { get; set; }
        public int BlueTwoId { get; set; }
        public int BlueThreeId { get; set; }
                   
        public int BlueAutoScore { get; set; }
        public int BlueTeleopScore { get; set; }
        public int BlueTotalScore { get; set; }
        public int BlueFoulPoints { get; set; }
                   
        public int BlueQp { get; set; }

        [MaxLength(45)]
        public string MatchWinner { get; set; }

        [MaxLength(2000)]
        public string DriveTeamComments { get; set; }


    }
}
