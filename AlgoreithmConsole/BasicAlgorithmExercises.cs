using System;

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
    }
}
