using AutoMapper;
using CommunicationsCompany.Domain.Entities;
using CommunicationsCompany.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationsCompany.Web.Mappings
{
    public class DomainToViewModel : Profile
    {
        public DomainToViewModel()
        {
            CreateMap<CommNode, CommNodeViewModel>()
                .ForMember(x => x.MainHubId, x => x.MapFrom(x => x.MainHub.Id));
            CreateMap<Device, DeviceViewModel>();
            CreateMap<Address, AddressViewModel>();
            CreateMap<ExtraProgram, ExtraProgramViewModel>();
            CreateMap<InternetService, InternetServiceViewModel>();
            CreateMap<StaticIp, StaticIpViewModel>();
            CreateMap<LegalEntity, LegalEntityViewModel>();
            CreateMap<LegalEntity, LegalEntityViewModel>();
            CreateMap<MainHub, MainHubViewModel>()
                .ForMember(x => x.RegionalHub, x => x.MapFrom(x => x.RegionalHub.Id));
            CreateMap<NaturalPerson, NaturalPersonViewModel>();
            CreateMap<PhoneNumber, PhoneNumberViewModel>();
            CreateMap<RegionalHub, RegionalHubViewModel>();
            CreateMap<Services, ServicesViewModel>();
            CreateMap<User, UserViewModel>();
        }
    }
}
