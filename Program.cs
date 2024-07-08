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
            Console.WriteLine("Please input the starting denary number");    //prompts the suer to input the number to be converted to binary
            string striDenaryNum = Console.ReadLine();  //assigns the variable "denaryNum" as user input
            int denaryNum = Convert.ToInt32(striDenaryNum);    //converts user input to an int
            int answer = denaryNum;    //assigns the variable "answer" as 1
            string[] binaryNum = new string[8];    //creates the array "binaryNum" that is is 8 long
            int index = 0;    //assigns the variable "index" as 0
            while (answer > 0)    //inniciates a while loop with the condition that the variable "answer" is greater than -1
            {
                int newAnswer  = (answer / 2);    //assigns the variable "newAnswer" as answer divided by 2 but it excludes any remainder
                int remainder = answer % 2;    //assigns the variable "remainder" as answer divided by 2 but it excludes any remainder
                answer = answer / 2;  //assigns the variable "answer" as answer divided by 2 but it excludes any remainder
                string striRemainder = Convert.ToString(remainder);    //Converts the integer "remainder" to a string and reassigns it at "striRemainder"
                binaryNum[7-index] = striRemainder;    //assigns the value of one of the positions in the string "binaryNum" as striRemainder
                index = index++;    //adds 1 to the variable "index"
            } 
            if (binaryNum[0] == "")    //checks if the first position in the string "binaryNum" is empty"
            {
                binaryNum[0] = "0";    //If it is, it assigns it as "0"
            }
            Console.WriteLine(binaryNum);    //outputs the string "binaryNum"
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

