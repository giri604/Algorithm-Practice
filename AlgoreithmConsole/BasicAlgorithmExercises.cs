﻿using System;
using System.Linq;

namespace AlgoreithmConsole
{
    class BasicAlgorithmExercises
    {
        /// <summary>
        /// Compute the sum of the two given integer values. If the two values are the same, then return triple their sum.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>int</returns>
        public static int Question1(int a, int b)
        {
            return a == b ? (a + b) * 3 : a + b;
        }

        /// <summary>
        /// Program to get the absolute difference between n and 51. If n is greater than 51 return triple the absolute difference.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>int</returns>
        public static int Question2(int a)
        {
            return a > 51 ? Math.Abs(a - 51) * 3 : Math.Abs(a - 51);
        }

        /// <summary>
        /// Program to check two given integers, and return true if one of them is 30 or if their sum is 30.
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>bool</returns>
        public static bool Question3(int a, int b)
        {
            return a == 30 || b == 30 || (a + b) == 30 ? true : false;
        }

        /// <summary>
        /// Program to check a given integer and return true if it is within 10 of 100 or 200.
        /// </summary>
        /// <param name="a"></param>
        /// <returns>int</returns>
        public static bool Question4(int a)
        {
            return (a - 100) <= 10 || (a - 200) <= 10 ? true : false;
        }

        /// <summary>
        /// program to create a new string where 'if' is added to the front of a given string. If the string already begins with 'if', 
        /// return the string unchanged.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string</returns>
        public static string Question5(string str)
        {
            return str.ToLower().Substring(0, 2).Contains("if") ? str : "if " + str;
        }

        /// <summary>
        /// Program to remove the character in a given position of a given string. The given position will be in the range 0.. string length -1 inclusive.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string</returns>
        public static string Question6(string str, int position)
        {
            return position < str.Length && position >= 0 ? str.Remove(position, 1) : "Specified lenght is out of input string lenght";
        }

        /// <summary>
        /// Program to exchange the first and last characters in a given string and return the new string.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="position"></param>
        /// <returns>string</returns>
        public static string Question7(string str)
        {
            return str.Length > 1 ? str.Substring(str.Length - 1, 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }

        /// <summary>
        /// Program to create a new string which is 4 copies of the 2 front characters of a given string. If the given string length 
        /// is less than 2 return the original string.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="position"></param>
        /// <returns>string</returns>
        public static string Question8(string str)
        {
            return str.Length > 2 ? str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) + str.Substring(0, 2) : str;
        }

        /// <summary>
        /// Program to create a new string with the last char added at the front and back of a given string of length 1 or more.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>String</returns>
        public static string Question9(string str)
        {
            return str.Length >= 1 ? str.Substring(str.Length - 1, 1) + str + str.Substring(str.Length - 1, 1) : str;
        }

        /// <summary>
        /// program to check if a given positive number is a multiple of 3 or a multiple of 7
        /// </summary>
        /// <param name="str"></param>
        /// <returns>String</returns>
        public static bool Question10(int number)
        {
            return (number % 3 == 0) || (number % 7 == 0) ? true : false;
        }

        /// <summary>
        /// Program to create a new string taking the first 3 characters of a given string and return the string with the 3 characters 
        /// added at both the front and back. If the given string length is less than 3, use whatever characters are there.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>String</returns>
        public static string Question11(string str)
        {
            return str.Length > 3 ? str.Substring(0, 3) + str + str.Substring(0, 3) : str + str + str;
        }

        /// <summary>
        /// Program to check two given integers whether either of them is in the range 100..200 inclusive.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>Bool</returns>
        public static bool Question14(int x, int y)
        {
            return (x >= 100 && x <= 200) || (y >= 100 && y <= 200) ? true : false;
        }

        /// <summary>
        /// Program to check the largest number among three given integers.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns>int</returns>
        public static int Question18(int x, int y, int z)
        {
            var max = Math.Max(x, Math.Max(y, z));
            return max;
        }

        /// <summary>
        /// Program to check which number nearest to the value 100 among two given integers. Return 0 if the two numbers are equal.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>int</returns>
        public static int Question19(int x, int y)
        {

            return x == y ? 0 : ((x % 100) > (y % 100) ? x : y);

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public static int Question21(int x, int y)
        {

            return (x >= 20 && x <= 30) || (y >= 20 && y <= 30) ? (x > y ? x : y) : 0;

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>bool</returns>
        public static bool Question23(int x, int y)
        {

            return (x % 10) == (y % 10) ? true : false;

        }

        /// <summary>
        /// Program to create a new string which is n (non-negative integer) copies of the the first 3 characters 
        /// of a given string. If the length of the given string is less than 3 then return n copies of the string.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="copies"></param>
        /// <returns>string</returns>
        public static string Question26(string str, int copies)
        {
            string result = string.Empty;
            if (str.Length >= 3)
            {
                for (int i = 1; i <= copies; i++)
                {
                    result += str.Substring(0, 3);
                }
            }
            else
            {
                for (int i = 1; i <= copies; i++)
                {
                    result += str;
                }
            }
            return result;
        }

        /// <summary>
        /// program to count the string "aa" in a given string and assume "aaa" contains two "aa".
        /// </summary>
        /// <param name="str"></param>
        /// <returns>int</returns>
        public static int Question27(string str)
        {
            int count = 0;
            if (str.Length > 2)
            {
                for (int i = 0; i < str.Length - 1; i++)
                {
                    if (str.Substring(i, 2) == "aa")
                    {
                        count++;
                    }
                }
            }
            return count;

        }

        /// <summary>
        /// program to check if the first appearance of "a" in a given string is immediately followed by another "a". 
        /// </summary>
        /// <param name="str"></param>
        /// <returns>bool</returns>
        public static bool Question28(string str)
        {
            bool result = false;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i].Equals('a'))           //if (str.Substring(i, 1) == "a")
                {
                    if (str.Substring(i + 1, 1) == "a")
                    {
                        result = true;
                        break;
                    }
                    else
                    {
                        result = false;
                        break;
                    }
                }

            }
            return result;
        }

