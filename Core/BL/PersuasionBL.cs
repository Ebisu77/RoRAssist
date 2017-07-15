using RoRAssist.Core.DA;
using RoRAssist.Core.Model;

namespace RoRAssist.Core.BL
{
	public static class PersuasionBL
	{
		// TODO: Unit tests
		public static int CalculateBaseNumber()
		{
			var repository = new PersuasionRepository();
			return CalculateBaseNumber(repository.GetPersuasion());
		}

		public static int CalculateBaseNumber(Persuasion persuasion)
		{
			int senatorAlignementValue = (persuasion.SenatorInFaction) ? 7 : 0;

			return (persuasion.Oratory + persuasion.Influence + persuasion.Bribe) -
					(persuasion.Loyalty + persuasion.PersonalTreasury + persuasion.CounterBribe + senatorAlignementValue);
		}

		public static int CalculateDiceRoll()
		{
			var repository = new PersuasionRepository();
			return CalculateDiceRoll(repository.GetPersuasion());
		}

		public static int CalculateDiceRoll(Persuasion persuasion)
		{
			if (persuasion.EraEnd)
				return (persuasion.ResultBaseNumber <= 9) ? persuasion.ResultBaseNumber : 9;
			else
				return (persuasion.ResultBaseNumber <= 8) ? persuasion.ResultBaseNumber : 8;
		}
	}
}
