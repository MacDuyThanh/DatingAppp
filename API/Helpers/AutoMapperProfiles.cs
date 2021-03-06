using System;
using System.Linq;
using API.DTOs;
using API.Entities;
using API.Extentions;
using AutoMapper;


namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<AppUser, MemberDto>();
                // .ForMember(dest => dest.PhotoUrl, opt => opt.MapForm(src => src.Photos.FirstOrDefault(x => x.IsMain).Url))
                // .ForMember(dest => dest.Age, opt => opt.MapForm(src => src.DateOfBirth.CalculateAge()));
            CreateMap<Photo, PhotoDto>();
            CreateMap<MemberUpdateDto, AppUser>();
        }
    }
}