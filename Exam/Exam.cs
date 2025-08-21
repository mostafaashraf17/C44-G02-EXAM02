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


        protected Exam(int time, int numbersOfQuestions)
        {
            Time = time;
            NumbersOfQuestions = numbersOfQuestions;
        }


        public abstract void ShowExam();

        public override string ToString()
        {
            return $"Time = {Time} , NumbersOfQuestions = {NumbersOfQuestions}";
        }



    }
}
