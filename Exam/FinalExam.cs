using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class FinalExam : Exam 
    {
        public override void ShowExam()
        {
            Console.WriteLine($"Question = {Question} ");
        }
    }
}
