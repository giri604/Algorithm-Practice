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
            //Console.Write("Enter the 1st int value: ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the 2nd int value: ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the 3rd int value: ");
            //int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the String value: ");
            string str = Console.ReadLine();
            //int position = Convert.ToInt32(Console.ReadLine());


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
            Console.WriteLine("30th Answer: {0}", BasicAlgorithmExercises.Question30(str));




            Console.ReadKey();
        }
    }
}
