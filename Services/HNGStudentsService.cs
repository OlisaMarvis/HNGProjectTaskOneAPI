using AutoMapper;
using HNGProjectTaskOneAPI.DTOS;
using HNGProjectTaskOneAPI.Repository;

namespace HNGProjectTaskOneAPI.Services
{
    public class HNGStudentsService : IHNGStudentsService
    {
        private readonly IHNGRepository _hngRepository;
        private readonly IMapper _mapper;

        public HNGStudentsService(IHNGRepository hngRepository, IMapper mapper)
        {
            _hngRepository = hngRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<HNGStudentModel>> GetAllHNGStudents()
        {
            var hngStudents = await _hngRepository.GetHNGStudents();
            var hngStudentsModel = _mapper.Map<IEnumerable<HNGStudentModel>>(hngStudents);
            return hngStudentsModel;
        }
    }
}
