using System;
using System.Collections.Generic;

namespace Movies
{
    class Movie
    {
        private string title;
        private string category;

        //constructor
        public string Title { get; set; }
        public string Category { get; set; }
        public Movie(string title, string category)
        {
           this.Title = title;
           this.Category= category;
        }
    
    }
    class Program
    {
        static void Main(string[] args)
        {
             //list to store 10 movies
                List<Movie> movies = new List<Movie>();

                movies.Add(new Movie("Home Front", "action"));
                movies.Add(new Movie("Spencer Confidential", "action"));
                movies.Add(new Movie("I Am Legend", "scifi"));
                movies.Add(new Movie("Jupiter Ascending", "scifi"));
                movies.Add(new Movie("Crazy Stupid Love", "romance"));
                movies.Add(new Movie("Two Weeks Notice", "romance"));
                movies.Add(new Movie("Bad Trip", "comedy"));
                movies.Add(new Movie("Jumping the Broom", "comedy"));
                movies.Add(new Movie("White or Black", "drama"));
                movies.Add(new Movie("The Help", "drama"));


                Console.WriteLine("Welcome to the Movie List Application!");
                Console.WriteLine("\nThere are 10 movies in this list.");
            do
            {
                Console.Write("What category are you interested in? ");
                string userInput = Console.ReadLine();

                foreach (Movie mo in movies)
                {
                    if (userInput == mo.Category)
                    {
                        Console.WriteLine(mo.Title);
                    }
                    else if (userInput != mo.Category)
                    {
                        Console.WriteLine("Category invalid");
                    }
                }
                
                Console.Write("\nWould you like to pick another category (y/n): ");
                    string choice = Console.ReadLine();
                    if (choice == "n")
                    {
                        Console.Write("Thanks!\n");
                    }
                    else if (choice == "y")
                    {
                        Console.WriteLine();
                        continue;
                    }
                    break;
           } while (true);
        }
    }
}
