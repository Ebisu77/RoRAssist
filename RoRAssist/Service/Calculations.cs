using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoRAssist.Service
{
    /// <summary>
    /// Provides all arithmetic operations
    /// </summary>
    public static class Calculations
    {

        #region Persuasion Page Calculations

        /// <summary>
        /// Calculates Base number for persuation attemp
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
                    //declaring calculation support
                    int senatorAlignementValue;
                    int baseNumberResult; 

                    //determining value for defending senator based on his faction alignement
                    if (senatorAlignementStatus)
                    {
                        senatorAlignementValue = 7;
                    }
                    else
                    {
                        senatorAlignementValue = 0;   
                    }

                    //calculating result number and returning value
                    baseNumberResult = (attackingSenatorOratory + attackingSenatorInfluence + attackingSenatorBribe) -
                        (deffendingSenatorLoyalty + deffendingSenatorPersonalTreasury + deffendingSenatorCounterBribe + senatorAlignementValue);
                        
                    return baseNumberResult;
                }


        public static int CalculatePersuasionDiceRoll(int persuasionBaseNumber, bool eraEndCardDrawn)
        {

            //calculate actual dice roll, return result
            if (!eraEndCardDrawn)
            {
                if (persuasionBaseNumber <= 9)
                {
                    return persuasionBaseNumber;
                }
                else
                {
                    return 9;
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
                    return 8;
                }
            }
        }
            
            
        #endregion


    }
}
