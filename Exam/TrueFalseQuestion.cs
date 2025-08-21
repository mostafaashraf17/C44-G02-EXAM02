using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string? header, string? body, int  mark, Answer[] answers, Answer rightAnswer) : base(header, body, mark, answers, rightAnswer)
        {

        }

        public override void DisplayQuestions()
        {
            Console.WriteLine("Question True Or False");
            Console.WriteLine(ToString());
            foreach (var ans in Answers)
            {
                Console.WriteLine(ans);
            }
            
        }
    }
}
