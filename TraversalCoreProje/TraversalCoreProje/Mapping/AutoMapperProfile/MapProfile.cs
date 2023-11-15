using AutoMapper;
using DTOLayer.AnnouncementDTOs;
using DTOLayer.AppUserDTOs;
using DTOLayer.ContactDTOs;
using EntitiyLayer.Concrete;

namespace TraversalCoreProje.Mapping.AutoMapperProfile
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<AnnouncementAddDto, Announcement>();
            CreateMap<Announcement, AnnouncementAddDto>();

            CreateMap<AppUserRegisterDTOs, AppUser>();
            CreateMap<AppUser, AppUserRegisterDTOs>();

            CreateMap<AppUserLoginDTOs, AppUser>();
            CreateMap<AppUser, AppUserLoginDTOs>();

            CreateMap<AnnouncementListDto, Announcement>(); 
            CreateMap<Announcement, AnnouncementListDto>();  
            
            CreateMap<AnnouncementUpdateDTOs, Announcement>(); 
            CreateMap<Announcement, AnnouncementUpdateDTOs>();

            CreateMap<SendMessageDto, ContactuS>().ReverseMap();


        }
    }
}
