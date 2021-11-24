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
            CreateMap<MainHubViewModel, MainHub>();
            CreateMap<NaturalPersonViewModel, NaturalPerson>();
            CreateMap<PhoneNumberViewModel, PhoneNumber>();
            CreateMap<RegionalHubViewModel, RegionalHub>();
            CreateMap<ServicesViewModel, Services>();
            CreateMap<UserViewModel, User>();
        }
    }
}
