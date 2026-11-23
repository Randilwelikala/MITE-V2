using Microsoft.EntityFrameworkCore;
using Mite.Core.Entities;
using Mite.Core.Interfaces;
using Mite.Infrastructure.Data;

namespace Mite.Infrastructure.Repositories
{
    public class StudentRepositories(AppDbContext context) : IStudentRepository
    {
        public async Task<List<Student>> GetAllAsync()
        {
            return await context.Students
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task TaskAsync(Student student)
        {
            await context.Students.AddAsync(student);
            await context.SaveChangesAsync();
        }
           
    }
}
