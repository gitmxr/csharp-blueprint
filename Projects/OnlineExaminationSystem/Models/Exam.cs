namespace OnlineExaminationSystem.Models
{
    public class Exam
    {
        public int ExamId { get; set; }
        public string Title { get; set; } 
        public string? Description { get; set; }
        public DateTime ExamDate { get; set; }
        public int Duration { get; set; }
        public List<Question>? Questions { get; set; }    

    }
}
