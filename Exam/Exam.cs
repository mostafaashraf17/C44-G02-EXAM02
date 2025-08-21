using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal abstract class Exam 
    {

        public int Time { get; set; }
        public int NumbersOfQuestions {  get; set; }

        public Question[] Questions { get; set; }

        protected Exam(int time, int numbersOfQuestions , Question[] questions)
        {
            Time = time;
            NumbersOfQuestions = numbersOfQuestions;
            Questions = questions;
        }


        public abstract void ShowExam();

        public override string ToString()
        {
            return $"Time = {Time} , NumbersOfQuestions = {NumbersOfQuestions}";
        }



    }
}
