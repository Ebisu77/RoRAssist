using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoRAssistWinApp.Service
{
    /// <summary>
    /// Provides all arithmetic operations
    /// </summary>
    public static class Calculations
    {

        #region Treasury Calculations

        /// <summary>
        /// Calculates basic income of state without provinces
        /// </summary>
        /// <param name="beginningTreasury">current status of treasury</param>
        /// <param name="annualRevenue">standard annual income</param>
        /// <param name="contributions">contributions from players to state treasury</param>
        /// <returns>basic income value</returns>
        public static int CalculateTreasuryBasicIncome(int beginningTreasury,
            int annualRevenue, int contributions)
        {
            int result = beginningTreasury + annualRevenue + contributions;
            return result;
        }

        /// <summary>
        /// Calculates income from all provinces
        /// </summary>
        /// <param name="africa">province income</param>
        /// <param name="asia">province income</param>
        /// <param name="bithynia">province income</param>
        /// <param name="cilicia">province income</param>
        /// <param name="crete">province income</param>
        /// <param name="gaulCisalpine">province income</param>
        /// <param name="gaulNarbonese">province income</param>
        /// <param name="gaulTransalpine">province income</param>
        /// <param name="grece">province income</param>
        /// <param name="illyricum">province income</param>
        /// <param name="sardinia">province income</param>
        /// <param name="sicily">province income</param>
        /// <param name="spainFurther">province income</param>
        /// <param name="spainNearer">province income</param>
        /// <param name="syria">province income</param>
        /// <returns>income from all provinces</returns>
        public static int CalculateTreasuryProvinces(int africa, int asia, int bithynia,
            int cilicia, int crete, int gaulCisalpine, int gaulNarbonese, int gaulTransalpine,
            int grece, int illyricum, int sardinia, int sicily, int spainFurther,
            int spainNearer, int syria)
        {
            return africa + asia + bithynia + cilicia + crete + gaulCisalpine +
                gaulNarbonese + gaulTransalpine + grece + illyricum + sardinia +
                sicily + spainFurther + spainNearer + syria;
        }

        /// <summary>
        /// Calculates basic expenses of state without land bills
        /// </summary>
        /// <param name="wars">number of active wars</param>
        /// <param name="legions">number of active legions</param>
        /// <param name="fleets">number of active fleets</param>
        /// <returns></returns>
        public static int CalculateTreasuryBasicExpenses(int wars, int legions, int fleets)
        {
            return (wars * Service.Constants.TREASURY_COST_WAR) +
                (legions * Service.Constants.TREASURY_COST_LEGION) +
                (fleets * Service.Constants.TREASURY_COST_FLEET);
        }

        /// <summary>
        /// Calculates expenses on land bills
        /// </summary>
        /// <param name="landbill_1a">land bill cost</param>
        /// <param name="landbill_2a">land bill cost</param>
        /// <param name="landbill_2b">land bill cost</param>
        /// <param name="landbill_3a">land bill cost</param>
        /// <param name="landbill_3b">land bill cost</param>
        /// <param name="landbill_3c">land bill cost</param>
        /// <returns>total expenses of all land bills</returns>
        public static int ClaculateTreasuryLandBills(bool landbill_1a, bool landbill_2a,
            bool landbill_2b, bool landbill_3a, bool landbill_3b, bool landbill_3c)
        {
            //determines if land bill is active and sets respective value            
            int bill1 = (landbill_1a) ?
                Service.Constants.LAND_BILL_1 : 0;
            int bill2a = (landbill_2a) ?
                Service.Constants.LAND_BILL_2 : 0;
            int bill2b = (landbill_2b) ?
                Service.Constants.LAND_BILL_2 : 0;
            int bill3a = (landbill_3a) ?
                Service.Constants.LAND_BILL_3 : 0;
            int bill3b = (landbill_3b) ?
                Service.Constants.LAND_BILL_3 : 0;
            int bill3c = (landbill_3c) ?
                Service.Constants.LAND_BILL_3 : 0;

            //calculates resulting cost of all land bills
            return bill1 + bill2a + bill2b + bill3a + bill3b + bill3c;
        }

        /// <summary>
        /// Calculates final state of treasury
        /// </summary>
        /// <param name="basicIncome">income without provinces</param>
        /// <param name="provinces">income from provinces</param>
        /// <param name="basicExpenses">expenses without land bills</param>
        /// <param name="landbills">expenses on land bills</param>
        /// <returns>final state of treasury</returns>
        public static int CalculateTreasuryTotal(int basicIncome, int provinces, int basicExpenses, int landbills)
        {
            return basicIncome + provinces - basicExpenses - landbills;
        }

        /// <summary>
        /// Calculate change between beggining and final state of treasury
        /// </summary>
        /// <param name="startingTreasury">state of treasury at the beginning</param>
        /// <param name="finalTreasury">state of treasury at the end</param>
        /// <returns>change in treasury</returns>
        public static int CalculateTreasuryChange(int startingTreasury, int finalTreasury)
        {
            return finalTreasury - startingTreasury;
        }

        #endregion

        #region Persuasion Calculations

        /// <summary>
        /// Calculates base number for persuation attemp
        /// </summary>
        /// <param name="attackingSenatorOratory">oratory of attacking senator</param>
        /// <param name="attackingSenatorInfluence">influence of attacking senator</param>
        /// <param name="attackingSenatorBribe">bribe invested by attacking senator</param>
        /// <param name="deffendingSenatorLoyalty">loyalty of defending senator</param>
        /// <param name="deffendingSenatorPersonalTreasury">personal treasury of defending senator</param>
        /// <param name="deffendingSenatorCounterBribe">counter bribe of defending senator</param>
        /// <param name="senatorAlignementStatus">status determining if defending senator is member of a faction</param>
        /// <returns>result base number</returns>
        public static int CalculatePersuasionBaseNumber(int attackingSenatorOratory, int attackingSenatorInfluence,
                int attackingSenatorBribe, int deffendingSenatorLoyalty, int deffendingSenatorPersonalTreasury,
                int deffendingSenatorCounterBribe, bool senatorAlignementStatus)
        {
            //calculation support
            int senatorAlignementValue;

            //determining value for defending senator based on his faction alignement            
            senatorAlignementValue = (senatorAlignementStatus) ?
                Service.Constants.DEFENDING_SENATOR_IN_FACTION : Service.Constants.DEFENDING_SENATOR_NEUTRAL;

            //calculating result number and returning value
            return (attackingSenatorOratory + attackingSenatorInfluence
                + attackingSenatorBribe) - (deffendingSenatorLoyalty + deffendingSenatorPersonalTreasury
                + deffendingSenatorCounterBribe + senatorAlignementValue);
        }

        /// <summary>
        /// Calculates final dice roll needed for persuasion attemp
        /// </summary>
        /// <param name="persuasionBaseNumber">base number for calculation</param>
        /// <param name="eraEndCardDrawn">determines if era ends</param>
        /// <returns>final dice roll number</returns>
        public static int CalculatePersuasionDiceRoll(int persuasionBaseNumber, bool eraEndCardDrawn)
        {

            //calculate dice roll, return result
            if (!eraEndCardDrawn)
            {
                if (persuasionBaseNumber <= 9)
                {
                    return persuasionBaseNumber;
                }
                else
                {
                    return Service.Constants.ERA_END_NOT_ACTIVE;
                }
            }
            else
            {
                if (persuasionBaseNumber <= 8)
                {
                    return persuasionBaseNumber;
                }
                else
                {
                    return Service.Constants.ERA_END_ACTIVE;
                }
            }
        }

        #endregion

    }
}
