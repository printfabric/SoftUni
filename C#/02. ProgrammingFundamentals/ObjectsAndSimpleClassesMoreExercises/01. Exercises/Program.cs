using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Exercises
{
    class Exercise
    {
        public string Topic { get; set; }
        public string CourseName { get; set; }
        public string JudgeContestLink { get; set; }
        public List<string> Problems { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Exercise> exercises = new List<Exercise>();

            string inputLine = Console.ReadLine();

            while(inputLine != "go go go")
            {
                string[] inputParams = inputLine.Split(new[] { ' ', '-', '>', ',' }
                , StringSplitOptions.RemoveEmptyEntries);

                string topic = inputParams[0];
                string courseName = inputParams[1];
                string judgeContestLink = inputParams[2];
                List<string> problems = inputParams.Skip(3).ToList();
                //inputLine = Console.ReadLine();

               // POINT point = new Point();
                Exercise newExercise = new Exercise();

                newExercise.Topic = topic;
                newExercise.CourseName = courseName;
                newExercise.JudgeContestLink = judgeContestLink;
                newExercise.Problems = problems;
                 
                exercises.Add(newExercise);
                //Exercise newExercise = new Exercise()
                //{
                //    Topic = topic,
                //    CourseName = courseName,
                //    judgeContestLink = judgeContestLink,
                //    Problems = problems
                //};

                inputLine = Console.ReadLine();
            }
            foreach (Exercise exercise in exercises)
            {
                Console.WriteLine("Exercises: {0}", exercise.Topic);
                Console.WriteLine("Problems for exercises and homework for the \"{0}\" course @ SoftUni." , exercise.CourseName);
                Console.WriteLine("Check your solutions here: {0}", exercise.JudgeContestLink);

                int count = 1;

                foreach (var problem in exercise.Problems)
                {
                    Console.WriteLine("{0}. {1}", count, problem);
                    count++;
                }
            }

        } 
    }
}
 