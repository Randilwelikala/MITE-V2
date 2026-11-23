using Microsoft.EntityFrameworkCore;
using Mite.Core.Entities;
using Mite.Core.Interfaces;
using Mite.Infrastructure.Data;

namespace Mite.Infrastructure.Repositories
{
    public class StudentRepository(AppDbContext context) : IStudentRepository
    {
        public async Task<List<Student>> GetAllAsync()
        {
            return await context.Students
                .AsNoTracking()
                .ToListAsync();
        }
        public async Task AddAsync(Student student)
        {
            await context.Students.AddAsync(student);
            await context.SaveChangesAsync();
        }
           
    }
}
