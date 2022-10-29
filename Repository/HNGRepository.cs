using HNGProjectTaskOneAPI.Data;
using HNGProjectTaskOneAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace HNGProjectTaskOneAPI.Repository
{
    public class HNGRepository : IHNGRepository
    {
        private readonly AppDBContext _context;

        public HNGRepository(AppDBContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<HNGStudent>> GetHNGStudents()
        {
            return await _context.HNGStudents.ToListAsync();
        }
    }
}
