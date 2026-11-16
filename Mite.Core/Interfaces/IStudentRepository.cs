using Mite.Core.Entities; 

namespace Mite.Core.Interfaces
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync();
        Task AddAsync(Student student);

    }
}
