using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Application.DTO;
using Application.Interfaces;

namespace Application.UseCase.Services
{
    public class ResumeService : IResumeService
    {
        private readonly IResumeCommand _command;
        private readonly IResumeQuery _query;

        public ResumeService(IResumeCommand command , IResumeQuery query) 
        {
            _command = command;
            _query = query;
        }

        public async Task<ResumeResponse> CreateResume(ResumeDTO resumeDTO)
        {
            var resume = new Resume{
                UserId = resumeDTO.UserId,
                Description = resumeDTO.Description,
                MinimunSalary = resumeDTO.MinimunSalary,
                Image = resumeDTO.Image
            };
            await _command.InsertResume(resume);
            return new ResumeResponse{
                ResumeId = resume.ResumeId,
                UserId = resume.UserId,
                Description = resume.Description,
                MinimunSalary = resume.MinimunSalary,
                Image = resume.Image
            };
        }

        Task<ResumeResponse> IResumeService.CreateResume(ResumeDTO resumeDTO)
        {
            throw new NotImplementedException();
        }

        public Task<ResumeResponse> GetResumeByID(int resumeId)
        {
            var resume = _query.GetResume(resumeId);
            return Task.FromResult(new ResumeResponse{
                ResumeId = resume.ResumeId,
                UserId = resume.UserId,
                Description = resume.Description,
                MinimunSalary = resume.MinimunSalary,
                Image = resume.Image
            });
        }
    }
}