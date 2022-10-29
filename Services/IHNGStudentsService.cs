using HNGProjectTaskOneAPI.DTOS;

namespace HNGProjectTaskOneAPI.Services
{
    public interface IHNGStudentsService
    {
        Task<IEnumerable<HNGStudentModel>> GetAllHNGStudents();
    }
}
