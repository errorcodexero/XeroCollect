using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
namespace XeroCollect.Models
{
    class Team
    {
        [PrimaryKey, AutoIncrement]
        public int teamId { get; set; }

        [Unique, MaxLength(25)]
        public string TeamNumber { get; set; }

        [MaxLength(45)]
        public string TBATeamKey { get; set; }

        [MaxLength(255)]
        public string LongName { get; set; }

        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(2000)]
        public string LogoFileLocation { get; set; }

        [MaxLength(255)]
        public string City { get; set; }

        [MaxLength(45)]
        public string StateCode { get; set; }

        [MaxLength(255)]
        public string Country { get; set; }

        [MaxLength(2000)]
        public string Motto { get; set; }

        public int RookieYear { get; set; }

        [MaxLength(255)]
        public string RobotName { get; set; }

        [MaxLength(2000)]
        public string RobotPictureLocation { get; set; }

        [MaxLength(45)]
        public string RobotDriveBase { get; set; }

        public int RobotWheelCout { get; set; }
        public int RobotDriveMotorCount { get; set; }

        [MaxLength(45)]
        public string RobotSoftwareLanguage { get; set; }

        [MaxLength(2000)]
        public string RobotDescription { get; set; }

        [MaxLength(2000)]
        public string PitScoutComments { get; set; }

        public int CanScoureGroundFuel { get; set; }
        public int CanCollectFeederFuel { get; set; }
        public int CanCollectHopperFuel { get; set; }

        public int CanActivateHoppers { get; set; }

        public int CanScoreLowFuel { get; set; }
        public int CanScoreHighFuel { get; set; }

        public int CanCollectFeederGears { get; set; }
        public int CanCollectGroundGears { get; set; }

        public int CanScoreGears { get; set; }
        public int CanDropGear { get; set; }

        public int CanClimb { get; set; }
        public int CanActivateTouchpad { get; set; }
        public int UsesOwnRope { get; set; }

        public int Defensive { get; set; }

        public int MaxFuelCapacity { get; set; }

        public float FuelContainerVolume { get; set; }

        [MaxLength(2000)]
        public string Cycle { get; set; }



    }
}
