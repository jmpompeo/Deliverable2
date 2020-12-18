using System;

namespace Deliverable2
{
    class Program
    {


        static void Main(string[] args)
        {



            string headsOrTails; // user input
            string numberOfFlips;
            int heads = 0, tails = 0;
            int correctCount = 0;





            Console.WriteLine("Guess which will have more, heads or tails?: ");
            headsOrTails = Console.ReadLine();

            Console.WriteLine("How many times should we flip the coin?: ");
            numberOfFlips = Console.ReadLine();


            int flips = Int32.Parse(numberOfFlips);


            // Create random number 
            Random rndGuess = new Random();




            do
            {
                int compChoice = rndGuess.Next(0, 2);


                if (compChoice == 0)
                {

                    Console.WriteLine("\nheads");
                    heads++;
                    correctCount++;


                }
                else if (compChoice == 1)
                {

                    Console.WriteLine("\ntails");
                    tails++;
                    correctCount++;


                }


            }
            while ((correctCount < flips) && (flips > correctCount));

            // look at this


            int totalHeadsFlips = heads * 100 / flips;
            int totalTailsFlips = tails * 100 / flips;

            if (headsOrTails == "heads")
            {
                Console.WriteLine("\nYour guess, heads " + " came up " + heads + " times.");
                Console.WriteLine("That's " + totalHeadsFlips + "%.");

            }

            if (headsOrTails == "tails")
            {
                Console.WriteLine("\nYour guess, tails " + " came up " + tails + " times.");
                Console.WriteLine( "That's " + totalTailsFlips + "%.");

            }





            




            Console.ReadKey();





           









        }
    }
}
