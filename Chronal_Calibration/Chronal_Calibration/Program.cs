using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
            
            string[] lines = Properties.Resources.Input.Split('\n');
            int[] frequencyChanges = new int[lines.Length];
            ChronalCalibration calibrator = new ChronalCalibration();
            for (int i = 0; i < lines.Length; i++)
            {
                frequencyChanges[i] = Int32.Parse(lines[i]);
            }
            Console.WriteLine("The resulting frequency is: " + calibrator.FrequencyCalibration(frequencyChanges));
            Console.Read();
        }
       
    }
}
