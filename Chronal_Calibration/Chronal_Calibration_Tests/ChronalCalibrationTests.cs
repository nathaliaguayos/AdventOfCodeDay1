using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Chronal_Calibration;

namespace Chronal_Calibration_Tests
{
    [TestClass]
    public class ChronalCalibrationTests
    {

        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the result of the frequency calibrator is not null
        /// </summary>
        [TestMethod]
        public void FrequencyCalibrationIsNotNullTest()
        {
            //Arrange
            ChronalCalibration calibrator = new ChronalCalibration();

            //Act
            int[] frequencyChanges = new int[3] { -1, -2, -3 };

            //Assert
            Assert.IsNotNull(calibrator.FrequencyCalibration(frequencyChanges));

        }

        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the result of the frequency calibrator with the frequency changes information given is 3.
        /// Expected result: 3
        /// </summary>
        [TestMethod]
        public void FrequencyCalibrationResultIs3()
        {
            //Arrange
            ChronalCalibration calibrator = new ChronalCalibration();

            //Act
            int[] frequencyChanges = new int[4] { +1, -2, +3, +1 };

            //Assert
            Assert.AreEqual(3, calibrator.FrequencyCalibration(frequencyChanges));
            
        }

        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the result of the frequency calibrator with the frequency changes information given is 3.
        /// Expected result: 3
        /// </summary>
        [TestMethod]
        public void FrequencyCalibrationResultIs3_v2()
        {
            //Arrange
            ChronalCalibration calibrator = new ChronalCalibration();

            //Act
            int[] frequencyChanges = new int[3] { +1, +1, +1 };

            //Assert
            Assert.AreEqual(3, calibrator.FrequencyCalibration(frequencyChanges));

        }

        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the result of the frequency calibrator with the frequency changes information given is 0.
        /// Expected result: 0
        /// </summary>
        [TestMethod]
        public void FrequencyCalibrationResultIs0()
        {
            //Arrange
            ChronalCalibration calibrator = new ChronalCalibration();

            //Act
            int[] frequencyChanges = new int[3] { +1, +1, -2 };

            //Assert
            Assert.AreEqual(0, calibrator.FrequencyCalibration(frequencyChanges));

        }

        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the result of the frequency calibrator with the frequency changes information given is -6.
        /// Expected result: -6
        /// </summary>
        [TestMethod]
        public void FrequencyCalibrationResultIs6Negative()
        {
            //Arrange
            ChronalCalibration calibrator = new ChronalCalibration();

            //Act
            int[] frequencyChanges = new int[3] { -1, -2, -3 };

            //Assert
            Assert.AreEqual(-6, calibrator.FrequencyCalibration(frequencyChanges));

        }

        /// <summary>
        /// Author: Nathali Aguayo
        /// Description: This test validate that the result of the frequency calibrator with the frequency changes information given is different than 3.
        /// </summary>
        [TestMethod]
        public void FrequencyCalibrationResultIsNotEqualTo3()
        {
            //Arrange
            ChronalCalibration calibrator = new ChronalCalibration();

            //Act
            int[] frequencyChanges = new int[3] { -1, -2, -3 };

            //Assert
            Assert.AreNotEqual(3, calibrator.FrequencyCalibration(frequencyChanges));

        }
    }
}
