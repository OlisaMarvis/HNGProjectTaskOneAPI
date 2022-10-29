using AutoMapper;
using HNGProjectTaskOneAPI.DTOS;
using HNGProjectTaskOneAPI.Model;

namespace HNGProjectTaskOneAPI.HNGMappings
{
    public class ViewmodelToModel : Profile
    {
        public ViewmodelToModel()
        {
            CreateMap<HNGStudentModel, HNGStudent>();
        }
    }
}
