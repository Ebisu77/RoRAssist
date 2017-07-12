using System;
using RoRAssistWinApp.Model;

namespace RoRAssistWinApp.ViewModel
{
	internal class PersuasionPageViewModel : BaseViewModel
	{
		private PersuasionModel model;
		private int oratory;
		private int influence;
		private int bribe;
		private int loyalty;
		private int personalTreasury;
		private int counterBribe;
		private bool senatorInFactionSelected;
		private bool eraEndSelected;

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

		public int Bribe
		{
			get { return bribe; }
			set
			{
				bribe = value;
				NotifyPropertyChanged(nameof(Bribe));
				model.SaveData(this);
			}
		}

		public int Loyalty
		{
			get { return loyalty; }
			set
			{
				loyalty = value;
				NotifyPropertyChanged(nameof(loyalty));
				model.SaveData(this);
			}
		}

		public int PersonalTreasury
		{
			get { return personalTreasury; }
			set
			{
				personalTreasury = value;
				NotifyPropertyChanged(nameof(personalTreasury));
				model.SaveData(this);
			}
		}

		public int CounterBribe
		{
			get { return counterBribe; }
			set
			{
				counterBribe = value;
				NotifyPropertyChanged(nameof(counterBribe));
				model.SaveData(this);
			}
		}

		public bool SenatorInFactionSelected
		{
			get { return senatorInFactionSelected; }
			set
			{
				senatorInFactionSelected = value;
				NotifyPropertyChanged(nameof(counterBribe));
				model.SaveData(this);
			}
		}

		public bool EraEndSelected
		{
			get { return eraEndSelected; }
			set
			{
				eraEndSelected = value;
				NotifyPropertyChanged(nameof(counterBribe));
				model.SaveData(this);
			}
		}

		public PersuasionPageViewModel()
		{
			model = new PersuasionModel();
			LoadData();
		}

		private void LoadData()
		{
			model.UpdateModel();
			this.Oratory = model.Oratory;
		}
	}
}