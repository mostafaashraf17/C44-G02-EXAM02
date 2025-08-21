using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{ internal class MCQQuestion : Question
    {
        public MCQQuestion(string? header, string? body, int  mark, Answer[] answers, Answer rightAnswer) : base(header, body, mark, answers, rightAnswer)
        {

        }

        public override void DisplayQuestions()
        {
            Console.WriteLine("Question MCQ");
            Console.WriteLine(ToString());
          foreach(var ans in Answers)
            {
                Console.WriteLine(ans);
            }
        }
    }
   
}
