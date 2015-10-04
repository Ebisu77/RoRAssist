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
            resultDiceRoll = Service.Calculations.CalculatePersuasionDiceRoll(resultBaseNumber, eraEndCardDrawn);
            
        }

        /// <summary>
        /// Display results in XAML window
        /// </summary>
        /// <param name="baseNumber">Base Number</param>
        /// <param name="diceRoll">Final dice roll</param>
        private void displayResults()
        {

            //TODO: Ad logic for proper display of dice roll; e.g. message "dice roll not possible" 
            //instead of negative numbers displayed
            

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
                    textBlockResultDiceRoll.DataContext = "You have to roll " + resultDiceRoll + " or less on two dice";
                }
                else if (resultDiceRoll == 2)
                {
                    textBlockResultDiceRoll.DataContext = "You have to roll " + resultDiceRoll + " on two dice";
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
        /// Handle behaviour of senator alignement checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void senatorAlignement_Checked(object sender, RoutedEventArgs e)
        {
            senatorInFactionFlag = true;
            calculateResults();
            displayResults();
        }

        private void senatorAlignement_Unchecked(object sender, RoutedEventArgs e)
        {
            senatorInFactionFlag = false;
            calculateResults();
            displayResults();
            
        }       

        /// <summary>
        /// Handle behaviour of eraEnd checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eraEnd_Checked(object sender, RoutedEventArgs e)
        {
            eraEndCardDrawn = true;
            calculateResults();
            displayResults();
        }

        private void eraEnd_Unchecked(object sender, RoutedEventArgs e)
        {
            eraEndCardDrawn = false;
            calculateResults();
            displayResults();
        }        

        /// <summary>
        /// Support for reflecting changes in UI
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

            // recalculate and display new results
            calculateResults();
            displayResults();
        }

        #endregion
    }
}
