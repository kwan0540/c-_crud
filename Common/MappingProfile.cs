using AutoMapper;
using crud.user;
using crud.user.Dtos;

namespace crud.Common;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<CreateUserDto, User>().ReverseMap();
    }
}