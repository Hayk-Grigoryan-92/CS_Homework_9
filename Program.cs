using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homework9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////  exercices 12 ///////////////////////////

            //1. Write a function that returns the sum of two numbers.
            /*
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
          
            int sum = Sum(num1, num2);
            Console.WriteLine($"Result : {sum}");
            */
            //--------------------------------------------------------------------
            /*
             2. Given a year, return the century it is in. The first century spans from the year 1 up to and including the
            year 100, the second - from the year 101 up to and including the year 200, etc.

                Example

                For year = 1905, the output should be
                solution(year) = 20;
                For year = 1700, the output should be
                solution(year) = 17.
             */
            /*
            int year = int.Parse(Console.ReadLine());
            int result = YearInCentury(year);
            Console.WriteLine($"Century of that year is: {result}");
            */
            //-------------------------------------------------------------------

            /*
                3. Given the string, check if it is a palindrome.

                Example

                For inputString = "aabaa", the output should be
                solution(inputString) = true;
                For inputString = "abac", the output should be
                solution(inputString) = false;
                For inputString = "a", the output should be
                solution(inputString) = true.
             */
            //string name = Console.ReadLine();
            //bool result = IsPolidrome(name);
            //-----------------------------------------------------------------------

            /*
             4. Given an array of strings, return another array containing all of its longest strings.

                Example

                For inputArray = ["aba", "aa", "ad", "vcd", "aba"], the output should be
                solution(inputArray) = ["aba", "vcd", "aba"].
             */

            //string[] arr = { "bob", "nil", "lucy", "babken" };
            //string name = LongestName(arr);
            //Console.WriteLine(name);

            //-------------------------------------------------------------------------

            /*
             5. Ticket numbers usually consist of an even number of digits. A ticket number is considered lucky if the
            sum of the first half of the digits is equal to the sum of the second half.

                Given a ticket number n, determine if it's lucky or not.

                Example

                For n = 1230, the output should be
                solution(n) = true;
                For n = 239017, the output should be
                solution(n) = false.
             */

            //int num = int.Parse(Console.ReadLine());
            //bool result = LuckyTicket(num);
            //Console.WriteLine(result);

            //----------------------------------------------------------------------------------------

            /*
             6. Create a program which asks user for amount of days and prints the total amount of seconds for that amount of days.

                Example print:

                How many days?
                > 2
                172800
                How many days?
                > 7
                604800
             */

            //int userDay = int.Parse(Console.ReadLine());
            //int result = DayAmount(userDay);
            //Console.WriteLine($"{result} seconds for {userDay} day");

            //-------------------------------------------------------------------------------------------------

            /*
             7. Create a program which asks the user for two integers and calculates their sum.
                Remember that the input is a string so you have to convert it to integer!
                Give the first number!
                > 8
                Give the second number!
                > 3
                The sum is 11
                Give the first number!
                > 3
                Give the second number!
                > -1
                The sum is 2
             */

            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int result = SumOfNumbers(num1, num2);
            //Console.WriteLine($"Result: {result}");

            //----------------------------------------------------------------------------------------------------

            /*
             8. Expand a little on the previous exercise. Now create a program which asks for three integers and calculates their sum.
                Give the first number!
                > 3
                Give the second number!
                > -1
                Give the third number!
                > 2
                The sum is 4
             */

            //int num1 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int num2 = int.Parse(Console.ReadLine());
            //int result = SumOf_3_Numbers(num1, num2, num3);
            //Console.WriteLine($"Result: {result}");

            //----------------------------------------------------------------------------------------

            /*
             9. Create a program which asks for a year as an integer. If the integer is less than 1900 output “You’re old”.
                Give your age:
                >1985
                Give your age:
                > 1899
                You're old
             */

            // CheckAge();

            //---------------------------------------------------------------------------------

            /*
             10. Create a program which tells if the given number is positive or not.
                Give a number:
                > 5
                It is positive
                Give a number:
                -2
                It is not positive
             */

            //  IsPositive();

            //-------------------------------------------------------------------------------

            /*
             11. Create a program which tell if the given person is legally adult, in Finland over 18 or not.
                How old are you?
                > 5
                You're under age!
                How old are you?
                > 18
                You're an adult!
             */

            //  IsAdult();

            //---------------------------------------------------------------------------------------------

            /*
             12. Input a number from user and displays power of the number. Ask users to whether continue or not. If user presses 'y' or 'Y' then
                 continue and again accept a number. If a user presses any other characters or numbers then quit. (Use while loop)
             */

            // PowNumber();

            //--------------------------------------------------------------------------------------------------

            /*
             13. Գրել ֆունկցիա, որը որպես պարամետր կստանա թվերի զանգված և թիվ, զանգվածի մեջ փնտրել տվյալ թիվը և վերադարձնել այդ թվի ինդեքսը․
                 եթե այդ թիվը բացակայում է զանգվածում վերադարձնել -1։
             */

            //int[] arr = { 5, 8, 4, 56, 64, 88, 11, 22 };
            //int num = int.Parse(Console.ReadLine());
            //int result = CheckIndex(arr, num);
            //Console.WriteLine($"Result: {result}");

            //---------------------------------------------------------------------------------------------------

            //14․ Գրել ֆունկցիա, որը որպես պարամետր կստանա թվերի զանգված և թիվ, զանգվածի մեջ փնտրել տվյալ թիվը և եթե այդ թիվը առկա է
            //    վերադարձնել true հակառակ դեպքում false. 

            //int[] arr = { 5, 8, 4, 56, 64, 88, 11, 22 };
            //int num = int.Parse(Console.ReadLine());
            //string result = CheckNumber(arr, num);
            //Console.WriteLine($"Result: {result}");


            //////////////////////////////////////////////////      Exercices practic loop      /////////////////////////////////////////////

            //1 Print Numbers from 1 to 100: Write a program that prints numbers from 1 to 100 using a for loop.

            // Print();

            //-----------------------------------------------------------------------------------------------------------

            // 2. Sum of First 50 Natural Numbers:  Use a while loop to find the sum of the first 50 natural numbers.

            //int result = PrintNaturalNumbers();
            //Console.WriteLine(result);

            //----------------------------------------------------------------------------------------------------------

            // 3. Factorial of a Number: Write a program that calculates the factorial of a number using a for loop.

            //int num = int.Parse(Console.ReadLine());
            //int result = FactorialNumber(num);
            //Console.WriteLine(result);

            //--------------------------------------------------------------------------------------------------------------

            // 4. Even and Odd Numbers: Write a program to print all even and odd numbers between 1 and 50 using a for loop.

            //  EvenOddNum();

            //---------------------------------------------------------------------------------------------------------------

            // 5. Reverse a Number:  Use a while loop to reverse the digits of a given number.

            //int num = int.Parse(Console.ReadLine());
            //int result = ReverseNuber(num);
            //Console.WriteLine(result);

            //----------------------------------------------------------------------------------------------------

            // 6. Sum of Digits:  Write a program that calculates the sum of the digits of a number using a while loop

            //int num = int.Parse(Console.ReadLine());
            //int sum = SumOfDigits(num);
            //Console.WriteLine($"Sum = {sum}");

            //------------------------------------------------------------------------------------------------------

            // 7. Fibonacci Series:  Use a for loop to print the first 10 numbers of the Fibonacci series.

            // Fibonacci();


        }

        //1. Write a function that returns the sum of two numbers.

        public static int Sum(int num1, int num2)
        {
            int sum = 0;
            sum = num1 * num2;
            return sum;
        }

        //-----------------------------------------------------------------------

        /*
          2. Given a year, return the century it is in. The first century spans from the year 1 up to and including the
            year 100, the second - from the year 101 up to and including the year 200, etc.
        */

        public static int YearInCentury(int year)
        {
            if (year % 2 == 0)
            {
                return year / 100;
            }

            return year / 100 + 1;
        }

        //  3. Given the string, check if it is a palindrome.

        public static bool IsPolidrome(string name)
        {
            bool flag = true;
            name = name.ToLower();

            for (int i = 0; i < name.Length / 2; i++)
            {
                if (name[i] != name[name.Length - i - 1])
                {
                    flag = false;
                    Console.WriteLine("Name is'nt polidrome");
                    break;
                }
                else
                {
                    Console.WriteLine("Name is polidrome");
                    break;
                }
            }

            return flag;
        }

        //  4. Given an array of strings, return another array containing all of its longest strings.

        public static string LongestName(string[] arr)
        {
            string result = "";
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i].Length > result.Length)
                {
                    result = arr[i];
                }
            }
            return result;
        }

        // 5. Ticket numbers usually consist of an even number of digits. A ticket number is considered lucky if the
        //    sum of the first half of the digits is equal to the sum of the second half.

        public static bool LuckyTicket(int number)
        {
            string strNum = number.ToString();
            if (strNum.Length % 2 != 0)
            {
                return false;
            }
            int left = 0;
            int right = 0;
            int halfLength = strNum.Length / 2;

            for (int i = 0; i < halfLength; i++)
            {
                left += int.Parse(strNum[i].ToString());

                right += int.Parse(strNum[halfLength + i].ToString());
            }
            return left == right;
        }

        // 6. Create a program which asks user for amount of days and prints the total amount of seconds for that amount of days.

        public static int DayAmount(int day) 
        {
            int secondOfDay = day * 24 * 60;

            return secondOfDay;
        }

        //  7. Create a program which asks the user for two integers and calculates their sum.

        public static int SumOfNumbers(int num1, int num2)
        {
            return num1 + num2;
        }

        //8. Expand a little on the previous exercise. Now create a program which asks for three integers and calculates their sum.

        public static int SumOf_3_Numbers(int num1, int num2, int num3)
        {
            return num1 + num2 + num3;
        }

        // 9. Create a program which asks for a year as an integer. If the integer is less than 1900 output “You’re old”.

        public static void CheckAge()
        {
           
            while (true)
            {
                int age = int.Parse(Console.ReadLine());
                if (age < 1900)
                {
                    Console.WriteLine("You’re old");
                    break;
                }
            }
        }

        //10. Create a program which tells if the given number is positive or not.

        public static void IsPositive()
        {

            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num > 0)
                {
                    Console.WriteLine("Number is positive");
                }
                else
                {
                    Console.WriteLine("Number is negative");
                }
            }
        }

        //11. Create a program which tell if the given person is legally adult, in Finland over 18 or not.

        public static void IsAdult()
        {

            while (true)
            {
                Console.WriteLine("Enter your Age");
                int age = int.Parse(Console.ReadLine());
                if (age >= 18)
                {
                    Console.WriteLine("You are adult");
                }
                else
                {
                    Console.WriteLine("You're under age!");
                }
            }
        }

        /*
           12. Input a number from user and displays power of the number. Ask users to whether continue or not. If user presses 'y' or 'Y' then
               continue and again accept a number. If a user presses any other characters or numbers then quit. (Use while loop)
           */

        public static void PowNumber()
        {

            while (true)
            {
                Console.WriteLine("Enter a number");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine(Math.Pow(num, 2));
                Console.Write("enter a symbol: ");
                char x = char.Parse(Console.ReadLine());
                if (x == 'y' || x == 'Y')
                {
                    break;
                }
            }
        }

        /*
          13. Գրել ֆունկցիա, որը որպես պարամետր կստանա թվերի զանգված և թիվ, զանգվածի մեջ փնտրել տվյալ թիվը և վերադարձնել այդ թվի ինդեքսը․
                 եթե այդ թիվը բացակայում է զանգվածում վերադարձնել -1։
        */

        public static int CheckIndex(int[] arr, int num)
        {
            for (int i = 0; i < arr.Length; i++) 
            {
                if (arr[i] == num)
                {
                    return i;
                }
            }

            return -1;
        }

        //14․ Գրել ֆունկցիա, որը որպես պարամետր կստանա թվերի զանգված և թիվ, զանգվածի մեջ փնտրել տվյալ թիվը և եթե այդ թիվը առկա է
        //    վերադարձնել true հակառակ դեպքում false. 

        public static string CheckNumber(int[] arr, int num)
        {
            string result = "False";
            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == num)
                {
                    result = "true";
                    return result;
                }
            }

            return result;
        }

        //////////////////////////////////////////////////      Exercices practic loop      /////////////////////////////////////////////   

        //1 Print Numbers from 1 to 100: Write a program that prints numbers from 1 to 100 using a for loop.

        public static void Print()
        {
            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        // 2. Sum of First 50 Natural Numbers:  Use a while loop to find the sum of the first 50 natural numbers.

        public static int PrintNaturalNumbers()
        {
            int x = 0;
            for (int i = 1; i <= 50; i++)
            {
               x += i;
            }
            return x;
        }

        // 3. Factorial of a Number: Write a program that calculates the factorial of a number using a for loop.

        public static int FactorialNumber(int num)
        {
            int result = 1;
            for(int i = 1; i <= num; i++)
            {
                result *= i;
            }
            return result;
        }

        // 4. Even and Odd Numbers: Write a program to print all even and odd numbers between 1 and 50 using a for loop.

        public static void EvenOddNum()
        {
            int[] evenArr = new int [25];
            int[] oddArr = new int[25];
            int even_i = 0;
            int odd_i = 0;
            for (int i = 1; i <= 50; i++)
            {
                if(i % 2 == 0)
                {
                    evenArr[even_i] = i;
                    even_i++;
                }
                else
                {
                    oddArr[odd_i] = i;
                    odd_i++;
                }
            }
            Console.Write("Even numbers");
            for (int i = 0; i < evenArr.Length; i++)
            {
                Console.Write(" " +  evenArr[i]);
            }
            Console.WriteLine();
            Console.Write("Odd numbers");

            for (int i = 0; i < oddArr.Length; i++)
            {
                Console.Write(" " + oddArr[i]);
            }
        }

        // 5. Reverse a Number:  Use a while loop to reverse the digits of a given number.

        public static int ReverseNuber(int num)
        {
           string strNum = num.ToString();
            string newString = "";
            int revNum = 0;
            for(int i = strNum.Length-1; i >= 0; i--)
            {
                newString += strNum[i];
            } 

            revNum = int.Parse(newString);
            return revNum;
        }

        // 6. Sum of Digits:  Write a program that calculates the sum of the digits of a number using a while loop

        public static int SumOfDigits(int num)
        {
            string strNum = num.ToString();
            int newNum = 0;
            int strToNum = 0;
            for (int i = 0; i < strNum.Length; i++)
            {
                strToNum = int.Parse(strNum[i].ToString());
                newNum += strToNum;
            }

           
            return newNum;
        }

        // 7. Fibonacci Series:  Use a for loop to print the first 10 numbers of the Fibonacci series.

        public static void Fibonacci()
        {
            int num1 = 0;
            int num2 = 1;
            int numToPrint = 0;

            for (int i = 0; i < 10; i++)
            {
                if (i < 1)
                {
                    Console.Write(num1);
                    Console.Write(num2);
                }
                else
                {
                    numToPrint = num1 + num2;
                    Console.Write(numToPrint);
                    num1 = num2;
                    num2 = numToPrint;
                   
                }  
            }

        }

    }
}
