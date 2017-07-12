using RoRAssist.Core.DA;
using RoRAssistWinApp.ViewModel;

namespace RoRAssistWinApp.Model
{
	internal class PersuasionModel : BaseModel
	{
		public override void SaveData(object sender)
		{
			var viewModel = (PersuasionPageViewModel)sender;

			var persuasion = new RoRAssist.Core.Model.Persuasion()
			{
				Oratory = viewModel.Oratory,
				Influence = viewModel.Influence
			};

			new PersuasionRepository().Save(persuasion);
		}
	}
}