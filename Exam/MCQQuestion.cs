using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class MCQQuestion : Question
    {
        public MCQQuestion(string? header, string? body, int mark, Answer[] answers , Answer right) : base(header, body, mark)
        {
            Answers = answers;
            RightAnswer = right;
        }

        public override void DisplayQuestions()
        {
            Console.WriteLine(ToString());
            for(int i = 0;  i < Answers.Length; i++)
            {
                Console.WriteLine(Answers[i]);
            }
        }
    }
}
