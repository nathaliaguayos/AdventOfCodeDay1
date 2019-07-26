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
        /// Description: This project was created to solve the "Day 1: Chronal Calibration" challenge part 1 and 2.
        /// Here is the main class, so you just need to execute the solution and see the result. 
        /// </summary>
        static void Main(string[] args)
        {
            
            ChronalCalibration calibrator = new ChronalCalibration();
            List<int> resultingFrequencies = new List<int>();
            int[] dataForFreqCalibration = calibrator.ConfiguringDataForFreqCalibration(Properties.Resources.Input.Split('\n'));

            resultingFrequencies = calibrator.FrequencyCalibration(dataForFreqCalibration, 0, false);

            Console.WriteLine("======Day 1: Chronal Calibration======\n\nPart 1");
            Console.WriteLine("\nThe resulting frequency is: " + resultingFrequencies.Last());

            Console.WriteLine("\n\nPart 2\n");
            Console.WriteLine("the first frequency reached twice is: " + calibrator.FindingTheFirstFrequencyReachedTwice(dataForFreqCalibration,resultingFrequencies));
            Console.Read();
        }
    }
}
