using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronal_Calibration
{
    public class ChronalCalibration
    {
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This program was created to solve the "Day 1: Chronal Calibration" challenge.
        /// You just need to click on "Start" button and the magic will start. :)
        /// </summary>
        /// <param name="frequencyChanges"></param>
        /// <returns>The returned result is the resulting frequency for the frequency changes</returns>
        public int FrequencyCalibration(int[] frequencyChanges)
        {
            var resultingFreq = 0;
            for (var cf = 0; cf < frequencyChanges.Length; cf++)
            {
                if (cf == 0)
                {
                    Console.WriteLine("Current frequency " + cf + ", change of " + frequencyChanges[cf] +
                                      "; resulting frequency " + (frequencyChanges[cf] + cf));
                    resultingFreq = frequencyChanges[cf] + cf;
                }
                else
                {
                    Console.WriteLine("Current frequency " + resultingFreq + ", change of " + frequencyChanges[cf] +
                                      "; resulting frequency " + (frequencyChanges[cf] + resultingFreq));
                    resultingFreq = frequencyChanges[cf] + resultingFreq;
                }
            }
            return resultingFreq;
        }
    }
}
