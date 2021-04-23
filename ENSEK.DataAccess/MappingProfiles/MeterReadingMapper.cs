namespace ENSEK.DataAccess.MappingProfiles
{
    using AutoMapper;
    using Common.Models;
    using Common.odels;
    using Entities;

    public class MeterReadingMapper : Profile
    {
        public MeterReadingMapper()
        {
            CreateMap<MeterReadingEntity, MeterReadingModel>()
                .ForMember(dest => dest.MeterReadValue, opt => opt.MapFrom(src => src.MeterReadValue.ToString()));

            CreateMap<MeterReadingModel,MeterReadingEntity>()
                .ForMember(dest => dest.MeterReadValue, opt => opt.MapFrom(src => int.Parse(src.MeterReadValue)));

            CreateMap<AccountEntity, AccountModel>().ReverseMap();
        }
    }
}
