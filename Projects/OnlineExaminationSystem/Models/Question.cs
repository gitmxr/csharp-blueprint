namespace OnlineExaminationSystem.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int ExamId { get; set; }
        public string QuestionText {  get; set; } 
        public string Options {  get; set; } 
        public string CorrectAnswer { get; set; } 
        public Exam Exam { get; set; } = default!;
            
    }
}
