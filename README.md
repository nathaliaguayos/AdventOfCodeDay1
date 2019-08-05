# Day 1: Chronal Calibration

This project is named "Chronal_Calibration" and is based on the [Advent Of Code](https://adventofcode.com) challenge of day 1, you should now that is a C# solution created in Visual Studio. The Solution has 3 projects actually, first one is the "Chronal_Calibration" which is the main project, is where I created the code to solve the challenge for part 1 and part 2; the second one is "ChronalCalibration_Part1_Tests" which is where the Unit Tests for Part 1 were created; the third one is "ChronalCalibration_Part1_Tests" which as a similar way was created to allocate the unit tests for Part 2 of the challenge. 



## Getting Started

At this moment you should know what kind of project is it, but please continue reading I'll let you know what are the prerequisites to get a copy of my project on your local machine and how you can run it.


### Prerequisites

About software

```
Install Visual Studio 2017
Install Git
```
Once you have installed the previous software, please clone my repo to your local machine. 

### Running the project

Now I'm going to tell you how you can run the application and explain a little the response that you'll receive.  

1. Open the "Chronal_Calibration" project. 
2. Select "Program" Class.
3. Notice that the main class is there and is the unique method that lives in this class. First of all, we have a file in the project called "Input", this is located in Chronal_Calibration > Resources > Input.txt, this is our program´s input, in other words, those values listed into the file are my frequency changes, so the first thing I did is convert this list of values into an array to give it to the 
FrequencyCalibration method, which is going to calculate the resulting frequency *(First part of the challenge)*.
4. Then after generating a resultingFrequencies list, I´m going to pass those values to my "FindTheFirsFrequencyReachedTwice, to find (as the method´s name says) the first frequency reached twice *(Second part of the challenge)*.
5. Click on the "Run" button and you will get a result.


## Running the tests

To run the test is similar to run the application, with a difference that we need to open our "Test Explorer" view, please make sure that you have it opened and then follow the next instructions:

**Tests for the first part of the challenge**
1. Open the "ChronalCalibration_Part1_Tests" project.
2. Select the "ChronalCalibration_Part1_Tests" Class. Notice that in this class we have some test methods, and each of them have "Arrange, Act and Assert" sections. 
3. In the Test Explorer, we can do a right-click over the "ChronalCalibration_Part1_Tests" and select "Run the selected Tests".
4. Wait until the Unit Tests run to see the Test results, all of them should be passed.

**NOTE:** *I used the scenarios given in [Day 1 Challenge Part 1](https://adventofcode.com/2018/day/1)* to create the unit tests, but those are not the only scenarios, they could be more.

**Tests for the second part of the challenge**
1. Open the "ChronalCalibration_Part2_Tests" project.
2. Select the "ChronalCalibration_Part2_Tests" Class. Notice that in this class we have some test methods, and each of them have "Arrange, Act and Assert" sections. 
3. In the Test Explorer, we can do a right-click over the "ChronalCalibration_Part2_Tests" and select "Run the selected Tests".
4. Wait until the Unit Tests run to see the Test results, all of them should be passed.

**NOTE:** *I used the scenarios given in [Day 1 Challenge Part 2](https://adventofcode.com/2018/day/1)* to create the unit tests, and I did it as the similar way that I did with the Input file in the Main class, I added in the ChronalCalibration_Part2_Tests > Resources 3 Test Files with values to test these suggested scenarios, but those are not the only scenarios, they could be more.


## Built With

* [Visual Studio 2017](https://www.visualstudio.com/thank-you-downloading-visual-studio/?sku=Community&rel=15)
* [Git](https://git-scm.com/download/win) 
* [GitHub](https://github.com)

## Authors

* **Nathali Aguayo** 
[GitHub](https://github.com/nathaliaguayos), [LinkedIn](https://www.linkedin.com/in/nathali-aguayo/)
