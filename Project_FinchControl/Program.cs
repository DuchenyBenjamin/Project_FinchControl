using System;
using System.Collections.Generic;
using FinchAPI;
using System.Globalization;
using System.IO;
using System.Diagnostics;
using static System.Console;
using System.Linq;

namespace Project_FinchControl
{

    //************************************
    //Title: Finch Control
    //Application Type: Console For finch Controle
    //Description: To Function As A Controle DiviceFor The Finch Robot.
    //Author: Benjamin Ducheny
    //Date Created: 10/1/2020
    //Last Modified:10/6/2020
    //*************************************
    /// <summary>
    /// User Commands
    /// </summary>
    public enum Command
    {
        NONE,
        MOVEFORWARD,
        MOVEBACKWARD,
        STOPMOTORS,
        WAIT,
        TURNRIGHT,
        TURNLEFT,
        CNOTEON,
        DNOTEON,
        ENOTEON,
        FNOTEON,
        NOTEOFF,
        LEDON,
        LEDOFF,
        GETTEMPERATURE,
        DONE
    }

    class Program
    {
        /// <summary>
        /// first method run when the app starts up
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            DisplayWelcomeScreen();

            DisplaySetTheme();

            DisplayLoginRegister();

            DisplayMenuScreen();
            DisplayClosingScreen();
        }

        /// <summary>
        /// setup the console theme
        /// </summary>
        static void SetTheme()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.BackgroundColor = ConsoleColor.White;
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Main Menu                                 *
        /// *****************************************************************
        /// </summary>
        static void DisplayMenuScreen()
        {
            Console.CursorVisible = true;

            bool quitApplication = false;
            string menuChoice;

            Finch finchRobot = new Finch();

            do
            {
                DisplayScreenHeader("Main Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\ta) Connect Finch Robot");
                Console.WriteLine("\tb) Talent Show");
                Console.WriteLine("\tc) Data Recorder");
                Console.WriteLine("\td) Alarm System");
                Console.WriteLine("\te) User Programming");
                Console.WriteLine("\tf) Change the console theme");
                Console.WriteLine("\tg) Disconnect Finch Robot");
                Console.WriteLine("\tq) Quit");
                Console.WriteLine("\t--------------------------------");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();

                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        DisplayConnectFinchRobot(finchRobot);
                        break;

                    case "b":
                        DisplayTalentShowMenuScreen(finchRobot);
                        break;

                    case "c":
                        DataRecorderDisplayMenuScreen(finchRobot);
                        break;

                    case "d":
                        AlarmSystemDisplayMenuScreen(finchRobot);
                        break;

                    case "e":
                        UserProgrammingDisplayMenuScreen(finchRobot);
                        break;

                    case "f":
                        DisplaySetTheme();
                        break;

                    case "g":
                        DisplayDisconnectFinchRobot(finchRobot);
                        break;

                    case "q":
                        DisplayDisconnectFinchRobot(finchRobot);
                        quitApplication = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitApplication);
        }



        #region TALENT SHOW

