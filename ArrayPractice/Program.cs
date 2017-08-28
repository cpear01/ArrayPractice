using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring an array
            //DataType[] nameOfArray = { elements};     
            int[] myArray = { 1, 2, 3, 4, 5, 6 };   // initilizing an array, type: int  name:myArray value: 1 2 3 4 5 6
            string[] myStudents = { "Brad", "Amy", "Jackie", "Ric", "Mike" };
            //0       1       2        3      4
            //Console.WriteLine(myStudents[4]);   //print out Mike's name
            //Console.WriteLine(myStudents[0]);   //print out Brad's name
            //cannot go out of the range - can't use 5, since there is not an item for 5, stops at Mike [4]
            //can loop the array if you wanted to print out 1,000,000

            //In class PRACTICE problems on my own:
            //#1 Create an array of vacation spots (Top 10), print 1st and last vacation spots
            string[] vacationSpots = { "Jamaica", "Hawaii", "South Korea", "Italy", "France", "South Carolina", "California", "DisneyLand", "Maine", "New York City" };
            Console.WriteLine(vacationSpots[0]); //Jamaica
            Console.WriteLine(vacationSpots[9]); //New York
            //2nd way:
            Console.WriteLine(vacationSpots[vacationSpots.Length - 1]); //Length-1 - this is another way that gives you the last one in the array

            //#2 ages of 3 children, print out each child's age
            int[] ages = { 21, 2, 4 };
            Console.WriteLine("Kayla is " + ages[0]);
            Console.WriteLine("Kayden is " + ages[1]);
            Console.WriteLine("Autumn is " + ages[2]);

            //#3 GPA on a 4.0 scale of 8 students
            //default value of a float is 0
            float[] gpa = new float[8];   // we know there are going to 8 spots, 
            //but don't know the elements - this is DECLARING an array when you don't know what's going to be put inside it
            //we don't know what the GPAs are going to be yet
            //When you don't know the elemets of your array up front
            //datatype[] nameOfArray = new dataType[#ofElements];
            //Keyword: NEW is a reference type; it points to a place in memory
            //value types: integers, floats, decimals, doubles, char
            //reference types: arrays, strings
            //arrays are good when you know the lengths
            //AFTER you know the GPAs:
            gpa[0] = 4.0f;
            gpa[1] = 3.5f;
            //continue up to 8 places

            //#4 - Print out the 1st letter of your peer's names who are sitting next to you
            char[] letter = { 'b', 's', 's' };
            Console.WriteLine(letter);  //prints: bss    only works cuz it's a char, can't do it if it's a STRING!
            Console.WriteLine(ages);  // since this is string it prints out: System.Int32[]  (runtime error)

            //#5 Declare & initalize an array for the days of the week
            string[] daysOfTheWeek = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
            //this is printing an error for some reason

            //#6 Declare & initalize an array of student ages using the NEW keyword
            int[] studentAge = new int[3];
            studentAge[0] = 15;
            studentAge[1] = 25;
            studentAge[2] = 28;
            Console.WriteLine(daysOfTheWeek.Length); //7
            Console.WriteLine(daysOfTheWeek[0]);
            //some arrays have built in methods, like SetValue
            daysOfTheWeek.SetValue("Funday", 0);
            Console.WriteLine(daysOfTheWeek[0]); //changed Monday to Funday 

            //we could have used an array in the ROYGBIV section of Fortune Teller project

            //index of & LastIndexOf
            string[] birthMonths = { "Decemember", "July", "May", "July" };   //July is in twice
            Console.WriteLine(Array.IndexOf(birthMonths, "July"));  //we are looking for July  //prints:1   IndexOf returns 1st instance of July
            Console.WriteLine(Array.LastIndexOf(birthMonths, "July")); //prints: 3   LastIndexOf returns last instance of July

            int[] numbers = { 2, 3, 5, 8, 10, -2, 4, 897, 0 };
            //                0  1  2  3  4    5  6   7   8
            Console.WriteLine(numbers[0]); //prints: 2   this prints the first number
            Array.Reverse(numbers);
            Console.WriteLine(numbers[0]); //prints: 0   this reverses the order and gives us the last number
            Array.Sort(numbers);
            Console.WriteLine(numbers[numbers.Length - 1]); //prints 897  gives us the largest number
            //Array.Sort can be usesd on strings - lower case comes before capital


            //Declare and initialize a string array of first names. Choose a name to find and print the IndexOf.
            string[] firstName = { "Colleen", "Karen", "Elizabeth", "Ian" };
            //            0         1          2          3               
            Console.WriteLine(firstName[3]);   //prints Ian

            //Create an array of lucky numbers. Each number should repeat at least once. 
            //Choose a lucky number, find and print the last index of it.
            int[] luckyNumber = { 8, 2, 22, 25, 1, 16 };
            Console.WriteLine(luckyNumber[2]);

            //Create an array of alphabet characters. Print the first index of the array. Now reverse the array and print the first index.
            char[] alphaCharacter = { 'c', 'd', 'k', 'i', 'h'};
            //                         0    1    2    3
            Console.WriteLine(alphaCharacter[1]);  //prints d
            Array.Reverse(alphaCharacter);
            Console.WriteLine(alphaCharacter[1]);  //prints i

            //Create an array of student names in random order. 
            //Order the students’ names using the sort method. Print the first and last students’ names.
            string[] studentNames = { "Colleen", "Karen", "Elizabeth", "Ian" };
            Array.Sort(studentNames);
            Console.WriteLine(studentNames[0]); //prints: Colleen
            Console.WriteLine(studentNames[3]); //prints: Karen      sorts alphabetically: Colleen, Elizabeth, Karen, Ian

            //Ask 10 people for their favorite numbers and create an array of those numbers. 
            //Order the numbers using the sort method. Print the first and last numbers.
            int[] favNumbers = { 8, 2, 22, 25, 1, 16 };
            Array.Sort(favNumbers);
            Console.WriteLine(favNumbers[0]);  //prints: 1
            Console.WriteLine(favNumbers[5]);  //prints: 25
        










            //#7 






        }
    }
}
