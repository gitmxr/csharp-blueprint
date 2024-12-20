namespace OnlineExaminationSystem.Models
{
    public class MockExamRepository : IExamRepository
    {
      //  public readonly IQuestionRepository question = new MockQuestionRepository();
        List<Exam> _examList = new List<Exam>()
        {
            new Exam
            { ExamId = 1,
            Title = "Math Quiz",
            Description = "A basic math test",
            ExamDate = DateTime.Now.AddDays(2),
            Duration = 60,
            Questions = new List<Question>()
            },
            new Exam
            {
                ExamId = 2,
                Title =  "Mid Exam",
                Description = "Semester Mid Exam",
                ExamDate = DateTime.Now.AddDays(14),
                Duration = 60,
                Questions = new List<Question>()

            },
            new Exam
            {
                ExamId = 3,
                Title =  "final Exam",
                Description = "Semester Final Exam",
                ExamDate = DateTime.Now.AddDays(7),
                Duration = 100,
                Questions = new List<Question>()

            },
        };
        public IEnumerable<Exam> GetAllExams()
        {
            return _examList;
        }

        public Exam GetExamById(int examId)
        {
            return _examList.FirstOrDefault(e => e.ExamId == examId);
        }

        public void AddExam(Exam exam)
        {
            exam.ExamId = _examList.Max(e => e.ExamId) + 1;
            _examList.Add(exam);
        }
        public void UpdateExam(Exam exam)
        {
            var existingExam = _examList.FirstOrDefault(e => e.ExamId == exam.ExamId);
            if (existingExam != null)
            {
                existingExam.Title = exam.Title;
                existingExam.Description = exam.Description;
                existingExam.ExamDate = exam.ExamDate;
                existingExam.Duration = exam.Duration;
                existingExam.Questions = exam.Questions;
            }
        }

        public void DeleteExam(int examId)
        {
            var exam = _examList.FirstOrDefault(e => e.ExamId == examId);
            if (exam != null)
            {
                _examList.Remove(exam);
            }
        }
    }
}
