using AutoMapper;
using HNGProjectTaskOneAPI.DTOS;
using HNGProjectTaskOneAPI.Model;

namespace HNGProjectTaskOneAPI.HNGMappings
{
    public class ModelToViewModel : Profile
    {
        public ModelToViewModel()
        {
            CreateMap<HNGStudent, HNGStudentModel>();
        }
    }
}
