using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class Subject 
    {

        public int SubjectID {  get; set; }
        public string? SubjectName { get; set; }

        public Exam Exam { get; set; }

        public Subject(int subjectID, string? subjectName)
        {
            SubjectID = subjectID;
            SubjectName = subjectName;
        }
        
        public void CreateTheExam(Exam exam)
        {
            Exam = exam;

        }


        public override string ToString()
        {
            return $"SubjectID : {SubjectID} , SubjectName : {SubjectName}";
        }

        
             
        


    }
}
