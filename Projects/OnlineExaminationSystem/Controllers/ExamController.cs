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

        // Get all exams
        public IActionResult ExamInfo()
        {
            var exams = _examRepository.GetAllExams();
            return View(exams);
        }

        // Get exam details by ID
        public IActionResult Details(int id)
        {
            var exam = _examRepository.GetExamById(id);
            if (exam == null)
            {
                return NotFound();
            }
            return View(exam);
        }

        // Create a new exam (GET)
        public IActionResult Create()
        {
            return View();
        }

        // Add a new exam (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Exam exam)
        {
            if (ModelState.IsValid)
            {
                _examRepository.AddExam(exam); // Calls the AddExam method of IExamRepository
                return RedirectToAction(nameof(ExamInfo)); // Redirect back to ExamInfo view
            }
            return View(exam);
        }

        // Edit an exam (GET)
        public IActionResult Edit(int id)
        {
            var exam = _examRepository.GetExamById(id);
            if (exam == null)
            {
                return NotFound();
            }
            return View(exam);
        }

        // Edit an exam (POST)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, Exam exam)
        {
            if (id != exam.ExamId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _examRepository.UpdateExam(exam);
                return RedirectToAction(nameof(ExamInfo));
            }
            return View(exam);
        }

        // Delete an exam (GET)
        public IActionResult Delete(int id)
        {
            var exam = _examRepository.GetExamById(id);
            if (exam == null)
            {
                return NotFound();
            }
            return View(exam);
        }

        // Delete an exam (POST)
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(int id)
        {
            _examRepository.DeleteExam(id);
            return RedirectToAction(nameof(ExamInfo));
        }
    }
}
