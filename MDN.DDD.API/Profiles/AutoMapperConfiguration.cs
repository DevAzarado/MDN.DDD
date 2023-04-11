using AutoMapper;

namespace MDN.DDD.API.Profiles
{
    public class AutoMapperConfiguration
    {
        public static MapperConfiguration RegisterMappings()
        {
            return new MapperConfiguration(ps =>
            {
                ps.AddProfile(new MappingProfile());
            });
        }
    }
}
