using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chronal_Calibration
{
    class Program
    {
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: Here is where we configure our frequency change information, we generate an array of random values,
        /// and then we will send this array to the "Calibrator" to processing this information and obtain the resulting frequency.
        /// </summary>
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] frequencyChanges = new int[4];
            ChronalCalibration calibrator = new ChronalCalibration();
            for (int i = 0; i < frequencyChanges.Length; i++)
            {
                frequencyChanges[i] = random.Next(-10, 10); //here is where we are filling the array with random values.
            }
            Console.WriteLine("The resulting frequency is: "+ calibrator.FrequencyCalibration(frequencyChanges));
            Console.Read();
        }
       
    }
}
