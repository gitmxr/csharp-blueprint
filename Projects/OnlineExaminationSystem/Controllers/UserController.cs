using Microsoft.AspNetCore.Mvc;
using OnlineExaminationSystem.Models;

namespace OnlineExaminationSystem.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserRepository _userRepository;

        // Constructor that injects the repository
        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET: User
        public IActionResult Index()
        {
            // Get all users from the repository
            var users = _userRepository.GetAllUsers();
            return View(users);
        }

        // GET: User/Details/5
        public IActionResult Details(string id)
        {
            // Find a user by their ID
            var user = _userRepository.GetUserById(id);

            // If no user is found, return 404
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // GET: User/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                // Add the new user to the repository
                _userRepository.AddUser(user);
                return RedirectToAction(nameof(Index));
            }
            return View(user);
        }

        // GET: User/Edit/5
        public IActionResult Edit(string id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: User/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(string id, User user)
        {
            if (id != user.UserId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                // Update the user in the repository
                _userRepository.UpdateUser(user);
                return RedirectToAction(nameof(Index));
            }

            return View(user);
        }

        // GET: User/Delete/5
        public IActionResult Delete(string id)
        {
            var user = _userRepository.GetUserById(id);
            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteConfirmed(string id)
        {
            _userRepository.DeleteUser(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
