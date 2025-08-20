using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Answer
    {

        private int AnswerId { get; set; }
        private string? AnswerText { get; set; }

        private Answer[] Answers { get; set; }

        public Answer(int answerId, string? answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public override string ToString()
        {
            return $"AnswerId : {AnswerId} , AnswerText = {AnswerText}";
        }
    }
}
