using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            var sportsCentreBookingEngine = new WorkflowEngine();
            sportsCentreBookingEngine.RegisterActivities(new Badminton());
            sportsCentreBookingEngine.RegisterActivities(new IndoorFootball());
            sportsCentreBookingEngine.Run();

            Console.WriteLine();
            Console.WriteLine("=============================================");
            Console.WriteLine();

            // Reusing the workflow engine is just a matter of creating the object and passing in the activities.
            // None of the Engine or Actvity code has been touched!

            var fitnessProgram = new WorkflowEngine();
            fitnessProgram.RegisterActivities(new Pressup());
            fitnessProgram.RegisterActivities(new Situp());
            fitnessProgram.RegisterActivities(new StarJump());
            fitnessProgram.RegisterActivities(new SquatThrust());
            fitnessProgram.Run();

            Console.ReadLine();
            
        }

        //===========================================================================================================================
        // These Classes would normally be in seperate files

        public class Pressup : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("10 press ups x 3");
            }
        }

        public class Situp : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("10 sit ups x 3");
            }
        }

        public class StarJump : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("1 minute of star jumps (minimum 20)");
            }
        }

        public class SquatThrust : IActivity
        {
            public void Execute()
            {
                Console.WriteLine("20 squat thrusts");
            }
        }

       

    }
}