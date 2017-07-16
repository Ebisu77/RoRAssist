namespace RoRAssist.WinApp.Service
{
	public static class Calculations
	{
		public static int CalculateTreasuryBasicIncome(int beginningTreasury,
			int annualRevenue, int contributions)
		{
			int result = beginningTreasury + annualRevenue + contributions;
			return result;
		}

		public static int CalculateTreasuryProvinces(int africa, int asia, int bithynia,
			int cilicia, int crete, int gaulCisalpine, int gaulNarbonese, int gaulTransalpine,
			int grece, int illyricum, int sardinia, int sicily, int spainFurther,
			int spainNearer, int syria)
		{
			return africa + asia + bithynia + cilicia + crete + gaulCisalpine +
				gaulNarbonese + gaulTransalpine + grece + illyricum + sardinia +
				sicily + spainFurther + spainNearer + syria;
		}

		public static int CalculateTreasuryBasicExpenses(int wars, int legions, int fleets)
		{
			return (wars * Service.Constants.TREASURY_COST_WAR) +
				(legions * Service.Constants.TREASURY_COST_LEGION) +
				(fleets * Service.Constants.TREASURY_COST_FLEET);
		}

		public static int ClaculateTreasuryLandBills(bool landbill_1a, bool landbill_2a,
			bool landbill_2b, bool landbill_3a, bool landbill_3b, bool landbill_3c)
		{
			//determines if land bill is active and sets respective value
			int bill1 = (landbill_1a) ?
				Service.Constants.LAND_BILL_1 : 0;
			int bill2a = (landbill_2a) ?
				Service.Constants.LAND_BILL_2 : 0;
			int bill2b = (landbill_2b) ?
				Service.Constants.LAND_BILL_2 : 0;
			int bill3a = (landbill_3a) ?
				Service.Constants.LAND_BILL_3 : 0;
			int bill3b = (landbill_3b) ?
				Service.Constants.LAND_BILL_3 : 0;
			int bill3c = (landbill_3c) ?
				Service.Constants.LAND_BILL_3 : 0;

			//calculates resulting cost of all land bills
			return bill1 + bill2a + bill2b + bill3a + bill3b + bill3c;
		}

		public static int CalculateTreasuryTotal(int basicIncome, int provinces, int basicExpenses, int landbills)
		{
			return basicIncome + provinces - basicExpenses - landbills;
		}

		public static int CalculateTreasuryChange(int startingTreasury, int finalTreasury)
		{
			return finalTreasury - startingTreasury;
		}
	}
}