        /// <summary>
        /// *****************************************************************
        /// *                     Talent Show Menu                          *
        /// *****************************************************************
        /// </summary>
        static void DisplayTalentShowMenuScreen(Finch finchRobot)
        {
            Console.CursorVisible = true;

            bool quitTalentShowMenu = false;
            string menuChoice;

            do
            {
                DisplayScreenHeader("Talent Show Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\ta) Light and Sound");
                Console.WriteLine("\tb) Full turn simulation");
                Console.WriteLine("\tc) SingWithMe");
                Console.WriteLine("\td) Mix It Up");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                Console.WriteLine("\t--------------------------------");
                menuChoice = Console.ReadLine().ToLower();


                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        FunWithLights(finchRobot);
                        break;

                    case "b":
                        SpinDance(finchRobot);
                        break;

                    case "c":
                        SingWithMe(finchRobot);
                        break;

                    case "d":
                        MixItUp(finchRobot);
                        break;

                    case "q":
                        quitTalentShowMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }

            } while (!quitTalentShowMenu);

        }
        static void SingWithMe(Finch finchRobot)
        {
            DisplayScreenHeader("Sing a song with me");
            Console.WriteLine("\tThe finch will now play the birthday song.");
            for (int i = 0; i < 1; i++)
            {
                finchRobot.noteOn(784);
                finchRobot.wait(500);

                finchRobot.noteOn(880);
                finchRobot.wait(500);

                finchRobot.noteOn(784);
                finchRobot.wait(500);

                finchRobot.noteOn(1047);
                finchRobot.wait(500);

                finchRobot.noteOn(988);
                finchRobot.wait(800);

                finchRobot.noteOn(784);
                finchRobot.wait(500);

                finchRobot.noteOn(880);
                finchRobot.wait(500);

                finchRobot.noteOn(784);
                finchRobot.wait(500);

                finchRobot.noteOn(1200);
                finchRobot.wait(500);

                finchRobot.noteOn(1047);
                finchRobot.wait(800);

                finchRobot.noteOn(784);
                finchRobot.wait(500);

                finchRobot.noteOn(1500);
                finchRobot.wait(500);

                finchRobot.noteOn(1310);
                finchRobot.wait(500);

                finchRobot.noteOn(1047);
                finchRobot.wait(500);

                finchRobot.noteOn(988);
                finchRobot.wait(500);

                finchRobot.noteOn(880);
                finchRobot.wait(1000);

                finchRobot.noteOn(1400);
                finchRobot.wait(500);

                finchRobot.noteOn(1310);
                finchRobot.wait(500);

                finchRobot.noteOn(1047);
                finchRobot.wait(500);

                finchRobot.noteOn(1200);
                finchRobot.wait(500);

                finchRobot.noteOn(1047);
                finchRobot.wait(1200);

                finchRobot.noteOff();
                finchRobot.wait(200);

                DisplayContinuePrompt();
            }
        }

        static void MixItUp(Finch finchRobot)
        {
            DisplayScreenHeader("Dance!");
            Console.WriteLine("\tThe Finch robot will now dance.");

            DisplayContinuePrompt();
            Console.Clear();

            finchRobot.setMotors(255, -255);

            finchRobot.setLED(144, 111, 111);
            finchRobot.noteOn(784);
            finchRobot.wait(500);

            finchRobot.noteOn(880);
            finchRobot.wait(500);

            finchRobot.noteOn(784);
            finchRobot.wait(500);

            finchRobot.noteOn(1047);
            finchRobot.wait(500);

            finchRobot.noteOn(988);
            finchRobot.wait(800);
            finchRobot.setLED(31, 255, 76);
            finchRobot.noteOn(784);
            finchRobot.wait(500);

            finchRobot.noteOn(880);
            finchRobot.wait(500);

            finchRobot.noteOn(784);
            finchRobot.wait(500);

            finchRobot.noteOn(1200);
            finchRobot.wait(500);

            finchRobot.noteOn(1047);
            finchRobot.wait(800);

            finchRobot.noteOn(784);
            finchRobot.wait(500);
            finchRobot.setLED(156, 234, 77);
            finchRobot.noteOn(1500);
            finchRobot.wait(500);

            finchRobot.noteOn(1310);
            finchRobot.wait(500);

            finchRobot.noteOn(1047);
            finchRobot.wait(500);

            finchRobot.noteOn(988);
            finchRobot.wait(500);

            finchRobot.noteOn(880);
            finchRobot.wait(1000);

            finchRobot.noteOn(1400);
            finchRobot.wait(500);

            finchRobot.noteOn(1310);
            finchRobot.wait(500);
            finchRobot.setLED(67, 114, 235);
            finchRobot.noteOn(1047);
            finchRobot.wait(500);

            finchRobot.noteOn(1200);
            finchRobot.wait(500);

            finchRobot.noteOn(1047);
            finchRobot.wait(1200);

            finchRobot.noteOff();
            finchRobot.wait(200);

            finchRobot.setMotors(0, 0);
            finchRobot.setLED(0, 0, 0);
            DisplayContinuePrompt();

        }

        static void SpinDance(Finch finchRobot)
        {
            DisplayScreenHeader("Dance!");

            Console.WriteLine("\tThe Finch robot will now dance.");
            DisplayContinuePrompt();

            finchRobot.setMotors(255, -255);

            finchRobot.setMotors(0, 0);

            DisplayContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *               Talent Show > Light and Sound                   *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void FunWithLights(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("A fun little ");

            Console.WriteLine("\tThe Finch robot will not show off its glowing talent!");
            DisplayContinuePrompt();

            for (int lightSoundLevel = 0; lightSoundLevel < 255; lightSoundLevel++)
            {
                finchRobot.setLED(lightSoundLevel, lightSoundLevel, lightSoundLevel);
                finchRobot.noteOn(lightSoundLevel * 100);
            }

            DisplayMenuPrompt("Talent Show Menu");
        }

        #endregion

        #region DataRecorder
        /// <summary>
        /// Menu Screen
        /// </summary>
        static void DataRecorderDisplayMenuScreen(Finch finchRobot)
        {
            string menuChoice;
            bool quitMenu = false;

            int numberOfDataPoints = 0;
            double dataPointFrequency = 0;
            double[] temperatures = null;
            do
            {
                DisplayScreenHeader("Data Recorder Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\ta) Number of Data points");
                Console.WriteLine("\tb) Frequency of Data points");
                Console.WriteLine("\tc) Get Data");
                Console.WriteLine("\td) Show Data");
                Console.WriteLine("\tq) Main Menu");
                Console.Write("\t\tEnter Choice:");
                Console.WriteLine();
                Console.WriteLine("\t--------------------------------");
                menuChoice = Console.ReadLine().ToLower();



                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        numberOfDataPoints = DataRecorderDisplayGetNumberOfDataPoints();
                        break;

                    case "b":
                        dataPointFrequency = DataRecorderDisplayGetFrequencyOfDataPoints();
                        break;

                    case "c":
                        temperatures = DataRecorderDisplayGetDataSet(numberOfDataPoints, dataPointFrequency, finchRobot);
                        break;

                    case "d":
                        DataRecorderDisplayDataSet(temperatures);
                        break;

                    case "q":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }
            } while (!quitMenu);
        }
        /// <summary>
        /// Display temperatures
        /// </summary>
        static void DataRecorderDisplayDataSet(double[] temperatures)
        {
            DisplayScreenHeader("Display Data");

            DataRecorderDisplayTable(temperatures);

            DisplayContinuePrompt();
        }

        /// <summary>
        /// Data Recorder Table
        /// </summary>
        /// <param name="temperatures"></param>
        static void DataRecorderDisplayTable(double[] temperatures)
        {
            //
            //display table headers
            //
            Console.WriteLine(
                "Recording #  ".PadLeft(15) +
                "Temp".PadLeft(15)
                );
            Console.WriteLine(
                "-----------".PadLeft(15) +
                "-----------".PadLeft(15)
                );
            //
            //display table data
            //

            for (int index = 0; index < temperatures.Length; index++)
            {
                Console.WriteLine(
                (index + 1).ToString().PadLeft(15) + " | " +
                temperatures[index].ToString().PadLeft(15)
                );
            }
            DataRecorderDisplayAverageAndSum(temperatures);
        }

        /// <summary>
        /// Get average and sum
        /// </summary>
        static void DataRecorderDisplayAverageAndSum(double[] temperatures)
        {
            double sum = 0, avg = 0;
            //
            //calculate Average And Sum
            //

            for (int i = 0; i < temperatures.Length; i++)
            {
                sum += temperatures[i];
            }
            avg = sum / temperatures.Length;

            //
            //display table Average And Sum
            //

            Console.WriteLine("The Sum is : " + sum);
            Console.WriteLine("The Average is : " + avg);
        }

        /// <summary>
        /// This gets your array
        /// </summary>
        static double[] DataRecorderDisplayGetDataSet(int numberOfDataPoints, double dataPointFrequency, Finch finchRobot)
        {
            double[] temperatures = new double[numberOfDataPoints];
            DisplayScreenHeader("Get Data");
            //
            //Display the Frequency and number of data points
            //
            Console.WriteLine($"\tNumber Of Data Points: {numberOfDataPoints}");
            Console.WriteLine($"\tfrequency Of Data Points: {dataPointFrequency}");
            Console.WriteLine();

            Console.WriteLine("\tThe finch robot is ready to record temperature data. Press any key to begin.");
            Console.ReadKey();
            //
            //record temperture
            //
            double temperture;
            int frequencyOfDataPointsMilliseconds;
            for (int index = 0; index < numberOfDataPoints; index++)
            {
                temperture = finchRobot.getTemperature() * 1.8 + 32;
                Console.WriteLine($"Temperature Reading {index + 1}: | {temperture}");
                temperatures[index] = temperture;
                frequencyOfDataPointsMilliseconds = (int)(dataPointFrequency * 1000);
                finchRobot.wait(frequencyOfDataPointsMilliseconds);

            }
            DisplayContinuePrompt();
            DisplayScreenHeader("Get Data");
            Console.WriteLine();
            Console.WriteLine("Table of Temperatures");
            Console.WriteLine();
            DataRecorderDisplayTable(temperatures);

            DisplayContinuePrompt();

            return temperatures;
        }

        /// <summary>
        /// *****************************************************************
        /// *      Data Recorder > Get the Number of Data Points            *
        /// *****************************************************************
        /// </summary>
        /// <returns> Number of Data Points  </returns>
        static int DataRecorderDisplayGetNumberOfDataPoints()
        {
            bool exit = false;
            int numberOfDataPoints;
            string choice;
            Console.CursorVisible = false;

            DisplayScreenHeader("Number of data points");
            //get user input
            Console.WriteLine("\tNumber of data points:");
            int.TryParse(Console.ReadLine(), out numberOfDataPoints);

            //validate user input
            Console.WriteLine();
            Console.WriteLine($"\tNumber of data points: {numberOfDataPoints}");
            Console.WriteLine();
            do
            {


                Console.WriteLine("\tIs This the correct amount of data points?");
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\tY) Yes");
                Console.WriteLine("\tN) No");
                Console.WriteLine("\t--------------------------------");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
                switch (choice)
                {
                    case "y":
                        Console.WriteLine("\tNumber of data points has been confirmed");
                        exit = true;

                        break;

                    case "n":
                        Console.WriteLine("\tPlease re-enter");
                        DataRecorderDisplayGetNumberOfDataPoints();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                }
            } while (!exit);

            DisplayMenuPrompt("Main Menu");
            return numberOfDataPoints;
        }

        /// <summary>
        /// *****************************************************************
        /// *      Data Recorder > Get the Frequency of Data Points         *
        /// *****************************************************************
        /// </summary>
        /// <returns> Frequency of Data Points </returns>
        static double DataRecorderDisplayGetFrequencyOfDataPoints()
        {
            bool exit = false;
            string choice;
            double dataPointFrequency;
            Console.CursorVisible = false;

            DisplayScreenHeader("Data Point Frequency");
            //get user input
            Console.WriteLine("\tFrequency of data Points:");
            double.TryParse(Console.ReadLine(), out dataPointFrequency);

            //validate user input
            Console.WriteLine();
            Console.WriteLine($"\tFrequency of data points: {dataPointFrequency}");
            do
            {


                Console.WriteLine("\tIs This the correct Frequency for your data points?");
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\tY) Yes");
                Console.WriteLine("\tN) No");
                Console.WriteLine("\t--------------------------------");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
                switch (choice)
                {
                    case "y":
                        Console.WriteLine();
                        Console.WriteLine("\tFrequency of data points has been confirmed");
                        exit = true;
                        break;

                    case "n":
                        Console.WriteLine();
                        Console.WriteLine("\tPlease re-enter");
                        exit = true;
                        DataRecorderDisplayGetFrequencyOfDataPoints();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                }
            } while (!exit);

            DisplayMenuPrompt("Main Menu");
            return dataPointFrequency;
        }
        #endregion

        #region ALARM SYSTEM
        static void AlarmSystemDisplayMenuScreen(Finch finchRobot)
        {
            string menuChoice;
            bool quitMenu = false;
            string sensorsToMonitor = "";
            string rangeType = "";
            int minMaxThresholdValue = 0;
            int timeToMonitor = 0;

            do
            {
                DisplayScreenHeader("Alarm System Menu");

                //
                // get user menu choice
                //
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\ta) Set Sensors to Monitor");
                Console.WriteLine("\tb) Set Range Type");
                Console.WriteLine("\tc) Display current light sensor value");
                Console.WriteLine("\td) Set Minimum/Maximum Threshold Value");
                Console.WriteLine("\te) Set Time to Monitor");
                Console.WriteLine("\tf) Show alarm settings");
                Console.WriteLine("\tg) Set Alarm");
                Console.WriteLine("\th) Main Menu");
                Console.Write("\t\tEnter Choice:");
                Console.WriteLine();
                Console.WriteLine("\t--------------------------------");
                menuChoice = Console.ReadLine().ToLower();



                //
                // process user menu choice
                //
                switch (menuChoice)
                {
                    case "a":
                        sensorsToMonitor = AlarmSystemDisplaySetSensorsToMonitor(finchRobot, sensorsToMonitor);
                        break;

                    case "b":
                        rangeType = AlarmSystemDisplaySetRangeType();
                        break;

                    case "c":
                        DataRecorderDisplayCurrentSingleLightSensorValue(finchRobot, sensorsToMonitor);
                        break;

                    case "d":
                        minMaxThresholdValue = AlarmSystemDisplaySetMinMaxThresholdValue(rangeType, finchRobot, sensorsToMonitor);
                        break;

                    case "e":
                        timeToMonitor = AlarmSystemDisplaySetTimeToMonitor();
                        break;

                    case "f":
                        DataRecorderDisplayAlarmParameters(finchRobot, sensorsToMonitor, rangeType, minMaxThresholdValue, timeToMonitor);
                        break;

                    case "g":
                        LightAlarmSetAlarm(finchRobot, sensorsToMonitor, rangeType, minMaxThresholdValue, timeToMonitor);
                        break;

                    case "h":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }
            } while (!quitMenu);
            DisplayContinuePrompt();
        }

        private static void DataRecorderDisplayAlarmParameters(
            Finch finchRobot,
            string sensorsToMonitor,
            string rangeType,
            int minMaxThresholdValue,
            int timeToMonitor)
        {
            //Display all settings
            Console.Clear();
            Console.WriteLine($"\tSensors To Monitor {sensorsToMonitor}");
            Console.WriteLine($"\tRange Type: {rangeType}");
            Console.WriteLine($"\tMin/Max threshold value: {minMaxThresholdValue}");
            Console.WriteLine($"\tTime to monitor: {timeToMonitor}");
            DisplayContinuePrompt();
        }

        static void LightAlarmSetAlarm(
            Finch finchRobot,
            string sensorsToMonitor,
            string rangeType,
            int minMaxThresholdValue,
            int timeToMonitor)
        {
            bool thresholdExceeded = false;
            int currentLightSensorValue = 0;
            int secondsElapsed = 0;

            DisplayScreenHeader("Set Alarm");

            Console.WriteLine($"\tSensors To Monitor {sensorsToMonitor}");
            Console.WriteLine($"\tRange Type: {rangeType}");
            Console.WriteLine($"\tMin/Max threshold value: {minMaxThresholdValue}");
            Console.WriteLine($"\tTime to monitor: {timeToMonitor}");
            Console.WriteLine();

            Console.WriteLine("\tPress any key to begin monitoring");
            Console.ReadKey();
            Console.WriteLine();
            //Begin monitoring
            while ((secondsElapsed < timeToMonitor) && !thresholdExceeded)
            {
                switch (rangeType)
                {
                    case "left":
                        currentLightSensorValue = finchRobot.getLeftLightSensor();
                        break;

                    case "right":
                        currentLightSensorValue = finchRobot.getRightLightSensor();
                        break;

                    case "both":
                        currentLightSensorValue = (finchRobot.getRightLightSensor() + finchRobot.getLeftLightSensor()) / 2;
                        break;
                }
                switch (rangeType)
                {

                    case "minimum":
                        if (currentLightSensorValue < minMaxThresholdValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;

                    case "maximum":
                        if (currentLightSensorValue > minMaxThresholdValue)
                        {
                            thresholdExceeded = true;
                        }
                        break;
                }
                Console.SetCursorPosition(25, 10);
                Console.WriteLine($"Time Elapsed: {secondsElapsed} seconds");
                finchRobot.wait(1000);
                secondsElapsed++;

            }

            if (thresholdExceeded)
            {
                Console.WriteLine($"\tThe {rangeType} threshold value of {minMaxThresholdValue} was exceeded by the current light sensor value of {currentLightSensorValue}.");
            }
            else
            {
                Console.WriteLine($"\tThe {rangeType} threshold value of {minMaxThresholdValue} was not exceeded.");
            }
            DisplayMenuPrompt("Alarm system");
        }
        static void DataRecorderDisplayCurrentSingleLightSensorValue(Finch finchRobot, string sensorsToMonitor)
        {
            //Display the current light sensor value for a single value 
            Console.Clear();
            switch (sensorsToMonitor)
            {
                case "left":
                    Console.WriteLine($"\tLeft light sensor ambient value: {finchRobot.getLeftLightSensor()}");
                    break;

                case "right":
                    Console.WriteLine($"\tRight light sensor ambient value: {finchRobot.getRightLightSensor()}");
                    break;

                case "both":
                    DataRecorderDisplayCurrentSingleLightSensorValue(finchRobot, sensorsToMonitor);
                    break;
            }
            Console.ReadKey();
        }

        static int AlarmSystemDisplaySetTimeToMonitor()
        {
            int TimeToMonitor;
            string choice;
            bool exit = false;

            DisplayScreenHeader("Time To Monitor");

            //User input

            Console.Write($"\tTime To Monitor:");
            int.TryParse(Console.ReadLine(), out TimeToMonitor);

            // echo value 

            Console.WriteLine($"\tyour Time to monitor is:{TimeToMonitor}");
            Console.WriteLine();
            //Question user and validate
            do
            {
                Console.WriteLine("\tIs this the correct time?");
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\tY) Yes");
                Console.WriteLine("\tN) No");
                Console.WriteLine("\t--------------------------------");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
                switch (choice)
                {
                    case "y":
                        Console.WriteLine("\tTime value has been confirmed");
                        exit = true;

                        break;

                    case "n":
                        Console.WriteLine("\tPlease re-enter time value");
                        AlarmSystemDisplaySetTimeToMonitor();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                }
            } while (!exit);

            DisplayMenuPrompt("Alarm system");


            return TimeToMonitor;
        }
        static int AlarmSystemDisplaySetMinMaxThresholdValue(string rangeType, Finch finchRobot, string sensorsToMonitor)
        {
            int minMaxThresholdValue;
            string choice;
            bool exit = false;

            DisplayScreenHeader("Min/Maximum Threshold Value");

            DataRecorderDisplayCurrentSingleLightSensorValue(finchRobot, sensorsToMonitor);


            Console.Write($"\tEnter the {rangeType} light sensor value: ");
            int.TryParse(Console.ReadLine(), out minMaxThresholdValue);
            //ehco user respose
            Console.WriteLine($"\tYour {rangeType} light sensor value is {minMaxThresholdValue}.");
            Console.WriteLine();
            do
            {
                //Question and validate
                Console.WriteLine($"\tIs {minMaxThresholdValue} The correct light sensor value");
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\tY) Yes");
                Console.WriteLine("\tN) No");
                Console.WriteLine("\t--------------------------------");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
                switch (choice)
                {
                    case "y":
                        Console.WriteLine("\tValue has been confirmed");
                        exit = true;
                        break;

                    case "n":
                        Console.WriteLine("\tPlease re-enter value for light sensor");
                        AlarmSystemDisplaySetMinMaxThresholdValue(rangeType, finchRobot, sensorsToMonitor);
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                }
            } while (!exit);

            DisplayMenuPrompt("Alarm system");


            return minMaxThresholdValue;
        }

        static string AlarmSystemDisplaySetSensorsToMonitor(Finch finchRobot, string sensorsToMonitor)
        {
            string choice;
            bool exit = false;
            DisplayScreenHeader("Sensors to Monitor");
            //question user on what sensor they want to monitor
            Console.Write("\tSensors to Monitor [left, right, both]:");
            sensorsToMonitor = Console.ReadLine().ToLower();
            Console.WriteLine();
            Console.WriteLine($"\tyour input for Sensors to Monitor is {sensorsToMonitor}.");
            Console.WriteLine();
            DataRecorderDisplayCurrentSingleLightSensorValue(finchRobot, sensorsToMonitor);
            Console.WriteLine();
            do
            {
                //Question and validate
                Console.WriteLine($"\tIs '{sensorsToMonitor}' the correct sensor?");
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\tY) Yes");
                Console.WriteLine("\tN) No");
                Console.WriteLine("\t--------------------------------");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
                switch (choice)
                {
                    case "y":
                        Console.WriteLine("\tSensor has been confirmed");
                        exit = true;

                        break;

                    case "n":
                        Console.WriteLine("\tPlease re-enter sensor");
                        AlarmSystemDisplaySetSensorsToMonitor(finchRobot, sensorsToMonitor);
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                }
            } while (!exit);

            DisplayMenuPrompt("Alarm System");

            return sensorsToMonitor;
        }

        static string AlarmSystemDisplaySetRangeType()
        {
            string choice;
            bool exit = false;
            string rangeType;

            DisplayScreenHeader("Range Type");

            //Gather range type
            Console.Write("\tRange Type [minimum, maximum]:");
            rangeType = Console.ReadLine();
            //ehco range type
            Console.WriteLine($"\tyour range type is:{rangeType}.");
            Console.WriteLine();
            do
            {
                //Question and validate
                Console.WriteLine($"\tIs {rangeType} correct range?");
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\tY) Yes");
                Console.WriteLine("\tN) No");
                Console.WriteLine("\t--------------------------------");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
                switch (choice)
                {
                    case "y":
                        Console.WriteLine("\tSensor has been confirmed");
                        exit = true;

                        break;

                    case "n":
                        Console.WriteLine("\tPlease re-enter sensor");
                        AlarmSystemDisplaySetRangeType();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                }
            } while (!exit);

            DisplayMenuPrompt("Alarm System");

            return rangeType;
        }
        #endregion

        #region UserPrograming
        static void UserProgrammingDisplayMenuScreen(Finch finchRobot)
        {
            string menuChoice;
            bool quitMenu = false;

            // tuple stores all three command parameters   

            (int motorSpeed, int ledBrightness, double waitSeconds) commandParameters;
            commandParameters.motorSpeed = 0;
            commandParameters.ledBrightness = 0;
            commandParameters.waitSeconds = 0;

            // List   
            List<Command> commands = new List<Command>();

            //Prompt for input
            do
            {
                DisplayScreenHeader("User Programming Menu");

                // get user menu choice

                Console.WriteLine("\ta) Set Command Parameters");
                Console.WriteLine("\tb) Add Commands");
                Console.WriteLine("\tc) View Commands");
                Console.WriteLine("\td) Execute Commands");
                Console.WriteLine("\te) Quit");
                Console.Write("\t\tEnter Choice:");
                menuChoice = Console.ReadLine().ToLower();


                // process user menu choice

                switch (menuChoice)
                {
                    case "a":
                        commandParameters = UserProgrammingDisplayGetCommandParameters();
                        break;

                    case "b":
                        UserProgrammingDisplayGetFinchCommands(commands);
                        break;

                    case "c":
                        UserProgrammingDisplayFinchCommands(commands);
                        break;

                    case "d":
                        UserProgrammingDisplayExecuteFinchCommands(finchRobot, commands, commandParameters);
                        break;

                    case "e":
                        quitMenu = true;
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }
            } while (!quitMenu);
            DisplayContinuePrompt();
        }

        /// <summary>
        /// ********************************************************
        /// *       Execute Commands                               *
        /// ********************************************************
        /// </summary>
        /// <param name="finchRobot">Finch robot object</param>
        /// <param name="commands">list of commands</param>
        /// <param name="commandParameters">tuple of command parameters</param>
        static void UserProgrammingDisplayExecuteFinchCommands(Finch finchRobot,
            List<Command> commands,
            (int motorSpeed, int ledBrightness, double waitSeconds) commandParameters)
        {
            int motorSpeed = commandParameters.motorSpeed;
            int ledBrightness = commandParameters.ledBrightness;
            int waitMilliSeconds = (int)(commandParameters.waitSeconds * 1000);
            string commandFeedback = "";
            const int TURNING_MOTOR_SPEED = 100;

            DisplayScreenHeader("Execute Finch Commands");

            Console.WriteLine("\tThe Finch robot is ready to execute the list of commands.");
            DisplayContinuePrompt();

            foreach (Command command in commands)
            {
                switch (command)
                {
                    case Command.NONE:
                        break;

                    case Command.MOVEFORWARD:
                        finchRobot.setMotors(motorSpeed, motorSpeed);
                        commandFeedback = Command.MOVEFORWARD.ToString();
                        break;

                    case Command.MOVEBACKWARD:
                        finchRobot.setMotors(-motorSpeed, -motorSpeed);
                        commandFeedback = Command.MOVEBACKWARD.ToString();
                        break;

                    case Command.STOPMOTORS:
                        finchRobot.setMotors(0, 0);
                        commandFeedback = Command.STOPMOTORS.ToString();
                        break;

                    case Command.WAIT:
                        finchRobot.wait(waitMilliSeconds);
                        commandFeedback = Command.WAIT.ToString();
                        break;

                    case Command.TURNRIGHT:
                        finchRobot.setMotors(TURNING_MOTOR_SPEED, -TURNING_MOTOR_SPEED);
                        commandFeedback = Command.TURNRIGHT.ToString();
                        break;
                    case Command.TURNLEFT:
                        finchRobot.setMotors(TURNING_MOTOR_SPEED, TURNING_MOTOR_SPEED);
                        commandFeedback = Command.TURNLEFT.ToString();
                        break;

                    case Command.CNOTEON:
                        finchRobot.noteOn(160);
                        commandFeedback = Command.CNOTEON.ToString();
                        break;

                    case Command.DNOTEON:
                        finchRobot.noteOn(180);
                        commandFeedback = Command.DNOTEON.ToString();
                        break;

                    case Command.ENOTEON:
                        finchRobot.noteOn(20);
                        commandFeedback = Command.ENOTEON.ToString();
                        break;

                    case Command.FNOTEON:
                        finchRobot.noteOn(210);
                        commandFeedback = Command.FNOTEON.ToString();
                        break;

                    case Command.NOTEOFF:
                        finchRobot.noteOff();
                        commandFeedback = Command.NOTEOFF.ToString();
                        break;

                    case Command.LEDON:
                        finchRobot.setLED(ledBrightness, ledBrightness, ledBrightness);
                        commandFeedback = Command.LEDON.ToString();
                        break;

                    case Command.LEDOFF:
                        finchRobot.setLED(ledBrightness, ledBrightness, ledBrightness);
                        commandFeedback = Command.LEDOFF.ToString();
                        break;

                    case Command.GETTEMPERATURE:
                        GetTemperature(finchRobot);
                        break;

                    case Command.DONE:
                        commandFeedback = Command.DONE.ToString();
                        break;

                    default:

                        break;
                }
            }
        }
        static (int motorSpeed, int ledBrightness, double waitSeconds) UserProgrammingDisplayGetCommandParameters()

        {
            string menuChoice;
            bool quitMenu = false;
            DisplayScreenHeader("Command Parameters");

            (int motorSpeed, int ledBrightness, double waitSeconds) commandParameters;
            commandParameters.motorSpeed = 0;
            commandParameters.ledBrightness = 0;
            commandParameters.waitSeconds = 0;

            GetValidInteger("\tEnter Motor Speed: [1 - 255]:", 1, 255, out commandParameters.motorSpeed);
            GetValidInteger2("\tEnter LED Brightness: [1 - 255]:", 1, 255, out commandParameters.ledBrightness);
            GetValidDouble("\tEnter Wait in Seconds: [1 - 10] ", 0, 10, out commandParameters.waitSeconds);

            Console.WriteLine();
            Console.WriteLine($"\tMotor speed: {commandParameters.motorSpeed}");
            Console.WriteLine($"\tLED brightness: {commandParameters.ledBrightness}");
            Console.WriteLine($"\tWait command duration: {commandParameters.waitSeconds}");
            Console.WriteLine();

            do
            {
                Console.WriteLine("\tAre these the correct settings?");
                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\tY) Yes");
                Console.WriteLine("\tN) No");
                Console.WriteLine("\t--------------------------------");
                menuChoice = Console.ReadLine().ToLower();
                Console.Clear();
                switch (menuChoice)
                {
                    case "y":
                        Console.WriteLine("\tSettings have been confirmed");
                        DisplayContinuePrompt();
                        quitMenu = true;
                        break;

                    case "n":
                        Console.WriteLine("\tPlease re-enter settings");
                        DisplayContinuePrompt();
                        UserProgrammingDisplayGetCommandParameters();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        break;
                }
            } while (!quitMenu);

            DisplayMenuPrompt("User Programming");
            return commandParameters;




        }

        private static int GetValidInteger2(string v1, int v2, int v3, out int ledBrightness)
        {
            Console.WriteLine($"\t{v1}");
            int.TryParse(Console.ReadLine(), out ledBrightness);

            while (ledBrightness < v2 || ledBrightness > v3)
            {
                Console.WriteLine("\tIm sorry, It seems your value was out of range");
                Console.WriteLine();
                Console.WriteLine("\tPlease enter a value between 1 and 250, for led brightness.\n");
                int.TryParse(Console.ReadLine(), out ledBrightness);
            }
            return ledBrightness;
        }

        static double GetTemperature(Finch finchRobot)
        {
            double temperture;
            temperture = finchRobot.getTemperature() * 1.8 + 32;

            Console.WriteLine($"Temperature Reading {temperture}");
            return temperture;
        }

        static double GetValidDouble(string v1, int v2, int v3, out double waitSeconds)
        {
            Console.WriteLine($"\t{v1}");
            double.TryParse(Console.ReadLine(), out waitSeconds);

            while (waitSeconds < v2 || waitSeconds > v3)
            {
                Console.WriteLine("\tIm sorry, It seems your value was out of range");
                Console.WriteLine();
                Console.WriteLine("\tPlease enter a value between 1 and 10, for wait in seconds.\n");
                double.TryParse(Console.ReadLine(), out waitSeconds);
            }
            return waitSeconds;
        }

        private static int GetValidInteger(string v1, int v2, int v3, out int motorSpeed)
        {
            Console.WriteLine($"\t{v1}");
            int.TryParse(Console.ReadLine(), out motorSpeed);

            while (motorSpeed < v2 || motorSpeed > v3)
            {
                Console.WriteLine("\tIm sorry, It seems your value was out of range");
                Console.WriteLine();
                Console.WriteLine("\tPlease enter a value between 1 and 10, for motor speed.\n");
                int.TryParse(Console.ReadLine(), out motorSpeed);
            }
            return motorSpeed;
        }

        /// <summary>
        /// ********************************************************
        /// *       Display Commands                               *
        /// ********************************************************
        /// </summary>
        /// <param name="commands">list of commands</param>

        static void UserProgrammingDisplayFinchCommands(List<Command> commands)
        {
            DisplayScreenHeader("Finch Robot Commands");

            foreach (Command command in commands)
            {
                Console.WriteLine($"\t{command}");
            }
            DisplayMenuPrompt("User Programming");
        }

        static void UserProgrammingDisplayGetFinchCommands(List<Command> commands)
        {
            Command command = Command.NONE;

            DisplayScreenHeader("Finch Robot Commands");


            // list commands

            int commandCount = 1;
            Console.WriteLine("\tList of Available Commands");
            Console.WriteLine();
            Console.Write("\t-");
            foreach (string commandName in Enum.GetNames(typeof(Command)))
            {
                Console.Write($" - {commandName.ToLower()}  -");

                commandCount++;
            }
            Console.WriteLine();

            while (command != Command.DONE)
            {
                Console.Write("\tEnter Command:");

                if (Enum.TryParse(Console.ReadLine().ToUpper(), out command))
                {
                    commands.Add(command);
                }
                else
                {
                    Console.WriteLine("\t\t********************************************");
                    Console.WriteLine("\t\tPlease enter a command from the list above.");
                    Console.WriteLine("\t\t********************************************");
                }

            }
        }
        #endregion

        #region File I/O Theme

        static void DisplaySetTheme()
        {
            (ConsoleColor foregroundColor, ConsoleColor backgroundColor) themeColors;
            bool themeChosen = false;

            //
            // set theme from data
            //
            themeColors = ReadThemeData(); 
            Console.ForegroundColor = themeColors.foregroundColor;
            Console.BackgroundColor = themeColors.backgroundColor;
            Console.Clear();
            DisplayScreenHeader("Set Application Theme");

            Console.WriteLine($"\tCurrent foreground color: {Console.ForegroundColor}");
            Console.WriteLine($"\tCurrent background color: {Console.BackgroundColor}");

            Console.Write("\tWould you like to change the current theme [ yes | no ]?");
            if (Console.ReadLine().ToLower() == "yes")
            { 
                do
                { 
                    themeColors.foregroundColor = GetConsoleColorFromUser("foreground");

                  themeColors.backgroundColor = GetConsoleColorFromUser("background");

                //
                // set new theme
                //
                Console.ForegroundColor = themeColors.foregroundColor;
                Console.BackgroundColor = themeColors.backgroundColor;
                Console.Clear();
                DisplayScreenHeader("Set Application Theme");
                Console.WriteLine($"\tNew foreground color: {Console.ForegroundColor}");
                Console.WriteLine($"\ttNew background color: {Console.BackgroundColor}");

                Console.WriteLine();
                Console.Write("\tIs this the theme you would like?");
                if (Console.ReadLine().ToLower() == "yes") 
                { 
                themeChosen = true;
                WriteThemeData(themeColors.foregroundColor, themeColors.backgroundColor);
                }

                } while (!themeChosen);

            }
            DisplayContinuePrompt();
        }
        static ConsoleColor GetConsoleColorFromUser(string property)
        {
            ConsoleColor consoleColor;
            bool validConsoleColor;

            do
            {
                Console.Write($"\tEnter a value for the {property}:");
                validConsoleColor = Enum.TryParse<ConsoleColor>(Console.ReadLine(), true, out consoleColor);

                if (!validConsoleColor)
                {
                    Console.WriteLine("\n\t It appears you did not provide a valid console color. Please Try again");
                }
                else
                {
                    validConsoleColor = true;
                }

            } while (!validConsoleColor);

            return consoleColor;
        }

        static (ConsoleColor foregroundColor, ConsoleColor backgroundColor) ReadThemeData()
        {
            string dataPath = @"Data/Theme.txt";
            string[] themeColors;

            ConsoleColor foregroundColor;
            ConsoleColor backgroundColor;

            themeColors = File.ReadAllLines(dataPath);

            Enum.TryParse(themeColors[0], true, out foregroundColor);
            Enum.TryParse(themeColors[1], true, out backgroundColor);

            return (foregroundColor, backgroundColor);
        }

        static void WriteThemeData(ConsoleColor foreground, ConsoleColor background)
        {
            string dataPath = @"Data/Theme.txt";

            File.WriteAllText(dataPath, foreground.ToString() + "\n");
            File.AppendAllText(dataPath, background.ToString());
        }

        static string WriteThemeDataExceptions(ConsoleColor foreground, ConsoleColor background)
        {
            string dataPath = @"Data/Theme.txt";
            string fileIOStatusMessage = "";

            try
            {
                File.WriteAllText(dataPath, foreground.ToString() + "\n");
                File.AppendAllText(dataPath, background.ToString());
                fileIOStatusMessage = "Complete";
            }
            catch (DirectoryNotFoundException)
            {
                fileIOStatusMessage = "Unable to locate the folder that holds the data file.";
            }
            catch (Exception)
            {
                fileIOStatusMessage = "Unable to write to data file.";
            }

            return fileIOStatusMessage;
        }
        #endregion

        #region File I/O Login
        static void DisplayLoginRegister()
        {
            DisplayScreenHeader("Login/Register");

            Console.Write("\tAre you a registered user [ yes | no ]?");
            if (Console.ReadLine().ToLower() == "yes")
            {
                DisplayLogin();
            }

            else
            {
                DisplayRegisterUser();
                DisplayLogin();
            }
        }

        static void DisplayRegisterUser()
        {
            string userName;
            string password;
            string choice;
            bool exit = false;

            DisplayScreenHeader("Register");

            Console.Write("\tEnter a user name:");
            userName = Console.ReadLine();
            Console.Write("\tEnter a password:");
            password = Console.ReadLine();

            do
            {
                Console.WriteLine("\tIs this correct?:");
                Console.WriteLine($"\tUser name: {userName}");
                Console.WriteLine($"\tPassword: {password}");

                Console.WriteLine("\t--------------------------------");
                Console.WriteLine("\tY) Yes");
                Console.WriteLine("\tN) No");
                Console.WriteLine("\t--------------------------------");
                choice = Console.ReadLine().ToLower();
                Console.Clear();
                switch (choice)
                {
                    case "y":
                        Console.WriteLine("\tUser and password have been confirmed");
                        exit = true;
                        break;

                    case "n":
                        Console.WriteLine("\tPlease re-enter time value");
                        DisplayRegisterUser();
                        Console.Clear();
                        break;

                    default:
                        Console.WriteLine();
                        Console.WriteLine("\tPlease enter a letter for the menu choice.");
                        DisplayContinuePrompt();
                        Console.Clear();
                        break;
                }
            } while (!exit);

            WriteloginInfoData(userName, password);

            Console.WriteLine();
            Console.WriteLine("\tYou entered the following information and it has be saved.(Remember to write this down)");
            Console.WriteLine($"\tUser name: {userName}");
            Console.WriteLine($"\tPassword: {password}");

            DisplayContinuePrompt();
        }

        static void WriteloginInfoData(string userName, string password)
        {
            string dataPath = @"Data/Logins.txt";
            string loginInfoText;

            loginInfoText = userName + "," + password;

            File.WriteAllText(dataPath, loginInfoText);
        }

        static void DisplayLogin()
        {
            string userName;
            string password;
            bool validLogin;
            string choice;
            bool exit = false;

            do
            {
                DisplayScreenHeader("Login");

                Console.WriteLine();
                Console.Write("\tEnter your user name:");
                userName = Console.ReadLine();
                Console.Write("\tEnter your password:");
                password = Console.ReadLine();

                validLogin = IsValidLoginInfo(userName, password);

                Console.WriteLine();
                if (validLogin)
                {
                    Console.WriteLine("\tYou are now logged in.");
                }
                else
                {
                    Console.WriteLine("\tIt appears either the user name or password is incorrect.");
                    Console.WriteLine("\tWould you like to register an account?");
                    do
                    {
                        Console.WriteLine("\t--------------------------------");
                        Console.WriteLine("\tY) Yes, You would Like to Make an account");
                        Console.WriteLine("\tN) No, you already Have an account");
                        Console.WriteLine("\t--------------------------------");
                        choice = Console.ReadLine().ToLower();
                        Console.Clear();
                        switch (choice)
                        {
                            case "y":
                                DisplayRegisterUser();
                                break;

                            case "n":
                                Console.Clear();
                                exit = true;
                                break;

                            default:
                                Console.WriteLine();
                                Console.WriteLine("\tPlease enter a letter for the menu choice.");
                                DisplayContinuePrompt();
                                Console.Clear();
                                break;
                        }
                    } while (!exit);
                    Console.WriteLine("\tPlease try again.");
                }

                DisplayContinuePrompt();
            } while (!validLogin);
        }

        static bool IsValidLoginInfo(string userName, string password)
        {
            List<(string userName, string password)> registeredUserLoginInfo = new List<(string userName, string password)>();
            bool validUser = false;
            registeredUserLoginInfo = ReadLoginInfoData();

            foreach ((string userName, string password) userLoginInfo in registeredUserLoginInfo)
            {
                if ((userLoginInfo.userName == userName) && (userLoginInfo.password == password))
                {
                    validUser = true;
                    break;
                }
            }
            return validUser;
        }

        static List<(string userName, string password)> ReadLoginInfoData()
        {
            string dataPath = "Data/Logins.txt";

            string[] loginInfoArray;
            (string userName, string password) loginInfoTuple;


            List<(string userName, string password)> registeredUserLoginInfo = new List<(string userName, string password)>();


            loginInfoArray = File.ReadAllLines(dataPath);

            foreach (string loginInfoText in loginInfoArray)
            {

                loginInfoArray = loginInfoText.Split(',');


                loginInfoTuple.userName = loginInfoArray[0];
                loginInfoTuple.password = loginInfoArray[1];


                registeredUserLoginInfo.Add(loginInfoTuple);
            }
            return registeredUserLoginInfo;
        }
        #endregion

        #region FINCH ROBOT MANAGEMENT

        /// <summary>
        /// *****************************************************************
        /// *               Disconnect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        static void DisplayDisconnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            DisplayScreenHeader("Disconnect Finch Robot");

            Console.WriteLine("\tAbout to disconnect from the Finch robot.");
            DisplayContinuePrompt();

            finchRobot.disConnect();

            Console.WriteLine("\tThe Finch robot is now disconnect.");

            DisplayMenuPrompt("Main Menu");
        }

        /// <summary>
        /// *****************************************************************
        /// *                  Connect the Finch Robot                      *
        /// *****************************************************************
        /// </summary>
        /// <param name="finchRobot">finch robot object</param>
        /// <returns>notify if the robot is connected</returns>
        static bool DisplayConnectFinchRobot(Finch finchRobot)
        {
            Console.CursorVisible = false;

            bool robotConnected;

            DisplayScreenHeader("Connect Finch Robot");

            Console.WriteLine("\tAbout to connect to Finch robot. Please be sure the USB cable is connected to the robot and computer now.");
            DisplayContinuePrompt();

            robotConnected = finchRobot.connect();

            if (robotConnected)
            {
                Console.WriteLine("Connect Finch Robot");
                finchRobot.setLED(0, 255, 0);
                finchRobot.noteOn(261);
                finchRobot.wait(1000);
                finchRobot.setLED(0, 0, 0);
                finchRobot.setLED(0, 0, 0);
            }

            // TODO test connection and provide user feedback - text, lights, sounds

            DisplayMenuPrompt("Main Menu");

            //
            // reset finch robot
            //
            finchRobot.setLED(0, 0, 0);
            finchRobot.noteOff();

            return robotConnected;
        }

        #endregion

        #region USER INTERFACE

        /// <summary>
        /// *****************************************************************
        /// *                     Welcome Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayWelcomeScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tFinch Control");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// *****************************************************************
        /// *                     Closing Screen                            *
        /// *****************************************************************
        /// </summary>
        static void DisplayClosingScreen()
        {
            Console.CursorVisible = false;

            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\tThank you for using Finch Control!");
            Console.WriteLine();

            DisplayContinuePrompt();
        }

        /// <summary>
        /// display continue prompt
        /// </summary>
        static void DisplayContinuePrompt()
        {
            Console.WriteLine();
            Console.WriteLine("\tPress any key to continue.");
            Console.ReadKey();
        }

        /// <summary>
        /// display menu prompt
        /// </summary>
        static void DisplayMenuPrompt(string menuName)
        {
            Console.WriteLine();
            Console.WriteLine($"\tPress any key to return to the {menuName} Menu.");
            Console.ReadKey();
        }

        /// <summary>
        /// display screen header
        /// </summary>
        static void DisplayScreenHeader(string headerText)
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("\t\t" + headerText);
            Console.WriteLine();
        }

        #endregion
    }
}

