namespace OnlineExaminationSystem.Models
{
    public class Question
    {
        public int QuestionId { get; set; }
        public int ExamId { get; set; }
        public string QuestionText {  get; set; } = string.Empty;
        public string Options {  get; set; } = string.Empty ;
        public string CorrectAnswer { get; set; } = string.Empty;
        public Exam Exam { get; set; } = default!;
            
    }
}
