using System;

namespace SugarCodingExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //SugarCoding Version:

            var answer = 4;
            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} is greater or equal to nine";
            Console.WriteLine(response);


            // Old Version:
            //int answer = 4;
            //string response;

            //if (answer < 9)
            //{
            //    response = answer + " is less than nine";
            //}
            //else
            //{
            //    response = answer + “greater than or equal to nine”;
            //}

        }
    }
}
