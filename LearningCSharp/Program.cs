using System;


namespace LearningCSharp
{

    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Add a new Post to StackOverflow");
            Console.WriteLine("Press 1 to add new Post");

            Console.WriteLine("Input id number:");
            var post = new StackPost(id, title, description);

            
            
            string test;
            test = Console.ReadLine();
            if (test == "1")
            {
                NewPost();

            }
            
        }

        static void NewPost()
        {
            var post = new StackPost();

            var title = "Title";
            var description = "description";
            var vote = new Vote();
            vote.
            
            post.Post(title, description);
        
        }

    }
}
