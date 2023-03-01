using System;
using System.Collections.Generic;

// Every class in the program is defined within the "Quest" namespace
// Classes within the same namespace refer to one another without a "using" statement
namespace Quest
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a few challenges for our Adventurer's quest
            // The "Challenge" Constructor takes three arguments
            //   the text of the challenge
            //   a correct answer
            //   a number of awesome points to gain or lose depending on the success of the challenge
            Challenge twoPlusTwo = new Challenge("2 + 2?", 4, 10);
            Challenge theAnswer = new Challenge(
                "What's the answer to life, the universe and everything?", 42, 25);
            Challenge whatSecond = new Challenge(
                "What is the current second?", DateTime.Now.Second, 50);
            Challenge sphinxRiddle = new Challenge("If a man has four legs in the morning and two at noon, how many does he have at night?", 3, 25);
            Challenge twoTimesTwo = new Challenge("2 x 2?", 4, 10);
            Challenge howManyFingers = new Challenge("How many fingers does my hand have?", 5, 20);
            Challenge howOld = new Challenge("How old am I?", 19, 20);
            Challenge howManyPoints = new Challenge("How many points do you think you have?", 0, 20);

            int randomNumber = new Random().Next() % 10;
            Challenge guessRandom = new Challenge("What number am I thinking of?", randomNumber, 25);

            Challenge favoriteBeatle = new Challenge(
                @"Who's your favorite Beatle?
    1) John
    2) Paul
    3) George
    4) Ringo
",
                4, 20);

            // List of all challenges
            List<Challenge> allChallenges = new List<Challenge>()
            {
                twoPlusTwo,
                theAnswer,
                whatSecond,
                sphinxRiddle,
                twoPlusTwo,
                howManyFingers,
                howOld,
                howManyPoints,
                guessRandom,
                favoriteBeatle
            };

            // "Awesomeness" is like our Adventurer's current "score"
            // A higher Awesomeness is better

            // Here we set some reasonable min and max values.
            //  If an Adventurer has an Awesomeness greater than the max, they are truly awesome
            //  If an Adventurer has an Awesomeness less than the min, they are terrible
            int minAwesomeness = 0;
            int maxAwesomeness = 100;

            bool Repeat = false;

            Console.WriteLine("What is your name, adventurer? :");
            string adventurerName = Console.ReadLine();
            Adventurer theAdventurer = new Adventurer(adventurerName, new Robe(), new Hat());
            Console.WriteLine();
            do
            {
                // Make a new "Adventurer" object using the "Adventurer" class
                // Get the user's choice for what they want their adventurer to be named

                Console.WriteLine(theAdventurer.GetDescription());
                Console.WriteLine();

                // A list of challenges for the Adventurer to complete
                // Note we can use the List class here because have the line "using System.Collections.Generic;" at the top of the file.
                List<Challenge> challenges = new List<Challenge>();

                //Select 5 random challenges for our Adventurer to complete, add them to the challenges list above.
                List<int> indexes = new List<int>();

                for (int i = 0; i < 5; i++)
                {
                    int index = randomNum(0, allChallenges.Count);
                    if (!indexes.Contains(index))
                    {
                        indexes.Add(index);
                    }
                }

                foreach (int index in indexes)
                {
                    challenges.Add(allChallenges[index]);
                }

                // Loop through all the challenges and subject the Adventurer to them
                foreach (Challenge challenge in challenges)
                {
                    challenge.RunChallenge(theAdventurer);
                }

                // This code examines how Awesome the Adventurer is after completing the challenges
                // And praises or humiliates them accordingly
                if (theAdventurer.Awesomeness >= maxAwesomeness)
                {
                    Console.WriteLine("YOU DID IT! You are truly awesome!");
                }
                else if (theAdventurer.Awesomeness <= minAwesomeness)
                {
                    Console.WriteLine("Get out of my sight. Your lack of awesomeness offends me!");
                }
                else
                {
                    Console.WriteLine("I guess you did...ok? ...sorta. Still, you should get out of my sight.");
                }

                // Show prize

                Prize adventurePrize = new Prize("A golden trophy that shines brighter than the sun");

                adventurePrize.ShowPrize(theAdventurer);

                // Repeat the adventure if the user wants
                Console.WriteLine();
                Console.WriteLine("Would you like to start the adventure over? : (Y/N)");
                string startOver = Console.ReadLine();

                if (startOver == "Y" || startOver == "y")
                {
                    Repeat = true;
                    Console.WriteLine();
                }
                else
                {
                    Repeat = false;
                }
            }
            while (Repeat);
        }

        public static int randomNum(int min, int max)
        {
            int rand = new Random().Next(min, max);
            return rand;
        }
    }
}