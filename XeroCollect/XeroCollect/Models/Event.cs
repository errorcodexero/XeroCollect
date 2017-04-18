using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;

namespace XeroCollect.Models
{
    public class Event
    {
        [PrimaryKey, AutoIncrement]
        public int EventId { get; set; }

        [MaxLength(45)]
        public string TBAEventKey { get; set; }

        [MaxLength(255)]
        public string EventName { get; set; }
        [MaxLength(255)]
        public string EventShortName { get; set; }

        [MaxLength(255)]
        public string EventType { get; set; }
        [MaxLength(255)]
        public string EventDistrict { get; set; }

        public int EventYear { get; set; }
        public int EventWeek { get; set; }

        [MaxLength(255)]
        public string EventLocation { get; set; }

        [MaxLength(45)]
        public string TBAEventCode { get; set; }
    }
}
