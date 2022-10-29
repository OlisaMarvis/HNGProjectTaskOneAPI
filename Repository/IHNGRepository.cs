using HNGProjectTaskOneAPI.Model;

namespace HNGProjectTaskOneAPI.Repository
{
    public interface IHNGRepository
    {
        Task<IEnumerable<HNGStudent>> GetHNGStudents();
    }
}
