using RoRAssist.Core.BL;
using RoRAssist.Core.DA;
using RoRAssistWinApp.ViewModel;

namespace RoRAssistWinApp.Model
{
	internal class PersuasionModel : BaseModel
	{
		public int Bribe { get; set; }
		public int CounterBribe { get; set; }
		public bool EraEnd { get; set; }
		public int Influence { get; set; }
		public int Loyalty { get; set; }
		public int Oratory { get; set; }
		public int PersonalTreasury { get; set; }
		public int BaseNumber { get { return PersuasionBL.CalculateBaseNumber(); } }
		public int DiceRoll { get { return PersuasionBL.CalculateDiceRoll(); } }
		public bool SenatorInFaction { get; set; }

		public PersuasionModel()
		{
			var persuasion = new PersuasionRepository().GetPersuasion();
			Oratory = persuasion.Oratory;
			Influence = persuasion.Influence;
			Loyalty = persuasion.Loyalty;
			Bribe = persuasion.Bribe;
			CounterBribe = persuasion.CounterBribe;
			PersonalTreasury = persuasion.PersonalTreasury;
			EraEnd = persuasion.EraEnd;
			SenatorInFaction = persuasion.SenatorInFaction;
		}

		public override void SaveData(object sender)
		{
			var viewModel = (PersuasionPageViewModel)sender;

			var persuasion = new RoRAssist.Core.Model.Persuasion()
			{
				Oratory = viewModel.Oratory,
				Influence = viewModel.Influence,
				Bribe = viewModel.Bribe,
				Loyalty = viewModel.Loyalty,
				PersonalTreasury = viewModel.PersonalTreasury,
				CounterBribe = viewModel.CounterBribe,
				SenatorInFaction = viewModel.SenatorInFactionSelected,
				EraEnd = viewModel.EraEndSelected
			};

			persuasion.ResultBaseNumber = PersuasionBL.CalculateBaseNumber(persuasion);
			persuasion.ResultDiceRoll = PersuasionBL.CalculateDiceRoll(persuasion);

			new PersuasionRepository().Save(persuasion);
		}
	}
}
