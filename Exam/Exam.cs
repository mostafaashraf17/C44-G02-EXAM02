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
        public abstract void ShowExam();



    }
}
