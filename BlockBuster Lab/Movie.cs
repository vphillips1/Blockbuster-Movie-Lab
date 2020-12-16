using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBuster_Lab
{
    public abstract class Movie
    {
        public string Title { get; set; }

        public Genre Category { get; set; }

        public int RunTime { get; set; }

       public List<string> Scenes { get; set; } = new List<string>();

        public Movie(string title, Genre category, int runTime, List<string> scenes)
        {
            Title = title;
            Category = category;
            RunTime = runTime;
            Scenes = scenes;

        }
       


        public virtual void PrintInfo()
        {
            Console.WriteLine($"{ Title}\n  {Category}\n  {RunTime} minutes");

        }

        public void PrintScenes()
        {
            int i = 1;
            foreach (var scenes in Scenes)
            {
                Console.WriteLine($"{i} {scenes}");
                i++;
            }

        }

        public abstract void Play();
        


        public enum Genre
        {
            Drama,
            Comedy,
            Horror,
            Romance,
            Action,

        }



    }


   

}

