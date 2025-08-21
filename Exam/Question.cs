using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal abstract class Question
    {



        public string? Header { get; set; }
        public string? Body { get; set; }
        public int Mark {  get; set; } 

        public Answer[] Answers { get; set; }

        public Answer RightAnswer { get; set; }

      
        protected Question(string? header, string? body, int mark, Answer[] answers, Answer rightAnswer)
        {
            Header = header;
            Body = body;
            Mark = mark;
            Answers = answers;
            RightAnswer = rightAnswer;
        }
        public Answer[] GetAnswers()
        {
            return Answers;
        }

        public bool CheckAnswer(int id)
        {
            return id == RightAnswer.AnswerId;
        }
        public abstract void DisplayQuestions();

        public override string ToString()
        {
            return $"{Header} : {Body} , Mark = {Mark}";
        }
        

         
      


    }
}
