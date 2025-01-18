
namespace OnlineExaminationSystem.Models
{
    public interface IUserRepository
    {
        IEnumerable<User> GetAllUsers(); //Fetch all users 
        User GetUserById(string userId); // Fetch user by id
        User GetUserByEmail(string email); // Fetch a user by email
        void AddUser(User user); // Add a new user
        void UpdateUser(User user); // Update an existing user
        void DeleteUser(string userId); // Delete a user by ID
        IEnumerable<User> GetUsersByRole(string role);
    }
}
