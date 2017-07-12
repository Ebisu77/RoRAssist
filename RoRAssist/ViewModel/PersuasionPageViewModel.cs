using RoRAssistWinApp.Model;

namespace RoRAssistWinApp.ViewModel
{
	internal class PersuasionPageViewModel : BaseViewModel
	{
		private PersuasionModel model;
		private int oratory;
		private int influence;

		public int Oratory
		{
			get { return oratory; }
			set
			{
				oratory = value;
				NotifyPropertyChanged(nameof(Oratory));
				model.SaveData(this);
			}
		}

		public int Influence
		{
			get { return influence; }
			set
			{
				influence = value;
				NotifyPropertyChanged(nameof(Influence));
				model.SaveData(this);
			}
		}

		public PersuasionPageViewModel()
		{
			model = new PersuasionModel();
		}
	}
}