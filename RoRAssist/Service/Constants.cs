using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoRAssist.Service
{
    /// <summary>
    /// Provides all contstants 
    /// </summary>
    public static class Constants
    {
        // support for persuade calculations
        public const int DEFENDING_SENATOR_IN_FACTION = 7;
        public const int DEFENDING_SENATOR_NEUTRAL = 0;
        public const int ERA_END_NOT_ACTIVE = 9;
        public const int ERA_END_ACTIVE = 8;

        // support for treasury calculations
        public const int TREASURY_COST_WAR = 20;
        public const int TREASURY_COST_FLEET = 2;
        public const int TREASURY_COST_LEGION = 2;
        public const int LAND_BILL_1 = 20;
        public const int LAND_BILL_2 = 5;
        public const int LAND_BILL_3 = 10;

        // path to data folder
        public static string pathToPlayersData = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\..\RoRassist\Data\Players.xml");
    }
}
