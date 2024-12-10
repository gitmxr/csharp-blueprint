namespace OnlineExaminationSystem.Models
{
    public interface IExamRepository
    { 
        IEnumerable<Exam> GetAllExam();
        Exam GetExamById (int examId);
        void AddExam(Exam exam);
        void DeleteExam(int examId);
        void UpdateExam(Exam exam);
    }
}
