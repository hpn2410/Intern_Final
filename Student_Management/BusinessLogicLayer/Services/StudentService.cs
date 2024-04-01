using DataAccessLayer.Entities;
using DataAccessLayer.Interfaces; // Import the correct namespace

namespace BusinessLogicLayer.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<List<DataAccessLayer.Entities.Student>> GetAllStudentsAsync()
        {
            return await _studentRepository.GetAllStudentsAsync();
        }

        public async Task<DataAccessLayer.Entities.Student> GetStudentByIdAsync(int id)
        {
            return await _studentRepository.GetStudentByIdAsync(id);
        }

        public async Task CreateStudentAsync(DataAccessLayer.Entities.Student student)
        {
            await _studentRepository.CreateStudentAsync(student);
        }

        public async Task UpdateStudentAsync(DataAccessLayer.Entities.Student student)
        {
            await _studentRepository.UpdateStudentAsync(student);
        }

        public async Task DeleteStudentAsync(int id)
        {
            await _studentRepository.DeleteStudentAsync(id);
        }
    }
}
