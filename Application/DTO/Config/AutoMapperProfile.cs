using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using AutoMapper;
using Domain.Entities;

namespace Application.DTO.Config
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Resume, ResumeRequest>().ReverseMap();
            CreateMap<Resume, ResumeResponse>().ReverseMap();
            CreateMap<ResumeSkill, ResumeSkillRequest>().ReverseMap();
            CreateMap<ResumeSkill, SkillResponse>().ReverseMap();
            CreateMap<Experience, ExperienceRequest>().ReverseMap();
            CreateMap<Experience, ExperienceResponse>().ReverseMap();
            CreateMap<ExperienceRequest, Experience>()
            .ForMember(dest => dest.UserId, opt => opt.Ignore());
            CreateMap<Skill, SkillResponse>().ReverseMap();
            CreateMap<SkillResponse, SkillResponsePaged>().ReverseMap();
            CreateMap<Study, StudyResponse>().ReverseMap();
            CreateMap<Study, StudyRequest>().ReverseMap();
            CreateMap<StudyType, StudyTypeResponse>().ReverseMap();


        }
    }
}
