using System;
namespace LearningCSharp
{
    class StackPost
    {
        private int Id;
        private string Title { get; set; }
        private string Description { get; set; }

        private DateTime PostDate { get; set; }

        public void Post(int id, string title, string description)
        {
            this.Id = id;
            this.Title = title;
            this.Description  = description;
            this.PostDate = DateTime.Now;

            Console.WriteLine("New Post added: {0} {1} {2}", Title, Description, PostDate);
        }
    }
}
