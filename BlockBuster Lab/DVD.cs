using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBuster_Lab
{
    public class DVD : Movie
    {


        public DVD(string title, Genre category, int runTime, List<string> scenes) : base(title, category, runTime, scenes)
        {
            this.Title = title;
            this.Category = category;
            this.RunTime = runTime;
            this.Scenes = scenes;

        }




        public override void Play()
        {

            do
            {
                PrintScenes();

                Console.WriteLine("What scene you would like to watch ? Select 1 to 4");
                int sceneIndex = int.Parse(Console.ReadLine());

                if (sceneIndex < 0 || sceneIndex >= Scenes.Count)
                {
                    Console.WriteLine("Please try again. Option not available. Please enter an number provided.");
                }
                else
                {
                    Console.WriteLine(sceneIndex + ": " + Scenes[sceneIndex - 1 ]);
                }


            } while (Continue());



        }

        public static bool Continue()
        {
            int attempts = 3;

            while (true)
            {
                if (attempts >= 0)
                {
                    Console.WriteLine("Would you like to continue... yes or no ?");
                    string userInput = Console.ReadLine();

                    if (userInput.StartsWith("y", StringComparison.OrdinalIgnoreCase))
                    {
                        return true;
                    }
                    else if (userInput.StartsWith("n", StringComparison.OrdinalIgnoreCase))
                    {
                        Console.WriteLine("GoodBye");
                        return false;
                    }
                    else
                    {
                        Console.WriteLine("Invalid entry, Please enter y or n");
                        Console.WriteLine($"You have {attempts} attemps remaining");
                        attempts--;
                    }
                }
                else
                {
                    Console.WriteLine("Sorry, you ran out of attempts");
                    Console.WriteLine("GoodBye");
                    return false;
                }
            }
        }
    }
}
