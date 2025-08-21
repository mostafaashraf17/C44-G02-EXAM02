using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int numbersOfQuestions, Question[] questions) : base(time, numbersOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");
            decimal Grade = 0;

            foreach (var ques in Questions)
            {
                Console.WriteLine(ques.ToString());

                foreach (var answer in ques.GetAnswers())
                    Console.WriteLine(answer);

                Console.WriteLine("please enter your Answer number");

                int.TryParse(Console.ReadLine(), out int answerofuser);

                if (ques.CheckAnswer(answerofuser))
                    Grade += ques.Mark ;



        
            }
            Console.WriteLine($"You have finished your final exam. \n your Grade = {Grade} / {Questions.Length}");

        }    
    }
}
