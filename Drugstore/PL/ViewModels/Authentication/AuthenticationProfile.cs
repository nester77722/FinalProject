using AutoMapper;
using DAL.Entities;

namespace PL.ViewModels.Authentication
{
    public class AuthenticationProfile : Profile
    {
        public AuthenticationProfile()
        {
            CreateMap<RefreshToken, RefreshTokenViewModel>();
        }
    }
}