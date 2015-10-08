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
    //TODO: - use last year result as a new starting year treasury. 


    /// <summary>
    /// Interaction logic for StateTreasuryPage.xaml
    /// </summary>
    public partial class StateTreasuryPage : Page
    {
        #region Fields
        
        //general income
        int stateOfTreasury;
        int annualRevenue;
        int contributions;

        //general expenses
        int activeWars;
        int legions;
        int fleets;
        int stateOfTreasuryChange;

        //provinces
        int africa;
        int asia;
        int bithynia;
        int cilicia;
        int crete;
        int gaulCisalpine;
        int gaulNarbonese;
        int gaulTransalpine;
        int grece;
        int illyricum;
        int sardinia;
        int sicily;
        int spainFurther;
        int spainNearer;
        int syria;

        //landbills
        bool landbill1;
        bool landbill2a;
        bool landbill2b;
        bool landbill3a;
        bool landbill3b;
        bool landbill3c;

        #endregion

        #region Constructors

        /// <summary>
        /// Constructor for StateTreasurPage
        /// </summary>
        public StateTreasuryPage()
        {
            InitializeComponent();
            calculateResults();
            displayResults();
        }

        #endregion

        #region Private metods

        /// <summary>
        /// Calculate state treasury
        /// </summary>
        private void calculateResults()
        {
            int generalIncome = Service.Calculations.CalculateTreasuryBasicIncome(stateOfTreasury, 
                annualRevenue, contributions);
            int generalExpenses = Service.Calculations.CalculateTreasuryBasicExpenses(activeWars,
                legions, fleets);

            //TODO: calculate provinces together
            int provincesIncome = Service.Calculations.CalculateTreasuryProvinces(africa, asia, bithynia,
                cilicia, crete, gaulCisalpine, gaulNarbonese, gaulTransalpine, grece, illyricum,
                sardinia, sicily, spainFurther, spainNearer, syria);

            //TODO: Calculate land bills together
            int landbillsExpense = Service.Calculations.ClaculateTreasuryLandBills
                (landbill1, landbill2a, landbill2b, landbill3a, landbill3b, landbill3c);

            //calculates change in state treasury
            stateOfTreasuryChange = Service.Calculations.CalculateTreasuryTotal(
                generalIncome, provincesIncome, generalExpenses, landbillsExpense);

            //TODO: calculate new value of treasury after change


            displayResults();
        }

        /// <summary>
        /// Display results of calculations in UI
        /// </summary>
        private void displayResults()
        {
            //TODO: make proper displays
            if (treasuryChangeLabel != null)
            {
                treasuryChangeLabel.DataContext = stateOfTreasuryChange;;
            }       
            
            //TODO: display new status of state treasury     
        }

        #endregion

        #region Events       

        /// <summary>
        /// Reflects changes in UI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnValueChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            //changes in general income area
            if (incomeStateOfTreasuryBeginning != null)
            {
                stateOfTreasury = (int)incomeStateOfTreasuryBeginning.Value;
            }
            if (incomeAnnualRevenue != null)
            {
                annualRevenue = (int)incomeAnnualRevenue.Value;
            }
            if (incomeContributions != null)
            {
                contributions= (int)incomeContributions.Value;
            }

            //changes in general expenses area
            if (expenseActiveWars != null)
            {
                activeWars = (int)expenseActiveWars.Value;
            }
            if (expenseLegions != null)
            {
                legions = (int)expenseLegions.Value;
            }
            if (expenseFleets != null)
            {
                fleets = (int)expenseFleets.Value;
            }

            //TODO: changes in provinces
            if (incomeProvinceAfrica != null)
            {
                africa = (int)incomeProvinceAfrica.Value;
            }
            if (incomeProvinceAsia != null)
            {
                asia = (int)incomeProvinceAsia.Value;
            }
            if (incomeProvinceBithynia != null)
            {
                bithynia = (int)incomeProvinceBithynia.Value;
            }
            if (incomeProvinceCiliciaCyprus != null)
            {
                cilicia = (int)incomeProvinceCiliciaCyprus.Value;
            }
            if (incomeProvinceCreteCyrene != null)
            {
                crete = (int)incomeProvinceCreteCyrene.Value;
            }
            if (incomeProvinceGaulCisalpine != null)
            {
                gaulCisalpine = (int)incomeProvinceGaulCisalpine.Value;
            }
            if (incomeProvinceGaulNarbonese != null)
            {
                gaulNarbonese = (int)incomeProvinceGaulNarbonese.Value;
            }
            if (incomeProvinceGaulTransalpine != null)
            {
                gaulTransalpine = (int)incomeProvinceGaulTransalpine.Value;
            }
            if (incomeProvinceGreece != null)
            {
                grece = (int)incomeProvinceGreece.Value;
            }
            if (incomeProvinceIllyricum != null)
            {
                illyricum = (int)incomeProvinceIllyricum.Value;
            }
            if (incomeProvinceSardiniaCorsica != null)
            {
                sardinia = (int)incomeProvinceSardiniaCorsica.Value;
            }
            if (incomeProvinceSicily != null)
            {
                sicily = (int)incomeProvinceSicily.Value;
            }
            if (incomeProvinceSpainFurther != null)
            {
                spainFurther = (int)incomeProvinceSpainFurther.Value;
            }
            if (incomeProvinceSpainNearer != null)
            {
                spainNearer = (int)incomeProvinceSpainNearer.Value;
            }
            if (incomeProvinceSyria != null)
            {
                syria = (int)incomeProvinceSyria.Value;
            }

            //TODO: changes in land bills

            //reflect changes in calculations and UI
            calculateResults();
            displayResults();

        }

        #endregion

        private void OnCheckboxChanged(object sender, RoutedEventArgs e)
        {
            
            landbill1 = (checkboxLandbill_1.IsChecked.Value) ?
                true : false;
            landbill2a = (checkboxLandbill_2a.IsChecked.Value) ?
                true : false;
            landbill2b = (checkboxLandbill_2b.IsChecked.Value) ?
                true : false;
            landbill3a = (checkboxLandbill_3a.IsChecked.Value) ?
                true : false;
            landbill3b = (checkboxLandbill_3b.IsChecked.Value) ?
                true : false;
            landbill3c = (checkboxLandbill_3c.IsChecked.Value) ?
                true : false;

            calculateResults();
            displayResults();
        }

        private void OnCheckboxUnchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
