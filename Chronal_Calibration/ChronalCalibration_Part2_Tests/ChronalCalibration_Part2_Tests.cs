using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chronal_Calibration;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace ChronalCalibration_Part2_Tests
{
    [TestClass]
    public class ChronalCalibration_Part2_Tests
    {
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the result of the First Frequency Reached Twice is not null
        /// </summary>
        [TestMethod]
        public void IsNotNullTest()
        {
            //Arrange
            ChronalCalibration calibrator = new ChronalCalibration();

            //Act
            int[] dataForFreqCalibration =
            calibrator.ConfiguringDataForFreqCalibration(Properties.Resources.TestFile1.Split('\n'));

            var resultingFrequenciesCalibrated = calibrator.FrequencyCalibration(dataForFreqCalibration, 0, false);
            var result = calibrator.FindingTheFirstFrequencyReachedTwice(dataForFreqCalibration, resultingFrequenciesCalibrated);
            //Assert
            Assert.IsNotNull(result);
        }
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the result of the First Frequency Reached Twice is equals to 10
        /// </summary>
        [TestMethod]
        public void FirstReachedTwiceIs10()
        {
            //Arrange
            ChronalCalibration calibrator = new ChronalCalibration();

            //Act
            int[] dataForFreqCalibration =
                calibrator.ConfiguringDataForFreqCalibration(Properties.Resources.TestFile1.Split('\n'));

            var resultingFrequenciesCalibrated = calibrator.FrequencyCalibration(dataForFreqCalibration, 0, false);
            var result = calibrator.FindingTheFirstFrequencyReachedTwice(dataForFreqCalibration, resultingFrequenciesCalibrated);
            //Assert
            Assert.AreEqual(10,result);
        }
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the result of the First Frequency Reached Twice is equals to 5
        /// </summary>
        [TestMethod]
        public void FirstReachedTwiceIs5()
        {
            //Arrange
            ChronalCalibration calibrator = new ChronalCalibration();

            //Act
            int[] dataForFreqCalibration =
                calibrator.ConfiguringDataForFreqCalibration(Properties.Resources.TestFile2.Split('\n'));

            var resultingFrequenciesCalibrated = calibrator.FrequencyCalibration(dataForFreqCalibration, 0, false);
            var result = calibrator.FindingTheFirstFrequencyReachedTwice(dataForFreqCalibration, resultingFrequenciesCalibrated);
            //Assert
            Assert.AreEqual(5, result);
        }
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the result of the First Frequency Reached Twice is equals to 14
        /// </summary>
        [TestMethod]
        public void FirstReachedTwiceIs14()
        {
            //Arrange
            ChronalCalibration calibrator = new ChronalCalibration();

            //Act
            int[] dataForFreqCalibration =
                calibrator.ConfiguringDataForFreqCalibration(Properties.Resources.TestFile3.Split('\n'));

            var resultingFrequenciesCalibrated = calibrator.FrequencyCalibration(dataForFreqCalibration, 0, false);
            var result = calibrator.FindingTheFirstFrequencyReachedTwice(dataForFreqCalibration, resultingFrequenciesCalibrated);
            //Assert
            Assert.AreEqual(14, result);
        }
        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the result of the First Frequency Reached Twice is not equals to 0
        /// </summary>
        [TestMethod]
        public void FirstReachedTwiceIsNot0()
        {
            //Arrange
            ChronalCalibration calibrator = new ChronalCalibration();

            //Act
            int[] dataForFreqCalibration =
                calibrator.ConfiguringDataForFreqCalibration(Properties.Resources.TestFile3.Split('\n'));

            var resultingFrequenciesCalibrated = calibrator.FrequencyCalibration(dataForFreqCalibration, 0, false);
            var result = calibrator.FindingTheFirstFrequencyReachedTwice(dataForFreqCalibration, resultingFrequenciesCalibrated);
            //Assert
            Assert.AreNotEqual(0, result);
        }
    }
}
