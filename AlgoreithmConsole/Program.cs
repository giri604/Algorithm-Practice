using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoreithmConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program(); //An implicit parameterless Constructor Defined by Compiler.
            program.ComputeTwoInt();
        }

        public void ComputeTwoInt()
        {
            Console.Write("Enter the 1st int value: ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the 2nd int value: ");
            int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the 3rd int value: ");
            //int c = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the String 1 value: ");
            //string str1 = Console.ReadLine();
            //Console.Write("Enter the String 2 value: ");
            //string str2 = Console.ReadLine();
            //Console.Write("Enter the char value: ");
            //char char1 = Convert.ToChar(Console.ReadLine());
            //int position = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the firts numbers separated by white comma: ");
            //int[] numbers1 = Array.ConvertAll(Console.ReadLine().Trim().Split(','), Convert.ToInt32);
            //Console.Write("Enter the number n: ");
            //int n = int.Parse(Console.ReadLine());

            //Console.WriteLine("1st Answer: {0}", BasicAlgorithmExercises.Question1(a, b));
            //Console.WriteLine("2nd Answer: {0}", BasicAlgorithmExercises.Question2(a));
            //Console.WriteLine("3rd Answer: {0}", BasicAlgorithmExercises.Question3(a, b));
            //Console.WriteLine("4th Answer: {0}", BasicAlgorithmExercises.Question4(a));
            //Console.WriteLine("5th Answer: {0}", BasicAlgorithmExercises.Question4(str));
            //Console.WriteLine("6th Answer: {0}", BasicAlgorithmExercises.Question6(str, position));
            //Console.WriteLine("7th Answer: {0}", BasicAlgorithmExercises.Question7(str));
            //Console.WriteLine("8th Answer: {0}", BasicAlgorithmExercises.Question8(str));
            //Console.WriteLine("9th Answer: {0}", BasicAlgorithmExercises.Question9(str));
            //Console.WriteLine("10th Answer: {0}", BasicAlgorithmExercises.Question10(a));
            //Console.WriteLine("11th Answer: {0}", BasicAlgorithmExercises.Question11(str));
            //Console.WriteLine("23th Answer: {0}", BasicAlgorithmExercises.Question23(a, b));
            //Console.WriteLine("26th Answer: {0}", BasicAlgorithmExercises.Question26(str, position));
            //Console.WriteLine("27th Answer: {0}", BasicAlgorithmExercises.Question27(str));
            //Console.WriteLine("28th Answer: {0}", BasicAlgorithmExercises.Question28(str));
            //Console.WriteLine("29th Answer: {0}", BasicAlgorithmExercises.Question29(str));
            //Console.WriteLine("30th Answer: {0}", BasicAlgorithmExercises.Question30(str));
            //Console.WriteLine("31th Answer: {0}", BasicAlgorithmExercises.Question31(str));
            //Console.WriteLine("32th Answer: {0}", BasicAlgorithmExercises.Question32(str, Convert.ToString(position)));
            //Console.WriteLine("33rd Answer: {0}", BasicAlgorithmExercises.Question33(numbers, n));
            //Console.WriteLine("34th Answer: {0}", BasicAlgorithmExercises.Question34(numbers));
            //Console.WriteLine("35th Answer: {0}", BasicAlgorithmExercises.Question35(str1, str2));
            //Console.WriteLine("36th Answer: {0}", BasicAlgorithmExercises.Question36(str1, char1));
            //Console.WriteLine("37th Answer: {0}", BasicAlgorithmExercises.Question37(str1));
            //Console.WriteLine("38th Answer: {0}", BasicAlgorithmExercises.Question38(numbers1));
            // Console.WriteLine("39th Answer: {0}", BasicAlgorithmExercises.Question39(numbers1));
            Console.WriteLine("40th Answer: {0}", BasicAlgorithmExercises.Question40(a, b));



            Console.ReadKey();
        }
    }
}
