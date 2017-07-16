using RoRAssist.WinApp.ViewModel;
using System.Windows;
using System.Windows.Controls;

namespace RoRAssist.WinApp.Pages
{
	public partial class PersuasionPage : Page
	{
		public PersuasionPage()
		{
			InitializeComponent();
			DataContext = new PersuasionPageViewModel();
		}

		//***********************************************************

		////input variables from UI
		//private bool senatorInFactionFlag, eraEndCardDrawnFlag;

		//private int oratoryValue, influenceValue, bribeValue, counterBribeValue,
		//	loyaltyValue, personalTreasuryValue;

		////output variables for display
		//private int resultBaseNumber, resultDiceRoll;

		//public PersuasionPage()
		//{
		//	InitializeComponent();
		//	calculateResults();
		//	displayResults();
		//}

		//private void calculateResults()
		//{
		//	//get base number of persuation attemp
		//	resultBaseNumber = Service.Calculations.CalculatePersuasionBaseNumber(
		//		oratoryValue, influenceValue, bribeValue, loyaltyValue,
		//		personalTreasuryValue, counterBribeValue, senatorInFactionFlag);

		//	//get final diceroll value
		//	resultDiceRoll = Service.Calculations.CalculatePersuasionDiceRoll(
		//		resultBaseNumber, eraEndCardDrawnFlag);
		//}

		//private void displayResults()
		//{
		//	//display results for base number in view
		//	if (textBlockResultBaseNumber != null)
		//	{
		//		textBlockResultBaseNumber.DataContext = "Base number is " + resultBaseNumber;
		//	}

		//	//display results for dice roll in view
		//	if (textBlockResultDiceRoll != null)
		//	{
		//		if (resultDiceRoll >= 3)
		//		{
		//			textBlockResultDiceRoll.DataContext = "You have to roll "
		//				+ resultDiceRoll + " or less on two dice";
		//		}
		//		else if (resultDiceRoll == 2)
		//		{
		//			textBlockResultDiceRoll.DataContext = "You have to roll "
		//				+ resultDiceRoll + " on two dice";
		//		}
		//		else
		//		{
		//			textBlockResultDiceRoll.DataContext = "Dice roll is not possible";
		//		}
		//	}
		//}

		private void OnCheckboxChanged(object sender, RoutedEventArgs e)
		{
			//senatorInFactionFlag = (senatorAlignementCheckbox.IsChecked.Value) ?
			//	true : false;
			//eraEndCardDrawnFlag = (eraEndCheckbox.IsChecked.Value) ?
			//	true : false;

			////reflect changes in UI
			//calculateResults();
			//displayResults();
		}

		private void OnValueChanged(object sender, RoutedEventArgs e)
		{
			////reflect changes in UI
			//if (setOratory != null)
			//	oratoryValue = (int)setOratory.Value;
			//if (setInfluence != null)
			//	influenceValue = (int)setInfluence.Value;
			//if (setBribe != null)
			//	bribeValue = (int)setBribe.Value;
			//if (setLoyalty != null)
			//	loyaltyValue = (int)setLoyalty.Value;
			//if (setPersonalTreasury != null)
			//	personalTreasuryValue = (int)setPersonalTreasury.Value;
			//if (setCounterBribe != null)
			//	counterBribeValue = (int)setCounterBribe.Value;

			//// reflect changes in UI
			//calculateResults();
			//displayResults();
		}
	
	}
}