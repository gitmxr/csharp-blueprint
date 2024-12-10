namespace OnlineExaminationSystem.Models
{
    public interface IQuestionRepository
    {
        IEnumerable<Question> GetQuestions();
        void AddQuestion (Question question);
        void RemoveQuestion (Question question);
        void UpdateQuestion (int questionId);
    }
}
