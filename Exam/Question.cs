using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal abstract class Question
    {

        private string? Header { get; set; }
        private string? Body { get; set; }
        private double Mark {  get; set; } 

        public Answer[] Answers { get; set; }

        public Answer RightAnswer { get; set; }

        protected Question(string? header, string? body, double mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public abstract void DisplayQuestions();

        public override string ToString()
        {
            return $"{Header} : {Body} , Mark = {Mark}";
        }
        

         
      


    }
}
