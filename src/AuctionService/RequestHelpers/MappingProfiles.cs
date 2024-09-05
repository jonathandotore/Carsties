using System;
using AuctionService.DTO;
using AuctionService.Entities;
using AutoMapper;

namespace AuctionService.RequestHelpers;

public class MappingProfiles : Profile
{
    public MappingProfiles()
    {
        //Create a constructor that will be mapped <OriginClass, ToDestinationClass>
        CreateMap<Auction, AuctionDto>()
                .IncludeMembers(x => x.Item);
        
        CreateMap<CreateAuctionDto, Auction>()
                .ForMember(d => d.Item, o => o.MapFrom(s => s));
        
        CreateMap<Item, AuctionDto>();
        CreateMap<CreateAuctionDto, Item>();
    }
}
