using Microsoft.AspNetCore.Mvc;
using OnlineExaminationSystem.Models;

namespace OnlineExaminationSystem.Controllers
{
    public class ExamController : Controller

    {
        private readonly IExamRepository _examRepository;

        public ExamController(IExamRepository examRepository)
        {
            _examRepository = examRepository;
        }

        public IActionResult ExamInfo()
        {
            var exams = _examRepository.GetAllExams();
            return View(exams);
        }
       
    }
}
