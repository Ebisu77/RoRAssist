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
        /// <param name="attackingSenatorOratory">oratory of attackin senator</param>
        /// <param name="attackingSenatorInfluence">influence of attackin senator</param>
        /// <param name="attackingSenatorBribe">bibe invested by attacking senator</param>
        /// <param name="deffendingSenatorLoyalty">loyalty of defending senator</param>
        /// <param name="deffendingSenatorPersonalTreasury">personal treasury of defending senator</param>
        /// <param name="deffendingSenatorCounterBribe">counter bribe of defending senator</param>
        /// <param name="senatorAlignementStatus">status determining if defending senator is member of a faction</param>
        /// <returns></returns>
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
            
            
        #endregion


    }
}
