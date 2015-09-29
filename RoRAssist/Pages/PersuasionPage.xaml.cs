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

    //general TODO and ideas: 
    //-examine bool flags and how they behave, mostly after first load of page
    //-play with senator alignement checkbox(one click method instead of two check/uncheck methods?), also some getter for current status of checkbox would be nice....
    //-implement INotifyPropretyChanged (or something simmilar) instead of "calculate" button
    //-create one simple textbox of results with line wraping instead of several separate labes for each line (what the hell was I thinking?)



    /// <summary>
    /// Interaction logic for PersuasionPage.xaml
    /// </summary>
    public partial class PersuasionPage : Page
    {
        #region Fields

        //display variables
        string displayResultBaseNumber = "test1";
        string displayResultDiceRoll = "testA";

        //input variables from UI
        bool senatorInFactionFlag;

        
        #endregion

        /// <summary>
        /// PersuasionPage constructor
        /// </summary>
        public PersuasionPage()
        {
            InitializeComponent();
            //DataContext = this;
            displayResults(displayResultBaseNumber,displayResultDiceRoll);             
        }

        #region private methods
        //TODO: (VM) Create method for displaying results in lower half of the screen (data binding...)

        private void displayResults(string baseNumber, string diceRoll)
        {
            labelBaseNumber.DataContext = baseNumber;
            labelDiceRoll.DataContext = diceRoll;
        }
        
        #endregion


        #region Controllers
        //TODO: Implement behaviour for changed values in one of boxes 
        //(event handlers? ... alternative: simple button called "calculate")            

        /// <summary>
        /// Resolves behaviour of calculate button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void calculateButton_Click(object sender, RoutedEventArgs e)
        {
            //Get base number of persuation attemp
            int resultBaseNumber = Service.Calculations.CalculatePersuasionBaseNumber((int)setOratory.Value,
                (int)setInfluence.Value,
                (int)setBribe.Value,
                (int)setLoyalty.Value,
                (int)setPersonalTreasury.Value,
                (int)setCounterBribe.Value,
                senatorInFactionFlag);

            //TODO: implement final diceroll calculation

            //display aquired results
            displayResults(resultBaseNumber.ToString(), senatorInFactionFlag.ToString());
        }        

        /// <summary>
        /// Handling behaviour of senator alignement checkbox
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
    }
}
