using AutoMapper;
using DataAccess_layer.EntityFramework;
using DTOLayer.DTOs.AnnouncementDTOs;
using DTOLayer.DTOs.AppUserDTOs;
using Entity_layer.Concrete;

namespace TravelReservation.Mapping.AutoMapperProfile
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            // Announcement DTO ve Entity arasında iki yönlü eşleme
            CreateMap<AnnouncementAddDto, Announcement>();
            CreateMap<Announcement, AnnouncementAddDto>();

            // AppUser DTO ve Entity arasında iki yönlü eşlemeler
            CreateMap<AppUserRegisterDTOs, AppUser>();
            CreateMap<AppUser, AppUserRegisterDTOs>();

            CreateMap<AppUserLoginDTOs, AppUser>();
            CreateMap<AppUser, AppUserLoginDTOs>();  
            
            CreateMap<AnnouncementListDto, Announcement>();
            CreateMap<Announcement, AnnouncementListDto>();
        }
    }
}
