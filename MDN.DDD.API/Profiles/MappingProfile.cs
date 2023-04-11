using MDN.DDD.Domain.Contracts.Requests;
using MDN.DDD.Domain.Contracts.Responses;
using MDN.DDD.Domain.Entities;
using AutoMapper;

namespace MDN.DDD.API.Profiles
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            #region Entity to Request
            
           CreateMap<EnderecoRequest, Endereco>();
           CreateMap<PerfilRequest, Perfil>();
           CreateMap<UsuarioRequest, Usuario>().ReverseMap();
            // CreateMap<EmpresaRequest, Empresa>();

            #endregion

            #region Response to Entity
            //TODO

            CreateMap<Endereco, EnderecoResponse>();
            CreateMap<Usuario, UsuarioResponse>();
            //CreateMap<Empresa, EmpresaResponse>();
            CreateMap<Perfil, PerfilResponse>();
            //CreateMap<Nacionalidade, NacionalidadeResponse>()
            //    .ForMember(dst => dst.Sigla, map => map.MapFrom(src => src.Country.FirstOrDefault().CountryId))
            //    .ForMember(dst => dst.Probabilidade, map => map.MapFrom(src => src.Country.FirstOrDefault().Probability * 100));

            #endregion

            CreateMap<BrasilApi, BrasilApiResponse>();




        }
    }
}
