using System;

namespace LearningInterfaces
{
    public class IndoorFootball : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Football pitch booked");
        }
    }
}
