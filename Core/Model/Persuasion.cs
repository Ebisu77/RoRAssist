namespace RoRAssist.Core.Model
{
	public class Persuasion
	{
		public int Oratory { get; set; }
		public int Influence { get; set; }
		public int Bribe { get; set; }
		public int Loyalty { get; set; }
		public int PersonalTreasury { get; set; }
		public int CounterBribe { get; set; }
		public bool SenatorInFaction { get; set; }
		public bool EraEnd { get; set; }
	}
}