        /// <summary>
        /// Program to create a new string made of every other character starting with the first from a given string.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string</returns>
        public static string Question30(string str)
        {
            string result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                result += str.Substring(0, i + 1);
            }
            return result;
        }

        /// <summary>
        /// program to count a substring of length 2 appears in a given string and also as the last 2 characters of the string. 
        /// Do not count the end substring.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>int</returns>
        public static int Question31(string str)
        {
            string lastTwoCharsString = str.Substring(str.Length - 2);
            int count = 0;
            for (int i = 0; i < str.Length - 2; i++)
            {
                if (str.Substring(i, 2).Equals(lastTwoCharsString))
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Program to check a specified number is present in a given array of integers.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="stringToCheck"></param>
        /// <returns>bool</returns>
        public static bool Question32(string str, string stringToCheck)
        {
            string[] strArray = str.Split(',');

            return strArray.Contains(stringToCheck) ? true : false;
        }

        /// <summary>
        /// Program to check if one of the first 4 elements in an array of integers is equal to a given element.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="n"></param>
        /// <returns>bool</returns>
        public static bool Question33(int[] numbers, int n)
        {
            int[] filteredNumbers = numbers.Take(4).ToArray();
            return filteredNumbers.Contains(n) ? true : false;
        }

        /// <summary>
        /// Program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>bool</returns>
        public static bool Question34(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if ((numbers[i] == 1) && (numbers[i + 1] == 2) && (numbers[i + 2] == 3))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Program to compare two given strings and return the number of the positions where they contain the same length 2 substring.
        /// </summary>
        /// <param name="str"></param>
        /// <param name="position"></param>
        /// <returns></returns>
        public static int Question35(string str1, string str2)
        {
            int count = 0;
            for (int i = 0; i < str1.Length - 1; i++)
            {
                string firstString = str1.Substring(i, 2);
                for (int j = 0; j < str2.Length - 1; j++)
                {
                    string secondString = str2.Substring(j, 2);
                    if (firstString.Equals(secondString))
                    {
                        count++;
                    }
                }
            }
            return count;
        }

        /// <summary>
        /// Program to create a new string from a give string where a specified character have been removed except starting and 
        /// ending position of the given string.
        /// </summary>
        /// <param name="str1"></param>
        /// <param name="str2"></param>
        /// <returns>string</returns>
        public static string Question36(string str1, char char1)
        {
            string filteredString = str1.Substring(1, str1.Length - 2);

            if (filteredString.Contains(char1))
            {
                filteredString = filteredString.Replace(Convert.ToString(char1), string.Empty);
            }

            return str1.Substring(0, 1) + filteredString + str1.Substring(str1.Length - 1, 1);

        }

        /// <summary>
        /// Program to create a new string of the characters at indexes 0,1, 4,5, 8,9 ... from a given string.
        /// </summary>
        /// <param name="str"></param>
        /// <returns>string</returns>
        public static string Question37(string str)
        {
            //int[] index;
            string result = string.Empty;
            for(int i = 0; i < str.Length; i = i + 4)  //photo p-0 h-1 o-2 t-3 o-4 we are skipping index of 2 and 3
            {
                int c = i + 2; // index values picker
                int n = 0; 
                n += c > str.Length ? 1 : 2; //if string length is inclusive to given index range then take 2 else take 1 i.e last character. 
                result += str.Substring(i, n);
            }
            return result;
        }

        /// <summary>
        /// Program to count the number of two 5's are next to each other in an array of integers. 
        /// Also count the situation where the second 5 is actually a 6.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>int</returns>
        public static int Question38(int[] numbers)
        {
            int count = 0;
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i].Equals(5) && (numbers[i + 1].Equals(5) || numbers[i + 1].Equals(6)))
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// Program to check if a triple is presents in an array of integers or not. 
        /// If a value appears three times in a row in an array it is called a triple.
        /// </summary>
        /// <param name="numbers"></param>
        /// <returns>bool</returns>
        public static bool Question39(int[] numbers)
        {
            for(int i = 0; i < numbers.Length - 1; i++)
            {
                if(numbers[i].Equals(numbers[i + 1]) && numbers[i].Equals(numbers[i + 2]))
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns>int</returns>
        public static int Question40(int x, int y)
        {
            int sum = Math.Abs(x + y);
            return sum >= 10 && sum <= 20 ? 30 : sum;
        }


    }
}
