using AutoMapper;
using CommunicationsCompany.Domain.Entities;
using CommunicationsCompany.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CommunicationsCompany.Web.Mappings
{
    public class ViewModelToDomain : Profile
    {
        public ViewModelToDomain()
        {
            CreateMap<CommNodeViewModel, CommNode>();
            CreateMap<DeviceViewModel, Device>();
            CreateMap<AddressViewModel, Address>();
            CreateMap<ExtraProgramViewModel, ExtraProgram>();
            CreateMap<InternetServiceViewModel, InternetService>();
            CreateMap<StaticIpViewModel, StaticIp>();
            CreateMap<LegalEntityViewModel, LegalEntity>();
            CreateMap<MainHubViewModel, MainHub>()
                .ForMember(x => x.RegionalHub, x => x.Ignore());
            CreateMap<NaturalPersonViewModel, NaturalPerson>();
            CreateMap<PhoneNumberViewModel, PhoneNumber>();
            CreateMap<RegionalHubViewModel, RegionalHub>();
            CreateMap<ServicesViewModel, Services>();
            CreateMap<UserViewModel, User>()
                .ForMember(x => x.Id, x => x.Ignore())
                .ForMember(x => x.CommNode, x => x.Ignore())
                .ForMember(x => x.CommNodeId, x => x.Ignore());
                
        }
    }
}
