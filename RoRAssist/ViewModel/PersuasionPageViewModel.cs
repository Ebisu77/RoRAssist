using RoRAssist.WinApp.Model;

namespace RoRAssist.WinApp.ViewModel
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
		private string resultBaseNumber;
		private string resultDiceRoll;

		public int Oratory
		{
			get { return oratory; }
			set
			{
				oratory = value;
				UpdateViewModel(nameof(Oratory));
			}
		}

		public int Influence
		{
			get { return influence; }
			set
			{
				influence = value;
				UpdateViewModel(nameof(Influence));
			}
		}

		public int Bribe
		{
			get { return bribe; }
			set
			{
				bribe = value;
				UpdateViewModel(nameof(Bribe));
			}
		}

		public int Loyalty
		{
			get { return loyalty; }
			set
			{
				loyalty = value;
				UpdateViewModel(nameof(Loyalty));
			}
		}

		public int PersonalTreasury
		{
			get { return personalTreasury; }
			set
			{
				personalTreasury = value;
				UpdateViewModel(nameof(PersonalTreasury));
			}
		}

		public int CounterBribe
		{
			get { return counterBribe; }
			set
			{
				counterBribe = value;
				UpdateViewModel(nameof(CounterBribe));
			}
		}

		public bool SenatorInFactionSelected
		{
			get { return senatorInFactionSelected; }
			set
			{
				senatorInFactionSelected = value;
				UpdateViewModel(nameof(SenatorInFactionSelected));
			}
		}

		public bool EraEndSelected
		{
			get { return eraEndSelected; }
			set
			{
				eraEndSelected = value;
				UpdateViewModel(nameof(EraEndSelected));
			}
		}

		public string ResultBaseNumber
		{
			get { return resultBaseNumber; }
			set
			{
				resultBaseNumber = value;
				NotifyPropertyChanged(nameof(ResultBaseNumber));
			}
		}

		public string ResultDiceRoll
		{
			get { return resultDiceRoll; }
			set
			{
				resultDiceRoll = value;
				NotifyPropertyChanged(nameof(ResultDiceRoll));
			}
		}

		public PersuasionPageViewModel()
		{
			model = new PersuasionModel();
			Oratory = model.Oratory;
			Influence = model.Influence;
			Bribe = model.Bribe;
			Loyalty = model.Loyalty;
			PersonalTreasury = model.PersonalTreasury;
			CounterBribe = model.CounterBribe;
			SenatorInFactionSelected = model.SenatorInFaction;
			EraEndSelected = model.EraEnd;
			ResultBaseNumber = GetFormatedBaseNumber(model.BaseNumber);
			ResultDiceRoll = GetFormatedDiceRoll(model.DiceRoll);
		}

		private void UpdateViewModel(string propertyName)
		{
			NotifyPropertyChanged(propertyName);
			model.SaveData(this);
			ResultBaseNumber = GetFormatedBaseNumber(model.BaseNumber);
			ResultDiceRoll = GetFormatedDiceRoll(model.DiceRoll);
		}

		private string GetFormatedDiceRoll(int diceRoll)
		{
			if (diceRoll >= 3)
				return "You have to roll " + diceRoll + " or less on two dice";
			else if (diceRoll == 2)
				return "You have to roll " + diceRoll + " on two dice";
			else
				return "Dice roll is not possible";
		}

		private string GetFormatedBaseNumber(int baseNumber)
		{
			return "Base number is " + baseNumber;
		}
	}
}
