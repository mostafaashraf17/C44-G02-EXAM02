namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Subject Id");
            int subjectid = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Enter Your Subject Name");
            string? SubjectName = Console.ReadLine();

            Subject subject = new Subject(subjectid, SubjectName);

            Console.WriteLine("Choose Exam Type If FinalExam Choose 1 , If PracticalExam Choose 2 ");
            int TypeExam = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Enter Time Of Eaxm");
            int Time = int.Parse(Console.ReadLine() ?? string.Empty);

            Console.WriteLine("Enter Number Of Exam");
            int Number = int.Parse(Console.ReadLine() ?? string.Empty);

            Answer[] MCQ01 = new Answer[]
            {
                new Answer (1 , "A"),
                new Answer (2 , "B"),
                new Answer (3 , "C"),
                new Answer (4 , "D"),
            };

            Question Q01 = new MCQQuestion($"Question 01" , "Which Word Starts Char 'A'", 5 ,MCQ01 , MCQ01[1]);

            Answer[] MCQ02 = new Answer[]
            {
                new Answer (1 , "E"),
                new Answer ( 2, "F"),
                new Answer (3 ,"G" ),
                new Answer (4 , "H"),

            };

            Question Q02 = new MCQQuestion("Question 02", "Which Word Starts Cahr 'H'", 5, MCQ02, MCQ02[4]);


            Answer[] TrueOrFalse = new Answer[]
            {
                new Answer (1 , "True"),
                new Answer (2 , "False"),
            };


            Question Q03 = new TrueFalseQuestion("Question 3 ", "Is A Question Number Q01 = B", 1, TrueOrFalse, TrueOrFalse[2]);

            Question[] Exam = new Question[] {Q01  , Q02 , Q03};

            Exam exams;

            if (TypeExam == 1)
            {
                exams = new FinalExam(10 , 1, Exam);
            }
            else
                exams = new PractialExam(15 , 2 ,Exam);

            subject.CreateTheExam(exams);

            Console.WriteLine(SubjectName);

         
            



        }
    }
}
