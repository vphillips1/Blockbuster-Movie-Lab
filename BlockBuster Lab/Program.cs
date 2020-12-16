using System;

namespace BlockBuster_Lab
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to V's BlockBuster Movie!");

            Blockbuster vBlockBuster = new Blockbuster();

            do
            {
                Movie chosenMovie = vBlockBuster.CheckOut();

                Console.WriteLine(chosenMovie.Title);

                chosenMovie.PrintInfo();

                chosenMovie.Play();

            } while (DVD.Continue());

           
        }
    }
}
