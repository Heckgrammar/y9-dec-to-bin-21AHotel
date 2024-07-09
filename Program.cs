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
            string striRemainder = "";
            int newAnswer = 0;
            int remainder = 0;
            while (answer > 0)    //inniciates a while loop with the condition that the variable "answer" is greater than -1
            {
                newAnswer = (answer / 2);    //assigns the variable "newAnswer" as answer divided by 2 but it excludes any remainder
                remainder = answer % 2;    //assigns the variable "remainder" as answer divided by 2 but it excludes any remainder
                answer = answer / 2;  //assigns the variable "answer" as answer divided by 2 but it excludes any remainder
                striRemainder = Convert.ToString(remainder);    //Converts the integer "remainder" to a string and reassigns it at "striRemainder"
                binaryNum[7 - index] = striRemainder;    //assigns the value of one of the positions in the string "binaryNum" as striRemainder
                index = index + 1;    //adds 1 to the variable "index"
            }
            Console.WriteLine(binaryNum[0] + binaryNum[1] + binaryNum[2] + binaryNum[3] + binaryNum[4] + binaryNum[5] + binaryNum[6] + binaryNum[7]);    //outputs the string "binaryNum"
            Console.Read();


            //static string DenToBin(int n, int numbase)  //static string means th edata type being returned is a string 
            //den to bin is th e identifier of th esubroutine/funtion/method
            //int n is one of the perametres which is just a variable 
            //int numbase is antoher parametre
            //call the subroutine by using its identifier. e.g DenToBin(13,2)

            {
                //return //value to return goes here

                //static void means the function will not return a value so it does not need a data type 
                //...this function DOES return a value so the method must have a data type
                //static string numberConversion(int number, int numberbase)
                //{
                //    //CODE GOES HERE
                //    string result = Convert.ToString(number + numberbase);
                //    return result; //REMOVE THE RED LINE!
            }
        }
    }
}

