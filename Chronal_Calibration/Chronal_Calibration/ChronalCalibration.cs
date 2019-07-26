using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Chronal_Calibration
{
    public class ChronalCalibration
    {
        protected List<int> resultingFrequency = new List<int>();

        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: In this method I'm configuring the data for the FrequencyCalibrator method. 
        /// </summary>
        /// <returns></returns>
        public int[] ConfiguringDataForFreqCalibration(string[] lines)
        {
            //string[] lines = Properties.Resources.Input.Split('\n');
            int[] frequencyChanges = new int[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                frequencyChanges[i] = Int32.Parse(lines[i]);
            }

            return frequencyChanges;
        }

        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This method was created to solve the "Day 1: Chronal Calibration" challenge part 1.
        /// here I'm going to find the resulting frequency for the Chronal Calibration device.
        /// and if the areYouLookingForTheFFRT flag is true, that means that we need to run the calibration again to find the First
        /// Frequency Reached Twice, so i´m going to switch off the messages in the console. 
        /// </summary>
        /// <param name="frequencyChanges"></param>
        /// <param name="startFrequency"></param>
        /// /// <param name="areYouLookingForTheFFRT"></param>
        /// <returns>The returned result is the list of the frequency changes</returns>
        public List<int> FrequencyCalibration(int[] frequencyChanges, int startFrequency,Boolean areYouLookingForTheFFRT)
        {
            if(resultingFrequency.Count==0)
            {
                resultingFrequency.Add(startFrequency);
            }
            var resultingFreq = 0;
            for (var cf = 0; cf < frequencyChanges.Length; cf++)
            {
                if (cf == 0)
                {
                    //to avoid print the data when we are looking for the the "First Frequency Reached Twice" (FFRT)
                    if (!areYouLookingForTheFFRT)
                    {
                        Console.WriteLine("Current frequency " + startFrequency + ", change of " +
                                          frequencyChanges[cf] +
                                          "; resulting frequency " + (frequencyChanges[cf] + startFrequency));
                    }

                    resultingFreq = frequencyChanges[cf] + startFrequency;
                    
                    resultingFrequency.Add(resultingFreq);
                }
                else
                {
                    //to avoid print the data when we are looking for the the "First Frequency Reached Twice" (FFRT)
                    if (!areYouLookingForTheFFRT)
                    {
                        Console.WriteLine("Current frequency " + resultingFreq + ", change of " + frequencyChanges[cf] +
                                          "; resulting frequency " + (frequencyChanges[cf] + resultingFreq));
                    }

                    resultingFreq = frequencyChanges[cf] + resultingFreq;
                    resultingFrequency.Add(resultingFreq);
                }
            }
            return resultingFrequency;
        }
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This method was created to solve the "Day 1: Chronal Calibration" challenge part 2.
        /// here I'm going to find the first frequency reached twice for the Chronal Calibration device. 
        /// </summary>
        /// <returns></returns>
        public int FindingTheFirstFrequencyReachedTwice(int[] listOfFrequencyChanges, List<int> listOfResultingFrequency)
        {
            var duplicateKeys = new Dictionary<int, int>();
            foreach (var frequency in listOfResultingFrequency)
            {
                if (duplicateKeys.ContainsKey(frequency))
                {
                    return frequency;
                }
                else
                {
                    duplicateKeys.Add(frequency, 1);
                }
            }
            var resultingFrequency = FrequencyCalibration(listOfFrequencyChanges, listOfResultingFrequency.Last(), true);
            return FindingTheFirstFrequencyReachedTwice(listOfFrequencyChanges,resultingFrequency);
        }
    }
}
