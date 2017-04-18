using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace XeroCollect.Models
{
    class TeamMatchAction
    {
        [PrimaryKey, AutoIncrement]
        public int TeamMatchActionId { get; set; }

        public int TabletId { get; set; }

        public int TeamMatchId { get; set; }

        public int ActionTypeId { get; set; }

        public int Quantity { get; set; }

        public DateTime ActionStartTime { get; set; }
        public DateTime ActionEndTime { get; set; }

        public int ActionObjectCount { get; set; }

    }
}
