using HNGProjectTaskOneAPI.HNGMappings;

namespace HNGProjectTaskOneAPI.HNGMappingConfig
{
    public static class AutoMApperConfig
    {
        public static void AddAutoMapperConfiguration(this IServiceCollection services)
        {
            if (services == null) throw new ArgumentNullException(nameof(services));
            services.AddAutoMapper(typeof(ModelToViewModel), typeof(ViewmodelToModel));
        }
    }
}
