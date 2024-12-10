namespace OnlineExaminationSystem.Models
{
    public class Result
    {
        public int ResultId { get; set; }
        public string StudentId { get; set; }
        public int ExamId { get; set; }
        public int TotalScore { get; set; }
        public bool IsPassed { get; set; }
        public Exam Exam { get; set; }
        public User Student { get; set; }
    }
}
