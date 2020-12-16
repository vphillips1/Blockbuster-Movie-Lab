using System;
using System.Collections.Generic;
using System.Text;

namespace BlockBuster_Lab
{
    public class VHS : Movie
    {

        public int CurrentTime { get; set; }

        public VHS(string title, Genre category, int runTime, List<string> scenes): base( title,  category,  runTime, scenes)
        {
            this.Title = title;
            this.Category = category;
            this.RunTime = runTime;
            this.Scenes = scenes;
            this.CurrentTime = 0;
        }

       

        public override void Play()
        {

            for (int i = 0; i < Scenes.Count; i++)
            {
                Console.WriteLine(Scenes[CurrentTime]);
                CurrentTime++;
            }
            
        }

        public void Rewind()
        {
            CurrentTime = 0;

        }


    }
}
