using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Xceed.Wpf.Toolkit;

namespace RoRAssist.Pages
{

    //TODO: general ideas:             
    //- play with visibility of UI elemnts (e.g. bold fontweight)
    //- do "graphic" of ui, eg.: lines or labels (attacking senator, defending senator)
    //- calmp control values in UI (e.g. no negative numbers for personal treasury)

    /// <summary>
    /// Interaction logic for PersuasionPage.xaml
    /// </summary>
    public partial class PersuasionPage : Page
    {
        #region Fields

        //input variables from UI
        bool senatorInFactionFlag;
        bool eraEndCardDrawn;
        int oratoryValue;
        int influenceValue;
        int bribeValue;
        int counterBribeValue;
        int loyaltyValue;
        int personalTreasuryValue;

        //output variables for display
        int resultBaseNumber;
        int resultDiceRoll;

        #endregion

        #region Constructors       
         
        /// <summary>
        /// PersuasionPage constructor
        /// </summary>
        public PersuasionPage()
        {
            InitializeComponent();
            calculateResults();
            displayResults();
        }

        #endregion

        #region Private methods
        
        /// <summary>
        /// Calculate Results
        /// </summary>
        private void calculateResults()
        {
            //get base number of persuation attemp
            resultBaseNumber = Service.Calculations.CalculatePersuasionBaseNumber(
                oratoryValue,
                influenceValue,                
                bribeValue,
                loyaltyValue,
                personalTreasuryValue,
                counterBribeValue,
                senatorInFactionFlag);

            //get final diceroll value
            resultDiceRoll = Service.Calculations.CalculatePersuasionDiceRoll(
                resultBaseNumber, eraEndCardDrawn);            
        }

        /// <summary>
        /// Display results in XAML window
        /// </summary>
        private void displayResults()
        {
            
            //display results for base number in view
            if (textBlockResultBaseNumber != null)
            {
                textBlockResultBaseNumber.DataContext = "Base number is " + resultBaseNumber;            
            }

            //display results for dice roll in view
            if (textBlockResultDiceRoll != null)
            {
                if (resultDiceRoll >= 3)
                {
                    textBlockResultDiceRoll.DataContext = "You have to roll " 
                        + resultDiceRoll + " or less on two dice";
                }
                else if (resultDiceRoll == 2)
                {
                    textBlockResultDiceRoll.DataContext = "You have to roll " 
                        + resultDiceRoll + " on two dice";
                }
                else
                {
                    textBlockResultDiceRoll.DataContext = "Dice roll is not possible";
                }                
            }
        }

        #endregion

        #region Events    

        /// <summary>
        /// Handles behaviour of checkboxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCheckboxChanged(object sender, RoutedEventArgs e)
        {            
            senatorInFactionFlag = (senatorAlignementCheckbox.IsChecked.Value) ?
                true : false;
            eraEndCardDrawn = (eraEndCheckbox.IsChecked.Value) ?
                true : false;

            //reflect changes in UI
            calculateResults();
            displayResults();
        }

        /// <summary>
        /// Support for reflecting changes in UI IntegerUpDow boxes
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            
            //reflect changes in UI            
            if (setOratory != null)
            {
                oratoryValue= (int)setOratory.Value;
            }
            if (setInfluence != null)
            {
                influenceValue = (int)setInfluence.Value;
            }            
            if (setBribe != null)
            {
                bribeValue = (int)setBribe.Value;
            }
            if (setLoyalty != null)
            {
                loyaltyValue = (int)setLoyalty.Value;
            }
            if (setPersonalTreasury != null)
            {
                personalTreasuryValue = (int)setPersonalTreasury.Value;
            }
            if (setCounterBribe != null)
            {
                counterBribeValue = (int)setCounterBribe.Value;
            }

            // reflect changes in UI
            calculateResults();
            displayResults();
        }

        #endregion
                
    }
}
