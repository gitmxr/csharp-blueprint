namespace OnlineExaminationSystem.Models
{
    public class Answer
    {
        public int AnswerId { get; set; } // primary key 
        public string StudentId { get; set; } // foreign key linking user who submit answer
        public int QuestionId { get; set; } // foreign key for linking to question 
        public string SelectedOption { get; set; }  // option selected by the student
        public bool IsCorrect { get; set; } // the selected optn is correct or not 
        public Question Question { get; set; } // mavigation property to the related question
    }
}
