using AutoMapper;
using NET_6_criando_uma_web.Data.Dtos;
using NET_6_criando_uma_web.Models;

namespace NET_6_criando_uma_web.Profiles
{
    public class FilmeProfile : Profile
    {
        public FilmeProfile()
        {
            CreateMap<CreateFilmeDto, Filme>();
            CreateMap<UpdateFilmeDto, Filme>();
            CreateMap<Filme, UpdateFilmeDto>();
            CreateMap<Filme, ReadFilmeDto>();
        }
    }
}
