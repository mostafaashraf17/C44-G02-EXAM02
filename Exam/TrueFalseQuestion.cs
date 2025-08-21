using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class TrueFalseQuestion : Question
    {
        public TrueFalseQuestion(string? header, string? body, int mark , Answer right) : base(header, body, mark)
        {
            Answers = new Answer[]
            {
                new Answer  (1 , "true"),
                new Answer (2 , "false" )
            };
            RightAnswer = right;

        }

        public override void DisplayQuestions()
        {
            Console.WriteLine(ToString());
            for(int i = 0; i < Answers.Length; i++)
            {
                Console.WriteLine(Answers[i]);
            }
            
        }
    }
}
