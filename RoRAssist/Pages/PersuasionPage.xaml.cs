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
    //-play with senator alignement checkbox(one click method instead of two check/uncheck methods?), also some getter for current status of checkbox would be nice....        
    //- for now things work, but it will be correct to play with events, so calculate button won´t be needed
    //- play with visibility of UI elemnts (e.g. bold fontweight)


    /// <summary>
    /// Interaction logic for PersuasionPage.xaml
    /// </summary>
    public partial class PersuasionPage : Page
    {
        #region Fields

        //input variables from UI
        bool senatorInFactionFlag;
        bool eraEndCardDrawn;

        #endregion

        #region Constructors        
        /// <summary>
        /// PersuasionPage constructor
        /// </summary>
        public PersuasionPage()
        {
            InitializeComponent();            
            calculateResults();      
        }
        #endregion

        #region private methods
        
        /// <summary>
        /// Calculate Results
        /// </summary>
        private void calculateResults()
        {
            //get base number of persuation attemp
            int resultBaseNumber = Service.Calculations.CalculatePersuasionBaseNumber((int)setOratory.Value,
                (int)setInfluence.Value,
                (int)setBribe.Value,
                (int)setLoyalty.Value,
                (int)setPersonalTreasury.Value,
                (int)setCounterBribe.Value,
                senatorInFactionFlag);

            //get final diceroll value
            int resultDiceRoll = Service.Calculations.CalculatePersuasionDiceRoll(resultBaseNumber, eraEndCardDrawn);

            //display aquired results
            displayResults(resultBaseNumber.ToString(), resultDiceRoll.ToString());
        }

        /// <summary>
        /// Display results in XML window
        /// </summary>
        /// <param name="baseNumber">Base Number</param>
        /// <param name="diceRoll">Final dice roll</param>
        private void displayResults(string baseNumber, string diceRoll)
        {
           // labelBaseNumber.DataContext = baseNumber;
            //labelDiceRoll.DataContext = diceRoll;

            textBlockResultBaseNumber.DataContext = "Base number is " + baseNumber;
            textBlockResultDiceRoll.DataContext = "You have to roll " + diceRoll +" or less on two dice";

            //textblockResult.DataContext = "pokus" + 7 + " aa <LineBreak /> bb" + 45 +"CCC";
        }
        
        #endregion


        #region Controllers                

        /// <summary>
        /// Resolves behaviour of calculate button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            calculateResults();
        }        

        /// <summary>
        /// Handle behaviour of senator alignement checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void senatorAlignement_Checked(object sender, RoutedEventArgs e)
        {
            senatorInFactionFlag = true;            
        }

        private void senatorAlignement_Unchecked(object sender, RoutedEventArgs e)
        {
            senatorInFactionFlag = false;
        }
        #endregion

        /// <summary>
        /// Handle behaviour of eraEnd checkbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void eraEnd_Checked(object sender, RoutedEventArgs e)
        {
            eraEndCardDrawn = true;
        }

        private void eraEnd_Unchecked(object sender, RoutedEventArgs e)
        {
            eraEndCardDrawn = false;
        }
        
    }
}
