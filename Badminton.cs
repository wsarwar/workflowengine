using System;

namespace LearningInterfaces
{
    class Badminton : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Badminton Court successfully booked");
        }
    }
}
