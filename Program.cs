using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GitTest
{

    
    class Program : Random
    {
        //Seed the RNG
        static Random randInt = new Random(DateTime.Now.Millisecond);
        static int randNum = randInt.Next(1, 101);//Number between 1 and 100, upprt bound is exclusive


        static void Main(string[] args)
        {
           

            Program p = new Program();
            p.guessIt();

        }

        void guessIt()
        {
            int userGuess = -1;
            string tmpString;
            int numTries = 1;

            Console.Write(randNum);
            Console.Write("I'm thinking of a number between 1 and 100. Guess it:");
            
            tmpString = Console.ReadLine();
            Int32.TryParse(tmpString, out userGuess);//Parse the string into an integer.

            while (userGuess != randNum)
            {
                if (userGuess < randNum)
                {
                    Console.WriteLine("Too low, aim higher. ");
                }

                if (userGuess > randNum)
                {
                    Console.WriteLine("Too high, aim lower. ");
                }
                Console.Write("I'm thinking of a number between 1 and 100. Guess it:");
                tmpString = Console.ReadLine();
                Int32.TryParse(tmpString, out userGuess);

                numTries++;
            }

            Console.Write("Good guess! You guessed ");
            Console.Write(numTries);
            Console.WriteLine(" times! Press any key to exit.");
            Console.ReadKey();
            
        }



    }
}
