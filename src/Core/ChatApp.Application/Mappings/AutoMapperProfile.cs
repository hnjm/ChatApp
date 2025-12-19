using AutoMapper;
using ChatApp.Domain.Entities;
using ChatApp.Domain.Enums;
using ChatApp.Application.DTOs.Users;
using ChatApp.Application.DTOs.Messages;
using ChatApp.Application.DTOs.Groups;
using ChatApp.Application.DTOs.Channels;
using ChatApp.Application.DTOs.Calls;
using ChatApp.Application.DTOs.Media;

namespace ChatApp.Application.Mappings;

/// <summary>
/// ملف تعريف AutoMapper - AutoMapper Profile
/// </summary>
public class AutoMapperProfile : Profile
{
    public AutoMapperProfile()
    {
        // User mappings
        CreateMap<User, UserDto>()
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()));
        
        CreateMap<User, UserProfileDto>()
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
            .ForMember(dest => dest.TotalConversations, opt => opt.Ignore())
            .ForMember(dest => dest.TotalGroups, opt => opt.Ignore())
            .ForMember(dest => dest.TotalChannels, opt => opt.Ignore());
        
        CreateMap<CreateUserDto, User>();
        
        // Message mappings
        CreateMap<Message, MessageDto>()
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.ToString()))
            .ForMember(dest => dest.SenderName, opt => opt.MapFrom(src => src.Sender!.Username))
            .ForMember(dest => dest.SenderProfilePictureUrl, opt => opt.MapFrom(src => src.Sender!.ProfilePictureUrl));
        
        // Media mappings
        CreateMap<Media, MediaDto>();
        CreateMap<VoiceMessage, VoiceMessageDto>();
        
        // Group mappings
        CreateMap<Group, GroupDto>();
        CreateMap<GroupMember, GroupMemberDto>()
            .ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.User!.Username))
            .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.User!.FullName))
            .ForMember(dest => dest.ProfilePictureUrl, opt => opt.MapFrom(src => src.User!.ProfilePictureUrl))
            .ForMember(dest => dest.Role, opt => opt.MapFrom(src => src.Role.ToString()));
        
        // Channel mappings
        CreateMap<Channel, ChannelDto>();
        
        // Call mappings
        CreateMap<Call, CallDto>()
            .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Type.ToString()))
            .ForMember(dest => dest.Status, opt => opt.MapFrom(src => src.Status.ToString()))
            .ForMember(dest => dest.CallerName, opt => opt.MapFrom(src => src.Caller!.Username))
            .ForMember(dest => dest.ReceiverName, opt => opt.MapFrom(src => src.Receiver!.Username));
    }
}
