using System;
namespace LearningCSharp
{
    class Vote
    {
        private int NumOfVotes { get; set; }

        public void UpVote()
        {
            NumOfVotes++;
            Console.WriteLine("Votes =" + NumOfVotes);
        }

        public void DownVote()
        {
            if (NumOfVotes == 0)
            {
                Console.WriteLine("Number of votes is already at 0");
            }
            else
            {
                NumOfVotes--; //decrementing votes
            }
        }
    }
}
