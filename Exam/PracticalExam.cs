using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time, int numbersOfQuestions, Question[] questions) : base(time, numbersOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine($"Practial Exam");
            foreach (var ques in Questions)
            {
                Console.WriteLine(ques.ToString());

                foreach (var answer in ques.GetAnswers())
                    Console.WriteLine(answer);

                Console.WriteLine("please choose your answer number.");

                int.TryParse(Console.ReadLine(), out int answerofuser);

                Answer? rightanswer = null;

                foreach (var answer in ques.GetAnswers())
                {
                    if (ques.CheckAnswer(answer.AnswerId))
                    {
                        rightanswer = answer;
                        break;
                    }
                }

                Console.WriteLine($"Correct answer {rightanswer?.AnswerText}");
            }








        }
    }
}
