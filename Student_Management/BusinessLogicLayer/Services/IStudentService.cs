using DataAccessLayer.Entities; // Import the correct namespace

namespace BusinessLogicLayer.Services
{
    public interface IStudentService
    {
        Task<List<DataAccessLayer.Entities.Student>> GetAllStudentsAsync(); // Update return type
        Task<DataAccessLayer.Entities.Student> GetStudentByIdAsync(int id); // Update return type
        Task CreateStudentAsync(DataAccessLayer.Entities.Student student); // Update parameter type
        Task UpdateStudentAsync(DataAccessLayer.Entities.Student student); // Update parameter type
        Task DeleteStudentAsync(int id);
    }
}
