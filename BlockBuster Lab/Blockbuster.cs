using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBuster_Lab
{
   public class Blockbuster
   {
       public List<Movie> Movies { get; set; } = new List<Movie>();
       

        public Blockbuster()
        {
            Movies.Add(new DVD("About Last Night", Movie.Genre.Comedy,130, new List<string>() { "Scene 1: The guys meet up to have a drink at the bar.", "Scene 2: Danny asked to see if Debbie wanted to have a date", "Scene 3: Started to fall in love and asked her to live with him ", "Scene 4: They get back together after a bad argument" }));
            Movies.Add(new DVD("The Notebook", Movie.Genre.Romance, 120, new List<string>() { "Scene 1: Meeting his love at the carnival.", "Scene 2: Falling in love", "Scene 3: I want no one else but you ", "Scene 4: Together forever"}));
            Movies.Add(new DVD("The Grudge", Movie.Genre.Horror, 125, new List<string>() { "Scene 1: A curse that will never end", "Scene 2: Living in the haunted house", " Scene 3: Never going back ", " Scene: 4 Staying strong "}));
            Movies.Add(new VHS("Intruder", Movie.Genre.Drama, 123, new List<string>() { "Scene 1: Buying their first home", "Scene 2: He does not own this home anymore ", " Scene 3: Scott and Annie get suspicious of Charlie", "Scene 4: Time to take action in my own hands" }));
            Movies.Add(new VHS("Madea's Big Happy Family", Movie.Genre.Comedy, 145, new List<string>() {" Scene 1: Family not getting together well ", " Scene 2: Bringing the family together" , " Scene 3: Family secrets start to unfold", " Scene 4 : A family has issues that needs to be solved by Madea"}));
            Movies.Add(new VHS("The Lost World", Movie.Genre.Action, 140, new List<string> {"Scene 1: Traveling to the mysterious island", "Scene 2: Lost in the woods" , "Scene 3: Fight and Flight" , "Scene 4: The Escape "}));
        }
      




        public void PrintMovies()
        {
            Console.WriteLine("\n Here are the available movies");
            for (int i = 0; i < Movies.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {Movies[i].Title}");
            }
          

        }

        public Movie CheckOut()
        {
            const int indexOffset = 1;

            PrintMovies();
            Movie output;

            while (true)
            { 
                Console.WriteLine("Which movie would you like to check out?");
                string userInput = Console.ReadLine();
                int index = int.Parse(userInput);

                index -= indexOffset;

                if(index < 0 || index >= Movies.Count)
                {
                    Console.WriteLine("Option not available. Please choose an option above");

                }
                else
                {

                    output = Movies[index];
                    break;
                }
               
            }
            return output;

            

        }

   }
}
