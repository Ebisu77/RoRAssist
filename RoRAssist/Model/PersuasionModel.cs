using RoRAssist.Core.DA;
using RoRAssistWinApp.ViewModel;

namespace RoRAssistWinApp.Model
{
	internal class PersuasionModel : BaseModel
	{
		public int Oratory { get; set; }

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

			new PersuasionRepository().Save(persuasion);
		}

		public override void UpdateModel()
		{
			var repository = new PersuasionRepository();
			var data = repository.GetPersuasion();

			this.Oratory = data.Oratory;
		}
	}
}