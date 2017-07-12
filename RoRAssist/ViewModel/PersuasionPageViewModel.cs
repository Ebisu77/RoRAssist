using RoRAssistWinApp.Model;

namespace RoRAssistWinApp.ViewModel
{
	internal class PersuasionPageViewModel : BaseViewModel
	{
		private PersuasionModel model;
		private int oratory;

		public int Oratory
		{
			get { return oratory; }
			set
			{
				oratory = value;
				NotifyPropertyChanged("Oratory");
				model.SaveData(this);
			}
		}

		public PersuasionPageViewModel()
		{
			model = new PersuasionModel();
		}
	}
}