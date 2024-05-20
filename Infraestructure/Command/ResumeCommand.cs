﻿using Application.DTO.Error;
using Application.DTO.Request;
using Application.Interfaces;
using Domain.Entities;
using Infraestructure.Persistence;
using Microsoft.EntityFrameworkCore;


namespace Infraestructure.Command
{
    public class ResumeCommand : IResumeCommand
    {
        private readonly AppDbContext _context;
        public ResumeCommand(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Resume> InsertResume(Resume request)
        {
            try
            {
                //Validar contra el servicio User
                //var existResume = await _context.resumes.FirstOrDefaultAsync(r => (r.UserId == request.UserId));
                //if (existResume != null)
                //{
                //    throw new ExceptionConflict("El resume ya se encuentra");
                //}
                await _context.AddAsync(request);
                await _context.SaveChangesAsync();
                var newResume = await _context.resumes
                    .Include(e => e.ExperienceList)
                    .Include(s => s.StudyList)
                    .Include(rs => rs.ResumeSkillList)
                    .FirstOrDefaultAsync(r => (r.UserId == request.UserId));
                return newResume;

            }
            catch (DbUpdateException)
            {
                throw;
            }
        }
        public async Task<Resume> UpdateResume(ResumeRequest request)
        {
            try
            {
                var resumeUpdate = await _context.resumes
                    .Include(e => e.ExperienceList)
                    .Include(s => s.StudyList)
                    .Include(rs => rs.ResumeSkillList)
                    .FirstOrDefaultAsync(r => (r.UserId == request.UserId));

                if (resumeUpdate == null)
                {
                    throw new ExceptionNotFound("El user con id" + request.UserId + "no existe");
                }
                resumeUpdate.UserId = request.UserId;
                resumeUpdate.Description = request.description;
                resumeUpdate.MinimumSalary = request.minimumSalary;
                resumeUpdate.Image = request.image;
                await _context.SaveChangesAsync();
                return resumeUpdate;
            }
            catch (DbUpdateException)
            {
                throw;
            }
        }
        public async Task<Resume> DeleteResume(Guid id)
        {
            try
            {
                var resumeDelete = await _context.resumes.FirstOrDefaultAsync(r => (r.UserId == id));
                if (resumeDelete == null)
                {
                    throw new ExceptionNotFound("El Resume con ese ID no ha sido encontrado");
                }
                _context.resumes.Remove(resumeDelete);
                await _context.SaveChangesAsync();
                return resumeDelete;
            }
            catch (DbUpdateException)
            {
                throw new ExceptionConflict("Problema al eliminar el Resume");
            }
        }
    }
}
