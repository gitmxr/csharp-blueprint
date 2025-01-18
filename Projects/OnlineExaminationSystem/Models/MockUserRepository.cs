using System.Collections.Generic;
using System.Linq;

namespace OnlineExaminationSystem.Models
{
    public class MockUserRepository : IUserRepository
    {
        private List<User> _userList;

        public MockUserRepository()
        {
            _userList = new List<User>
            {
                new User
                {
                    UserId = "1",
                    FullName = "Hassan Riaz",
                    Email = "hassan.riaz@example.com",
                    Password = "password123",
                    Role = "Student"
                },
                new User
                {
                    UserId = "2",
                    FullName = "Munaza Zahoor",
                    Email = "maneezay.zahoor@example.com",
                    Password = "password123",
                    Role = "Teacher"
                },
                new User
                {
                    UserId = "3",
                    FullName = "Ahmad Khan",
                    Email = "ahmad.khan@example.com",
                    Password = "password123",
                    Role = "Administrator"
                },
                new User
                {
                    UserId = "4",
                    FullName = "Fatima Noor",
                    Email = "fatima.noor@example.com",
                    Password = "password123",
                    Role = "Student"
                },
                new User
                {
                    UserId = "5",
                    FullName = "Ali Hassan",
                    Email = "ali.hassan@example.com",
                    Password = "password123",
                    Role = "Teacher"
                }
            };
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userList;
        }

        public User GetUserById(string userId)
        {
            return _userList.FirstOrDefault(u => u.UserId == userId);
        }

        public User GetUserByEmail(string email)
        {
            return _userList.FirstOrDefault(u => u.Email == email);
        }

        public void AddUser(User user)
        {
            _userList.Add(user);
        }

        public void UpdateUser(User user)
        {
            var existingUser = GetUserById(user.UserId);
            if (existingUser != null)
            {
                existingUser.FullName = user.FullName;
                existingUser.Email = user.Email;
                existingUser.Password = user.Password;
                existingUser.Role = user.Role;
            }
        }

        public void DeleteUser(string userId)
        {
            var user = GetUserById(userId);
            if (user != null)
            {
                _userList.Remove(user);
            }
        }

        public IEnumerable<User> GetUsersByRole(string role)
        {
            return _userList.Where(u => u.Role.Equals(role, System.StringComparison.OrdinalIgnoreCase));
        }
    }
}
