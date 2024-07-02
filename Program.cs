using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Y9_DEC_TO_BIN_SKELETON
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //STARTER: Practice using breakpoints and the watch window (F8 to single-step, F11 to start in single step mode)
            //int myInt = 0; //just for testing single stepping
            //string myString = "12"; //watch me being cast from string to int
            //int myStringAsInt = Convert.ToInt32(myString); //watch me cast from string to int

            ////convert integer to string
            //string myIntAsString = Convert.ToString(myInt);
            //Console.WriteLine(myIntAsString);


            ////Insert a string at the start of another string
            //string myCombinedString = myIntAsString + myString;
            //Console.WriteLine(myCombinedString);

            //Console.Read();


            //MAIN:  NUMBER CONVERSION PROGRAM

            //CODE GOES HERE
            Console.WriteLine("Please input th estarting denary number");    //prompts the suer to input the number to be converted to binary
            string striDenaryNum = Console.ReadLine();  //assigns the variable "denaryNum" as user input
            int denaryNum = Convert.ToInt32(striDenaryNum);    //converts user input to an int
            int answer = 1;    //assigns the variable "answer" as 1
            string[] binaryNum = {"", "", "", "", "", "", "", ""};    //creates the array "binaryNum" but it has 8 blank spaces
            int index = 0;    //assigns the variable "index" as 0
            while (answer > -1)    //inniciates a while loop with the condition that the variable "answer" is greater than -1
            {
                answer = (denaryNum / 2);    //reassigns the variable "answer" as denaryNum divided by 2 but it excludes any remainder
                int remainder = denaryNum % 2;    //assigns the variable "remainder" as the remainder of denaryNum divided by 2
                string striRemainder = Convert.ToString(remainder);    //Converts the integer "remainder" to a string and reassigns it at "striRemainder"
                binaryNum[8-1-index] = striRemainder;    //assigns th
                index = index++;
            }
            Console.WriteLine(binaryNum);
            Console.Read();
        }
        //}

        //static void means the function will not return a value so it does not need a data type 
        //...this function DOES return a value so the method must have a data type
        //static string numberConversion(int number, int numberbase)
        //{
        //    //CODE GOES HERE
        //    string result = Convert.ToString(number + numberbase);
        //    return result; //REMOVE THE RED LINE!
        }
   }

