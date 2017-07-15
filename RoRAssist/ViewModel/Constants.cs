﻿using System.IO;

namespace RoRAssistWinApp.Service
{
	public static class Constants
	{
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