using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;

namespace Infraestructure.EntityConfig
{
    public class ResumeSkillConfig : IEntityTypeConfiguration<ResumeSkill>
    {
        public void Configure(EntityTypeBuilder<ResumeSkill> builder)
        {
            builder.ToTable("ResumeSkill");
            builder.HasKey(rs => new { rs.UserId, rs.SkillId });

            builder.HasOne<Resume>(r => r.resume)
            .WithMany(r => r.ResumeSkillList)
            .HasForeignKey(r => r.UserId);

            builder.HasOne<Skill>(s => s.skill)
            .WithMany(s => s.ResumeSkill)
            .HasForeignKey(s => s.SkillId);

            builder.HasData(
// Usuario: e60df533-79d7-42f2-a36d-99362dbc6f85
new ResumeSkill { SkillId = 3, UserId = Guid.Parse("e60df533-79d7-42f2-a36d-99362dbc6f85") }, // C#
new ResumeSkill { SkillId = 24, UserId = Guid.Parse("e60df533-79d7-42f2-a36d-99362dbc6f85") }, // .NET
new ResumeSkill { SkillId = 1, UserId = Guid.Parse("e60df533-79d7-42f2-a36d-99362dbc6f85") }, // Java
new ResumeSkill { SkillId = 4, UserId = Guid.Parse("e60df533-79d7-42f2-a36d-99362dbc6f85") }, // Python
new ResumeSkill { SkillId = 5, UserId = Guid.Parse("e60df533-79d7-42f2-a36d-99362dbc6f85") }, // Ruby
new ResumeSkill { SkillId = 7, UserId = Guid.Parse("e60df533-79d7-42f2-a36d-99362dbc6f85") }, // Swift
new ResumeSkill { SkillId = 11, UserId = Guid.Parse("e60df533-79d7-42f2-a36d-99362dbc6f85") }, // TypeScript
new ResumeSkill { SkillId = 13, UserId = Guid.Parse("e60df533-79d7-42f2-a36d-99362dbc6f85") }, // Scala
new ResumeSkill { SkillId = 16, UserId = Guid.Parse("e60df533-79d7-42f2-a36d-99362dbc6f85") }, // MATLAB
new ResumeSkill { SkillId = 20, UserId = Guid.Parse("e60df533-79d7-42f2-a36d-99362dbc6f85") }, // Prolog

// Usuario: 8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473
new ResumeSkill { SkillId = 27, UserId = Guid.Parse("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") }, // React
new ResumeSkill { SkillId = 28, UserId = Guid.Parse("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") }, // Angular
new ResumeSkill { SkillId = 2, UserId = Guid.Parse("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") }, // Javascript
new ResumeSkill { SkillId = 6, UserId = Guid.Parse("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") }, // PHP
new ResumeSkill { SkillId = 9, UserId = Guid.Parse("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") }, // Rust
new ResumeSkill { SkillId = 12, UserId = Guid.Parse("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") }, // C++
new ResumeSkill { SkillId = 17, UserId = Guid.Parse("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") }, // Haskell
new ResumeSkill { SkillId = 22, UserId = Guid.Parse("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") }, // Fortran
new ResumeSkill { SkillId = 32, UserId = Guid.Parse("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") }, // Flask
new ResumeSkill { SkillId = 36, UserId = Guid.Parse("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") }, // Hibernate
                                                                                               
// Usuario: a0deb200-955f-4b6c-b550-9ca1712392a8 (Carlos Rodriguez)
new ResumeSkill { SkillId = 1, UserId = Guid.Parse("a0deb200-955f-4b6c-b550-9ca1712392a8") }, // Java
new ResumeSkill { SkillId = 25, UserId = Guid.Parse("a0deb200-955f-4b6c-b550-9ca1712392a8") }, // Spring
new ResumeSkill { SkillId = 3, UserId = Guid.Parse("a0deb200-955f-4b6c-b550-9ca1712392a8") }, // C#
new ResumeSkill { SkillId = 4, UserId = Guid.Parse("a0deb200-955f-4b6c-b550-9ca1712392a8") }, // Python
new ResumeSkill { SkillId = 6, UserId = Guid.Parse("a0deb200-955f-4b6c-b550-9ca1712392a8") }, // PHP
new ResumeSkill { SkillId = 10, UserId = Guid.Parse("a0deb200-955f-4b6c-b550-9ca1712392a8") }, // Kotlin
new ResumeSkill { SkillId = 11, UserId = Guid.Parse("a0deb200-955f-4b6c-b550-9ca1712392a8") }, // TypeScript
new ResumeSkill { SkillId = 12, UserId = Guid.Parse("a0deb200-955f-4b6c-b550-9ca1712392a8") }, // C++
new ResumeSkill { SkillId = 15, UserId = Guid.Parse("a0deb200-955f-4b6c-b550-9ca1712392a8") }, // R
new ResumeSkill { SkillId = 17, UserId = Guid.Parse("a0deb200-955f-4b6c-b550-9ca1712392a8") }, // Haskell

// Usuario: 5b68ad8c-f42e-40d7-87de-3622d34dcf84 (Maria Garcia)
new ResumeSkill { SkillId = 2, UserId = Guid.Parse("5b68ad8c-f42e-40d7-87de-3622d34dcf84") }, // Javascript
new ResumeSkill { SkillId = 29, UserId = Guid.Parse("5b68ad8c-f42e-40d7-87de-3622d34dcf84") }, // Vue.js
new ResumeSkill { SkillId = 30, UserId = Guid.Parse("5b68ad8c-f42e-40d7-87de-3622d34dcf84") }, // Node.js
new ResumeSkill { SkillId = 31, UserId = Guid.Parse("5b68ad8c-f42e-40d7-87de-3622d34dcf84") }, // Express.js
new ResumeSkill { SkillId = 33, UserId = Guid.Parse("5b68ad8c-f42e-40d7-87de-3622d34dcf84") }, // Ruby on Rails
new ResumeSkill { SkillId = 34, UserId = Guid.Parse("5b68ad8c-f42e-40d7-87de-3622d34dcf84") }, // Laravel
new ResumeSkill { SkillId = 35, UserId = Guid.Parse("5b68ad8c-f42e-40d7-87de-3622d34dcf84") }, // Symfony
new ResumeSkill { SkillId = 38, UserId = Guid.Parse("5b68ad8c-f42e-40d7-87de-3622d34dcf84") }, // Unity
new ResumeSkill { SkillId = 39, UserId = Guid.Parse("5b68ad8c-f42e-40d7-87de-3622d34dcf84") }, // TensorFlow
new ResumeSkill { SkillId = 40, UserId = Guid.Parse("5b68ad8c-f42e-40d7-87de-3622d34dcf84") }, // PyTorch

// Usuario: 597719b7-3036-4f95-92f8-5163b3e18931 (Jose Luis)
new ResumeSkill { SkillId = 1, UserId = Guid.Parse("597719b7-3036-4f95-92f8-5163b3e18931") }, // Java
new ResumeSkill { SkillId = 4, UserId = Guid.Parse("597719b7-3036-4f95-92f8-5163b3e18931") }, // Python
new ResumeSkill { SkillId = 2, UserId = Guid.Parse("597719b7-3036-4f95-92f8-5163b3e18931") }, // Javascript
new ResumeSkill { SkillId = 3, UserId = Guid.Parse("597719b7-3036-4f95-92f8-5163b3e18931") }, // C#
new ResumeSkill { SkillId = 5, UserId = Guid.Parse("597719b7-3036-4f95-92f8-5163b3e18931") }, // Ruby
new ResumeSkill { SkillId = 6, UserId = Guid.Parse("597719b7-3036-4f95-92f8-5163b3e18931") }, // PHP
new ResumeSkill { SkillId = 7, UserId = Guid.Parse("597719b7-3036-4f95-92f8-5163b3e18931") }, // Swift
new ResumeSkill { SkillId = 8, UserId = Guid.Parse("597719b7-3036-4f95-92f8-5163b3e18931") }, // Go
new ResumeSkill { SkillId = 9, UserId = Guid.Parse("597719b7-3036-4f95-92f8-5163b3e18931") }, // Rust
new ResumeSkill { SkillId = 10, UserId = Guid.Parse("597719b7-3036-4f95-92f8-5163b3e18931") }, // Kotlin

// Usuario: b9b2181b-d620-4db0-9561-9c1ba02480bb (Luis Fernandez)
new ResumeSkill { SkillId = 67, UserId = Guid.Parse("b9b2181b-d620-4db0-9561-9c1ba02480bb") }, // User Experience (UX) Design
new ResumeSkill { SkillId = 68, UserId = Guid.Parse("b9b2181b-d620-4db0-9561-9c1ba02480bb") }, // User Interface (UI) Design
new ResumeSkill { SkillId = 69, UserId = Guid.Parse("b9b2181b-d620-4db0-9561-9c1ba02480bb") }, // Wireframing
new ResumeSkill { SkillId = 70, UserId = Guid.Parse("b9b2181b-d620-4db0-9561-9c1ba02480bb") }, // Prototyping
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("b9b2181b-d620-4db0-9561-9c1ba02480bb") }, // Information Architecture
new ResumeSkill { SkillId = 72, UserId = Guid.Parse("b9b2181b-d620-4db0-9561-9c1ba02480bb") }, // Interaction Design
new ResumeSkill { SkillId = 73, UserId = Guid.Parse("b9b2181b-d620-4db0-9561-9c1ba02480bb") }, // Brand Identity
new ResumeSkill { SkillId = 74, UserId = Guid.Parse("b9b2181b-d620-4db0-9561-9c1ba02480bb") }, // Print Design
new ResumeSkill { SkillId = 75, UserId = Guid.Parse("b9b2181b-d620-4db0-9561-9c1ba02480bb") }, // Packaging Design
new ResumeSkill { SkillId = 76, UserId = Guid.Parse("b9b2181b-d620-4db0-9561-9c1ba02480bb") }, // Logo Design

// Usuario: 53a20833-f2ef-4cb7-a049-326d0cb255ad (Marta Rivera)
new ResumeSkill { SkillId = 27, UserId = Guid.Parse("53a20833-f2ef-4cb7-a049-326d0cb255ad") }, // React
new ResumeSkill { SkillId = 29, UserId = Guid.Parse("53a20833-f2ef-4cb7-a049-326d0cb255ad") }, // Vue.js
new ResumeSkill { SkillId = 28, UserId = Guid.Parse("53a20833-f2ef-4cb7-a049-326d0cb255ad") }, // Angular
new ResumeSkill { SkillId = 2, UserId = Guid.Parse("53a20833-f2ef-4cb7-a049-326d0cb255ad") }, // Javascript
new ResumeSkill { SkillId = 3, UserId = Guid.Parse("53a20833-f2ef-4cb7-a049-326d0cb255ad") }, // C#
new ResumeSkill { SkillId = 6, UserId = Guid.Parse("53a20833-f2ef-4cb7-a049-326d0cb255ad") }, // PHP
new ResumeSkill { SkillId = 10, UserId = Guid.Parse("53a20833-f2ef-4cb7-a049-326d0cb255ad") }, // Kotlin
new ResumeSkill { SkillId = 11, UserId = Guid.Parse("53a20833-f2ef-4cb7-a049-326d0cb255ad") }, // TypeScript
new ResumeSkill { SkillId = 12, UserId = Guid.Parse("53a20833-f2ef-4cb7-a049-326d0cb255ad") }, // C++
new ResumeSkill { SkillId = 17, UserId = Guid.Parse("53a20833-f2ef-4cb7-a049-326d0cb255ad") }, // Haskell

// Usuario: 3c36090f-464c-4c80-ac2b-e32ca07c44a9 (Miguel Sanchez)
new ResumeSkill { SkillId = 7, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a9") }, // Swift
new ResumeSkill { SkillId = 10, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a9") }, // Kotlin
new ResumeSkill { SkillId = 22, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a9") }, // Fortran
new ResumeSkill { SkillId = 23, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a9") }, // Assembly (x86, ARM)
new ResumeSkill { SkillId = 24, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a9") }, // .NET
new ResumeSkill { SkillId = 39, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a9") }, // TensorFlow
new ResumeSkill { SkillId = 40, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a9") }, // PyTorch
new ResumeSkill { SkillId = 45, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a9") }, // CorelDRAW
new ResumeSkill { SkillId = 46, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a9") }, // AutoCAD
new ResumeSkill { SkillId = 47, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a9") }, // Revit

// Usuario: ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978 (Laura Hernandez)
new ResumeSkill { SkillId = 62, UserId = Guid.Parse("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") }, // ZBrush
new ResumeSkill { SkillId = 63, UserId = Guid.Parse("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") }, // SketchUp
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") }, // Illustration
new ResumeSkill { SkillId = 65, UserId = Guid.Parse("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") }, // Typography
new ResumeSkill { SkillId = 66, UserId = Guid.Parse("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") }, // Digital Painting
new ResumeSkill { SkillId = 67, UserId = Guid.Parse("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") }, // User Experience (UX) Design
new ResumeSkill { SkillId = 68, UserId = Guid.Parse("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") }, // User Interface (UI) Design
new ResumeSkill { SkillId = 69, UserId = Guid.Parse("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") }, // Wireframing
new ResumeSkill { SkillId = 70, UserId = Guid.Parse("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") }, // Prototyping
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") }, // Information Architecture

// Usuario: 43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f (David Martin)
new ResumeSkill { SkillId = 1, UserId = Guid.Parse("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") }, // Java
new ResumeSkill { SkillId = 4, UserId = Guid.Parse("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") }, // Python
new ResumeSkill { SkillId = 30, UserId = Guid.Parse("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") }, // Node.js
new ResumeSkill { SkillId = 33, UserId = Guid.Parse("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") }, // Ruby on Rails
new ResumeSkill { SkillId = 5, UserId = Guid.Parse("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") }, // Ruby
new ResumeSkill { SkillId = 6, UserId = Guid.Parse("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") }, // PHP
new ResumeSkill { SkillId = 7, UserId = Guid.Parse("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") }, // Swift
new ResumeSkill { SkillId = 8, UserId = Guid.Parse("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") }, // Go
new ResumeSkill { SkillId = 9, UserId = Guid.Parse("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") }, // Rust
new ResumeSkill { SkillId = 10, UserId = Guid.Parse("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") }, // Kotlin

// Usuario: b0c0659c-a57a-4acb-a906-5e3bf9ab2675 (Sara Perez)
new ResumeSkill { SkillId = 56, UserId = Guid.Parse("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") }, // Adobe Premiere Pro
new ResumeSkill { SkillId = 57, UserId = Guid.Parse("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") }, // Final Cut Pro
new ResumeSkill { SkillId = 58, UserId = Guid.Parse("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") }, // Avid Media Composer
new ResumeSkill { SkillId = 59, UserId = Guid.Parse("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") }, // Blender
new ResumeSkill { SkillId = 60, UserId = Guid.Parse("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") }, // Maya
new ResumeSkill { SkillId = 61, UserId = Guid.Parse("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") }, // 3ds Max
new ResumeSkill { SkillId = 62, UserId = Guid.Parse("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") }, // ZBrush
new ResumeSkill { SkillId = 63, UserId = Guid.Parse("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") }, // SketchUp
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") }, // Illustration
new ResumeSkill { SkillId = 65, UserId = Guid.Parse("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") }, // Typography

// Usuario: 55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8 (Juan Carlos)
new ResumeSkill { SkillId = 7, UserId = Guid.Parse("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") }, // Swift
new ResumeSkill { SkillId = 10, UserId = Guid.Parse("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") }, // Kotlin
new ResumeSkill { SkillId = 29, UserId = Guid.Parse("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") }, // Vue.js
new ResumeSkill { SkillId = 30, UserId = Guid.Parse("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") }, // Node.js
new ResumeSkill { SkillId = 37, UserId = Guid.Parse("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") }, // Xamarin
new ResumeSkill { SkillId = 38, UserId = Guid.Parse("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") }, // Unity
new ResumeSkill { SkillId = 47, UserId = Guid.Parse("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") }, // Revit
new ResumeSkill { SkillId = 48, UserId = Guid.Parse("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") }, // Legal Research
new ResumeSkill { SkillId = 49, UserId = Guid.Parse("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") }, // Litigation
new ResumeSkill { SkillId = 50, UserId = Guid.Parse("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") }, // Contract Drafting

// Usuario: 35a26eb2-c01c-4df3-b98d-40561190ae36 (Carmen Lopez)
new ResumeSkill { SkillId = 75, UserId = Guid.Parse("35a26eb2-c01c-4df3-b98d-40561190ae36") }, // Packaging Design
new ResumeSkill { SkillId = 76, UserId = Guid.Parse("35a26eb2-c01c-4df3-b98d-40561190ae36") }, // Logo Design
new ResumeSkill { SkillId = 77, UserId = Guid.Parse("35a26eb2-c01c-4df3-b98d-40561190ae36") }, // Motion Graphics
new ResumeSkill { SkillId = 78, UserId = Guid.Parse("35a26eb2-c01c-4df3-b98d-40561190ae36") }, // 2D Animation
new ResumeSkill { SkillId = 79, UserId = Guid.Parse("35a26eb2-c01c-4df3-b98d-40561190ae36") }, // 3D Animation
new ResumeSkill { SkillId = 80, UserId = Guid.Parse("35a26eb2-c01c-4df3-b98d-40561190ae36") }, // Character Animation
new ResumeSkill { SkillId = 81, UserId = Guid.Parse("35a26eb2-c01c-4df3-b98d-40561190ae36") }, // Legal Writing
new ResumeSkill { SkillId = 82, UserId = Guid.Parse("35a26eb2-c01c-4df3-b98d-40561190ae36") }, // Corporate Law
new ResumeSkill { SkillId = 83, UserId = Guid.Parse("35a26eb2-c01c-4df3-b98d-40561190ae36") }, // Intellectual Property Law
new ResumeSkill { SkillId = 84, UserId = Guid.Parse("35a26eb2-c01c-4df3-b98d-40561190ae36") }, // Family Law

// Usuario: cd88e529-eedb-42c5-a88d-384f5976a754 (Pablo Martinez)
new ResumeSkill { SkillId = 62, UserId = Guid.Parse("cd88e529-eedb-42c5-a88d-384f5976a754") }, // ZBrush
new ResumeSkill { SkillId = 63, UserId = Guid.Parse("cd88e529-eedb-42c5-a88d-384f5976a754") }, // SketchUp
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("cd88e529-eedb-42c5-a88d-384f5976a754") }, // Illustration
new ResumeSkill { SkillId = 65, UserId = Guid.Parse("cd88e529-eedb-42c5-a88d-384f5976a754") }, // Typography
new ResumeSkill { SkillId = 66, UserId = Guid.Parse("cd88e529-eedb-42c5-a88d-384f5976a754") }, // Digital Painting
new ResumeSkill { SkillId = 67, UserId = Guid.Parse("cd88e529-eedb-42c5-a88d-384f5976a754") }, // User Experience (UX) Design
new ResumeSkill { SkillId = 68, UserId = Guid.Parse("cd88e529-eedb-42c5-a88d-384f5976a754") }, // User Interface (UI) Design
new ResumeSkill { SkillId = 69, UserId = Guid.Parse("cd88e529-eedb-42c5-a88d-384f5976a754") }, // Wireframing
new ResumeSkill { SkillId = 70, UserId = Guid.Parse("cd88e529-eedb-42c5-a88d-384f5976a754") }, // Prototyping
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("cd88e529-eedb-42c5-a88d-384f5976a754") }, // Information Architecture

// Usuario: 0835e1cc-d304-4b61-9b58-135ab2d27b3f (Gloria Ramos)
new ResumeSkill { SkillId = 51, UserId = Guid.Parse("0835e1cc-d304-4b61-9b58-135ab2d27b3f") }, // Microsoft Office
new ResumeSkill { SkillId = 52, UserId = Guid.Parse("0835e1cc-d304-4b61-9b58-135ab2d27b3f") }, // Excel
new ResumeSkill { SkillId = 53, UserId = Guid.Parse("0835e1cc-d304-4b61-9b58-135ab2d27b3f") }, // Word
new ResumeSkill { SkillId = 54, UserId = Guid.Parse("0835e1cc-d304-4b61-9b58-135ab2d27b3f") }, // PowerPoint
new ResumeSkill { SkillId = 55, UserId = Guid.Parse("0835e1cc-d304-4b61-9b58-135ab2d27b3f") }, // Outlook
new ResumeSkill { SkillId = 57, UserId = Guid.Parse("0835e1cc-d304-4b61-9b58-135ab2d27b3f") }, // Final Cut Pro
new ResumeSkill { SkillId = 58, UserId = Guid.Parse("0835e1cc-d304-4b61-9b58-135ab2d27b3f") }, // Avid Media Composer
new ResumeSkill { SkillId = 59, UserId = Guid.Parse("0835e1cc-d304-4b61-9b58-135ab2d27b3f") }, // Blender
new ResumeSkill { SkillId = 60, UserId = Guid.Parse("0835e1cc-d304-4b61-9b58-135ab2d27b3f") }, // Maya
new ResumeSkill { SkillId = 61, UserId = Guid.Parse("0835e1cc-d304-4b61-9b58-135ab2d27b3f") }, // 3ds Max

// Usuario: 944cbcf3-7479-4eed-97f1-80fd4c50eda6 (Antonio Alvarez)
new ResumeSkill { SkillId = 27, UserId = Guid.Parse("944cbcf3-7479-4eed-97f1-80fd4c50eda6") }, // React
new ResumeSkill { SkillId = 28, UserId = Guid.Parse("944cbcf3-7479-4eed-97f1-80fd4c50eda6") }, // Angular
new ResumeSkill { SkillId = 29, UserId = Guid.Parse("944cbcf3-7479-4eed-97f1-80fd4c50eda6") }, // Vue.js
new ResumeSkill { SkillId = 30, UserId = Guid.Parse("944cbcf3-7479-4eed-97f1-80fd4c50eda6") }, // Node.js
new ResumeSkill { SkillId = 31, UserId = Guid.Parse("944cbcf3-7479-4eed-97f1-80fd4c50eda6") }, // Express.js
new ResumeSkill { SkillId = 32, UserId = Guid.Parse("944cbcf3-7479-4eed-97f1-80fd4c50eda6") }, // Flask
new ResumeSkill { SkillId = 33, UserId = Guid.Parse("944cbcf3-7479-4eed-97f1-80fd4c50eda6") }, // Ruby on Rails
new ResumeSkill { SkillId = 34, UserId = Guid.Parse("944cbcf3-7479-4eed-97f1-80fd4c50eda6") }, // Laravel
new ResumeSkill { SkillId = 35, UserId = Guid.Parse("944cbcf3-7479-4eed-97f1-80fd4c50eda6") }, // Symfony
new ResumeSkill { SkillId = 36, UserId = Guid.Parse("944cbcf3-7479-4eed-97f1-80fd4c50eda6") }, // Hibernate

// Usuario: cca9654e-d839-4e21-a23d-01fbb75e0a26 (Patricia Flores)
new ResumeSkill { SkillId = 74, UserId = Guid.Parse("cca9654e-d839-4e21-a23d-01fbb75e0a26") }, // Print Design
new ResumeSkill { SkillId = 75, UserId = Guid.Parse("cca9654e-d839-4e21-a23d-01fbb75e0a26") }, // Packaging Design
new ResumeSkill { SkillId = 76, UserId = Guid.Parse("cca9654e-d839-4e21-a23d-01fbb75e0a26") }, // Logo Design
new ResumeSkill { SkillId = 77, UserId = Guid.Parse("cca9654e-d839-4e21-a23d-01fbb75e0a26") }, // Motion Graphics
new ResumeSkill { SkillId = 78, UserId = Guid.Parse("cca9654e-d839-4e21-a23d-01fbb75e0a26") }, // 2D Animation
new ResumeSkill { SkillId = 79, UserId = Guid.Parse("cca9654e-d839-4e21-a23d-01fbb75e0a26") }, // 3D Animation
new ResumeSkill { SkillId = 80, UserId = Guid.Parse("cca9654e-d839-4e21-a23d-01fbb75e0a26") }, // Character Animation
new ResumeSkill { SkillId = 81, UserId = Guid.Parse("cca9654e-d839-4e21-a23d-01fbb75e0a26") }, // Legal Writing
new ResumeSkill { SkillId = 82, UserId = Guid.Parse("cca9654e-d839-4e21-a23d-01fbb75e0a26") }, // Corporate Law
new ResumeSkill { SkillId = 83, UserId = Guid.Parse("cca9654e-d839-4e21-a23d-01fbb75e0a26") }, // Intellectual Property Law

// Usuario: f3952051-fbde-4d44-a9b7-c3cb54027090 (Andres Romero)
new ResumeSkill { SkillId = 84, UserId = Guid.Parse("f3952051-fbde-4d44-a9b7-c3cb54027090") }, // Adobe Premiere Pro
new ResumeSkill { SkillId = 85, UserId = Guid.Parse("f3952051-fbde-4d44-a9b7-c3cb54027090") }, // Adobe After Effects
new ResumeSkill { SkillId = 86, UserId = Guid.Parse("f3952051-fbde-4d44-a9b7-c3cb54027090") }, // Cinema 4D
new ResumeSkill { SkillId = 87, UserId = Guid.Parse("f3952051-fbde-4d44-a9b7-c3cb54027090") }, // DaVinci Resolve
new ResumeSkill { SkillId = 88, UserId = Guid.Parse("f3952051-fbde-4d44-a9b7-c3cb54027090") }, // Logic Pro X
new ResumeSkill { SkillId = 89, UserId = Guid.Parse("f3952051-fbde-4d44-a9b7-c3cb54027090") }, // Pro Tools
new ResumeSkill { SkillId = 90, UserId = Guid.Parse("f3952051-fbde-4d44-a9b7-c3cb54027090") }, // Ableton Live
new ResumeSkill { SkillId = 91, UserId = Guid.Parse("f3952051-fbde-4d44-a9b7-c3cb54027090") }, // FL Studio
new ResumeSkill { SkillId = 92, UserId = Guid.Parse("f3952051-fbde-4d44-a9b7-c3cb54027090") }, // Reaper
new ResumeSkill { SkillId = 93, UserId = Guid.Parse("f3952051-fbde-4d44-a9b7-c3cb54027090") }, // Cubase

// Usuario: 7e246319-564e-4920-bd8c-6029be2a7729 (Elena Diaz)
new ResumeSkill { SkillId = 94, UserId = Guid.Parse("7e246319-564e-4920-bd8c-6029be2a7729") }, // Google Analytics
new ResumeSkill { SkillId = 95, UserId = Guid.Parse("7e246319-564e-4920-bd8c-6029be2a7729") }, // SEO
new ResumeSkill { SkillId = 96, UserId = Guid.Parse("7e246319-564e-4920-bd8c-6029be2a7729") }, // SEM
new ResumeSkill { SkillId = 97, UserId = Guid.Parse("7e246319-564e-4920-bd8c-6029be2a7729") }, // Content Marketing
new ResumeSkill { SkillId = 98, UserId = Guid.Parse("7e246319-564e-4920-bd8c-6029be2a7729") }, // Email Marketing
new ResumeSkill { SkillId = 99, UserId = Guid.Parse("7e246319-564e-4920-bd8c-6029be2a7729") }, // Social Media Marketing
new ResumeSkill { SkillId = 100, UserId = Guid.Parse("7e246319-564e-4920-bd8c-6029be2a7729") }, // Influencer Marketing
new ResumeSkill { SkillId = 101, UserId = Guid.Parse("7e246319-564e-4920-bd8c-6029be2a7729") }, // Web Analytics
new ResumeSkill { SkillId = 102, UserId = Guid.Parse("7e246319-564e-4920-bd8c-6029be2a7729") }, // Social Media Analytics
new ResumeSkill { SkillId = 103, UserId = Guid.Parse("7e246319-564e-4920-bd8c-6029be2a7729") }, // Copywriting

// Usuario: ba694638-8e1c-4398-a3db-50b879ea1414 (Roberto Hidalgo)
new ResumeSkill { SkillId = 104, UserId = Guid.Parse("ba694638-8e1c-4398-a3db-50b879ea1414") }, // AWS
new ResumeSkill { SkillId = 105, UserId = Guid.Parse("ba694638-8e1c-4398-a3db-50b879ea1414") }, // Azure
new ResumeSkill { SkillId = 106, UserId = Guid.Parse("ba694638-8e1c-4398-a3db-50b879ea1414") }, // Google Cloud Platform
new ResumeSkill { SkillId = 107, UserId = Guid.Parse("ba694638-8e1c-4398-a3db-50b879ea1414") }, // Docker
new ResumeSkill { SkillId = 108, UserId = Guid.Parse("ba694638-8e1c-4398-a3db-50b879ea1414") }, // Kubernetes
new ResumeSkill { SkillId = 109, UserId = Guid.Parse("ba694638-8e1c-4398-a3db-50b879ea1414") }, // Jenkins
new ResumeSkill { SkillId = 110, UserId = Guid.Parse("ba694638-8e1c-4398-a3db-50b879ea1414") }, // Terraform
new ResumeSkill { SkillId = 111, UserId = Guid.Parse("ba694638-8e1c-4398-a3db-50b879ea1414") }, // Ansible
new ResumeSkill { SkillId = 112, UserId = Guid.Parse("ba694638-8e1c-4398-a3db-50b879ea1414") }, // Puppet
new ResumeSkill { SkillId = 113, UserId = Guid.Parse("ba694638-8e1c-4398-a3db-50b879ea1414") }, // Chef

// Usuario: 2f5c9c2f-de8c-4396-90af-534f4e163439 (Pedro Gomez)
new ResumeSkill { SkillId = 3, UserId = Guid.Parse("2f5c9c2f-de8c-4396-90af-534f4e163439") }, // C#
new ResumeSkill { SkillId = 24, UserId = Guid.Parse("2f5c9c2f-de8c-4396-90af-534f4e163439") }, // .NET
new ResumeSkill { SkillId = 1, UserId = Guid.Parse("2f5c9c2f-de8c-4396-90af-534f4e163439") }, // Java
new ResumeSkill { SkillId = 4, UserId = Guid.Parse("2f5c9c2f-de8c-4396-90af-534f4e163439") }, // Python
new ResumeSkill { SkillId = 5, UserId = Guid.Parse("2f5c9c2f-de8c-4396-90af-534f4e163439") }, // Ruby
new ResumeSkill { SkillId = 7, UserId = Guid.Parse("2f5c9c2f-de8c-4396-90af-534f4e163439") }, // Swift
new ResumeSkill { SkillId = 11, UserId = Guid.Parse("2f5c9c2f-de8c-4396-90af-534f4e163439") }, // TypeScript
new ResumeSkill { SkillId = 13, UserId = Guid.Parse("2f5c9c2f-de8c-4396-90af-534f4e163439") }, // Scala
new ResumeSkill { SkillId = 16, UserId = Guid.Parse("2f5c9c2f-de8c-4396-90af-534f4e163439") }, // MATLAB
new ResumeSkill { SkillId = 20, UserId = Guid.Parse("2f5c9c2f-de8c-4396-90af-534f4e163439") }, // Prolog

// Usuario: b2269673-9d47-471a-a958-24160608ae82 (Isabel Hernandez)
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("b2269673-9d47-471a-a958-24160608ae82") }, // Illustration
new ResumeSkill { SkillId = 65, UserId = Guid.Parse("b2269673-9d47-471a-a958-24160608ae82") }, // Typography
new ResumeSkill { SkillId = 62, UserId = Guid.Parse("b2269673-9d47-471a-a958-24160608ae82") }, // ZBrush
new ResumeSkill { SkillId = 59, UserId = Guid.Parse("b2269673-9d47-471a-a958-24160608ae82") }, // Blender
new ResumeSkill { SkillId = 70, UserId = Guid.Parse("b2269673-9d47-471a-a958-24160608ae82") }, // Prototyping
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("b2269673-9d47-471a-a958-24160608ae82") }, // Information Architecture
new ResumeSkill { SkillId = 68, UserId = Guid.Parse("b2269673-9d47-471a-a958-24160608ae82") }, // User Interface (UI) Design
new ResumeSkill { SkillId = 69, UserId = Guid.Parse("b2269673-9d47-471a-a958-24160608ae82") }, // Wireframing
new ResumeSkill { SkillId = 73, UserId = Guid.Parse("b2269673-9d47-471a-a958-24160608ae82") }, // Brand Identity
new ResumeSkill { SkillId = 76, UserId = Guid.Parse("b2269673-9d47-471a-a958-24160608ae82") }, // Logo Design

// Usuario: bb491436-8b44-4049-8f28-60b5689b6fd7 (Rafael Martinez)
new ResumeSkill { SkillId = 81, UserId = Guid.Parse("bb491436-8b44-4049-8f28-60b5689b6fd7") }, // Legal Writing
new ResumeSkill { SkillId = 82, UserId = Guid.Parse("bb491436-8b44-4049-8f28-60b5689b6fd7") }, // Corporate Law
new ResumeSkill { SkillId = 83, UserId = Guid.Parse("bb491436-8b44-4049-8f28-60b5689b6fd7") }, // Intellectual Property Law
new ResumeSkill { SkillId = 84, UserId = Guid.Parse("bb491436-8b44-4049-8f28-60b5689b6fd7") }, // Family Law
new ResumeSkill { SkillId = 85, UserId = Guid.Parse("bb491436-8b44-4049-8f28-60b5689b6fd7") }, // Environmental Law
new ResumeSkill { SkillId = 86, UserId = Guid.Parse("bb491436-8b44-4049-8f28-60b5689b6fd7") }, // Immigration Law
new ResumeSkill { SkillId = 87, UserId = Guid.Parse("bb491436-8b44-4049-8f28-60b5689b6fd7") }, // Real Estate Law
new ResumeSkill { SkillId = 88, UserId = Guid.Parse("bb491436-8b44-4049-8f28-60b5689b6fd7") }, // Bankruptcy Law
new ResumeSkill { SkillId = 89, UserId = Guid.Parse("bb491436-8b44-4049-8f28-60b5689b6fd7") }, // Criminal Law
new ResumeSkill { SkillId = 90, UserId = Guid.Parse("bb491436-8b44-4049-8f28-60b5689b6fd7") }, // Health Law

// Usuario: 525d6c44-e75c-466a-9510-fb4c0d8f28d1 (Ana Maria)
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("525d6c44-e75c-466a-9510-fb4c0d8f28d1") }, // Illustration
new ResumeSkill { SkillId = 65, UserId = Guid.Parse("525d6c44-e75c-466a-9510-fb4c0d8f28d1") }, // Typography
new ResumeSkill { SkillId = 73, UserId = Guid.Parse("525d6c44-e75c-466a-9510-fb4c0d8f28d1") }, // Brand Identity
new ResumeSkill { SkillId = 76, UserId = Guid.Parse("525d6c44-e75c-466a-9510-fb4c0d8f28d1") }, // Logo Design
new ResumeSkill { SkillId = 77, UserId = Guid.Parse("525d6c44-e75c-466a-9510-fb4c0d8f28d1") }, // Motion Graphics
new ResumeSkill { SkillId = 78, UserId = Guid.Parse("525d6c44-e75c-466a-9510-fb4c0d8f28d1") }, // 2D Animation
new ResumeSkill { SkillId = 79, UserId = Guid.Parse("525d6c44-e75c-466a-9510-fb4c0d8f28d1") }, // 3D Animation
new ResumeSkill { SkillId = 80, UserId = Guid.Parse("525d6c44-e75c-466a-9510-fb4c0d8f28d1") }, // Character Animation
new ResumeSkill { SkillId = 83, UserId = Guid.Parse("525d6c44-e75c-466a-9510-fb4c0d8f28d1") }, // Intellectual Property Law
new ResumeSkill { SkillId = 84, UserId = Guid.Parse("525d6c44-e75c-466a-9510-fb4c0d8f28d1") }, // Family Law

// Usuario: 6d46504c-1a72-4036-98e3-3434676e05bb (Juan Antonio)
new ResumeSkill { SkillId = 30, UserId = Guid.Parse("6d46504c-1a72-4036-98e3-3434676e05bb") }, // Node.js
new ResumeSkill { SkillId = 32, UserId = Guid.Parse("6d46504c-1a72-4036-98e3-3434676e05bb") }, // Flask
new ResumeSkill { SkillId = 34, UserId = Guid.Parse("6d46504c-1a72-4036-98e3-3434676e05bb") }, // Laravel
new ResumeSkill { SkillId = 36, UserId = Guid.Parse("6d46504c-1a72-4036-98e3-3434676e05bb") }, // Hibernate
new ResumeSkill { SkillId = 37, UserId = Guid.Parse("6d46504c-1a72-4036-98e3-3434676e05bb") }, // Xamarin
new ResumeSkill { SkillId = 38, UserId = Guid.Parse("6d46504c-1a72-4036-98e3-3434676e05bb") }, // Unity
new ResumeSkill { SkillId = 39, UserId = Guid.Parse("6d46504c-1a72-4036-98e3-3434676e05bb") }, // TensorFlow
new ResumeSkill { SkillId = 40, UserId = Guid.Parse("6d46504c-1a72-4036-98e3-3434676e05bb") }, // PyTorch
new ResumeSkill { SkillId = 41, UserId = Guid.Parse("6d46504c-1a72-4036-98e3-3434676e05bb") }, // Adobe Photoshop
new ResumeSkill { SkillId = 42, UserId = Guid.Parse("6d46504c-1a72-4036-98e3-3434676e05bb") }, // Adobe Illustrator

// Usuario: 6ca18a54-6c7b-46af-b298-fa756919a4f1 (Sofia Gonzalez)
new ResumeSkill { SkillId = 51, UserId = Guid.Parse("6ca18a54-6c7b-46af-b298-fa756919a4f1") }, // Microsoft Office
new ResumeSkill { SkillId = 52, UserId = Guid.Parse("6ca18a54-6c7b-46af-b298-fa756919a4f1") }, // Excel
new ResumeSkill { SkillId = 53, UserId = Guid.Parse("6ca18a54-6c7b-46af-b298-fa756919a4f1") }, // Word
new ResumeSkill { SkillId = 54, UserId = Guid.Parse("6ca18a54-6c7b-46af-b298-fa756919a4f1") }, // PowerPoint
new ResumeSkill { SkillId = 55, UserId = Guid.Parse("6ca18a54-6c7b-46af-b298-fa756919a4f1") }, // Outlook
new ResumeSkill { SkillId = 92, UserId = Guid.Parse("6ca18a54-6c7b-46af-b298-fa756919a4f1") }, // International Law
new ResumeSkill { SkillId = 93, UserId = Guid.Parse("6ca18a54-6c7b-46af-b298-fa756919a4f1") }, // Administrative Law
new ResumeSkill { SkillId = 94, UserId = Guid.Parse("6ca18a54-6c7b-46af-b298-fa756919a4f1") }, // Legal Compliance
new ResumeSkill { SkillId = 95, UserId = Guid.Parse("6ca18a54-6c7b-46af-b298-fa756919a4f1") }, // Legal Consulting
new ResumeSkill { SkillId = 96, UserId = Guid.Parse("6ca18a54-6c7b-46af-b298-fa756919a4f1") }, // Legal Research

// Usuario: 347c951c-16c5-4043-bedc-a847c40fcb7f (Alejandro)
new ResumeSkill { SkillId = 46, UserId = Guid.Parse("347c951c-16c5-4043-bedc-a847c40fcb7f") }, // AutoCAD
new ResumeSkill { SkillId = 47, UserId = Guid.Parse("347c951c-16c5-4043-bedc-a847c40fcb7f") }, // Revit
new ResumeSkill { SkillId = 59, UserId = Guid.Parse("347c951c-16c5-4043-bedc-a847c40fcb7f") }, // Blender
new ResumeSkill { SkillId = 61, UserId = Guid.Parse("347c951c-16c5-4043-bedc-a847c40fcb7f") }, // 3ds Max
new ResumeSkill { SkillId = 62, UserId = Guid.Parse("347c951c-16c5-4043-bedc-a847c40fcb7f") }, // ZBrush
new ResumeSkill { SkillId = 67, UserId = Guid.Parse("347c951c-16c5-4043-bedc-a847c40fcb7f") }, // User Experience (UX) Design
new ResumeSkill { SkillId = 68, UserId = Guid.Parse("347c951c-16c5-4043-bedc-a847c40fcb7f") }, // User Interface (UI) Design
new ResumeSkill { SkillId = 70, UserId = Guid.Parse("347c951c-16c5-4043-bedc-a847c40fcb7f") }, // Prototyping
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("347c951c-16c5-4043-bedc-a847c40fcb7f") }, // Information Architecture
new ResumeSkill { SkillId = 72, UserId = Guid.Parse("347c951c-16c5-4043-bedc-a847c40fcb7f") }, // Interaction Design

// Usuario: 3e0f155c-6f59-4214-a4e4-2d992447488f (Lucia Ramos)
new ResumeSkill { SkillId = 56, UserId = Guid.Parse("3e0f155c-6f59-4214-a4e4-2d992447488f") }, // Adobe Premiere Pro
new ResumeSkill { SkillId = 57, UserId = Guid.Parse("3e0f155c-6f59-4214-a4e4-2d992447488f") }, // Final Cut Pro
new ResumeSkill { SkillId = 58, UserId = Guid.Parse("3e0f155c-6f59-4214-a4e4-2d992447488f") }, // Avid Media Composer
new ResumeSkill { SkillId = 77, UserId = Guid.Parse("3e0f155c-6f59-4214-a4e4-2d992447488f") }, // Motion Graphics
new ResumeSkill { SkillId = 78, UserId = Guid.Parse("3e0f155c-6f59-4214-a4e4-2d992447488f") }, // 2D Animation
new ResumeSkill { SkillId = 79, UserId = Guid.Parse("3e0f155c-6f59-4214-a4e4-2d992447488f") }, // 3D Animation
new ResumeSkill { SkillId = 80, UserId = Guid.Parse("3e0f155c-6f59-4214-a4e4-2d992447488f") }, // Character Animation
new ResumeSkill { SkillId = 94, UserId = Guid.Parse("3e0f155c-6f59-4214-a4e4-2d992447488f") }, // Legal Compliance
new ResumeSkill { SkillId = 95, UserId = Guid.Parse("3e0f155c-6f59-4214-a4e4-2d992447488f") }, // Legal Consulting
new ResumeSkill { SkillId = 97, UserId = Guid.Parse("3e0f155c-6f59-4214-a4e4-2d992447488f") }, // Legal Writing

// Usuario: 4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f (Diego López)
new ResumeSkill { SkillId = 41, UserId = Guid.Parse("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") }, // Adobe Photoshop
new ResumeSkill { SkillId = 77, UserId = Guid.Parse("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") }, // Motion Graphics
new ResumeSkill { SkillId = 76, UserId = Guid.Parse("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") }, // Logo Design
new ResumeSkill { SkillId = 78, UserId = Guid.Parse("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") }, // 2D Animation
new ResumeSkill { SkillId = 91, UserId = Guid.Parse("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") }, // Tax Law
new ResumeSkill { SkillId = 92, UserId = Guid.Parse("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") }, // International Law
new ResumeSkill { SkillId = 93, UserId = Guid.Parse("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") }, // Administrative Law
new ResumeSkill { SkillId = 94, UserId = Guid.Parse("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") }, // Legal Compliance
new ResumeSkill { SkillId = 95, UserId = Guid.Parse("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") }, // Legal Consulting
new ResumeSkill { SkillId = 96, UserId = Guid.Parse("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") }, // Legal Research

// Usuario: c2c1137a-2957-489a-b6bc-a520a28c3206 (Paula Pérez)
new ResumeSkill { SkillId = 81, UserId = Guid.Parse("c2c1137a-2957-489a-b6bc-a520a28c3206") }, // Legal Writing
new ResumeSkill { SkillId = 82, UserId = Guid.Parse("c2c1137a-2957-489a-b6bc-a520a28c3206") }, // Corporate Law
new ResumeSkill { SkillId = 83, UserId = Guid.Parse("c2c1137a-2957-489a-b6bc-a520a28c3206") }, // Intellectual Property Law
new ResumeSkill { SkillId = 84, UserId = Guid.Parse("c2c1137a-2957-489a-b6bc-a520a28c3206") }, // Family Law
new ResumeSkill { SkillId = 94, UserId = Guid.Parse("c2c1137a-2957-489a-b6bc-a520a28c3206") }, // Legal Compliance
new ResumeSkill { SkillId = 95, UserId = Guid.Parse("c2c1137a-2957-489a-b6bc-a520a28c3206") }, // Legal Consulting
new ResumeSkill { SkillId = 96, UserId = Guid.Parse("c2c1137a-2957-489a-b6bc-a520a28c3206") }, // Legal Research
new ResumeSkill { SkillId = 97, UserId = Guid.Parse("c2c1137a-2957-489a-b6bc-a520a28c3206") }, // Legal Writing
new ResumeSkill { SkillId = 98, UserId = Guid.Parse("c2c1137a-2957-489a-b6bc-a520a28c3206") }, // Legal Analysis
new ResumeSkill { SkillId = 99, UserId = Guid.Parse("c2c1137a-2957-489a-b6bc-a520a28c3206") }, // Legal Documentation

// Usuario: ccedb55a-6010-4ec9-913b-caa122d34ba7 (Roberto Morales)
new ResumeSkill { SkillId = 23, UserId = Guid.Parse("ccedb55a-6010-4ec9-913b-caa122d34ba7") }, // Assembly (x86, ARM)
new ResumeSkill { SkillId = 45, UserId = Guid.Parse("ccedb55a-6010-4ec9-913b-caa122d34ba7") }, // CorelDRAW
new ResumeSkill { SkillId = 46, UserId = Guid.Parse("ccedb55a-6010-4ec9-913b-caa122d34ba7") }, // AutoCAD
new ResumeSkill { SkillId = 47, UserId = Guid.Parse("ccedb55a-6010-4ec9-913b-caa122d34ba7") }, // Revit
new ResumeSkill { SkillId = 61, UserId = Guid.Parse("ccedb55a-6010-4ec9-913b-caa122d34ba7") }, // 3ds Max
new ResumeSkill { SkillId = 67, UserId = Guid.Parse("ccedb55a-6010-4ec9-913b-caa122d34ba7") }, // User Experience (UX) Design
new ResumeSkill { SkillId = 68, UserId = Guid.Parse("ccedb55a-6010-4ec9-913b-caa122d34ba7") }, // User Interface (UI) Design
new ResumeSkill { SkillId = 69, UserId = Guid.Parse("ccedb55a-6010-4ec9-913b-caa122d34ba7") }, // Wireframing
new ResumeSkill { SkillId = 70, UserId = Guid.Parse("ccedb55a-6010-4ec9-913b-caa122d34ba7") }, // Prototyping
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("ccedb55a-6010-4ec9-913b-caa122d34ba7") }, // Information Architecture

// Usuario: c9ea88e7-aba3-4aa3-8dd7-0977a84004c9 (Teresa Díaz)
new ResumeSkill { SkillId = 67, UserId = Guid.Parse("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") }, // User Experience (UX) Design
new ResumeSkill { SkillId = 68, UserId = Guid.Parse("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") }, // User Interface (UI) Design
new ResumeSkill { SkillId = 69, UserId = Guid.Parse("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") }, // Wireframing
new ResumeSkill { SkillId = 70, UserId = Guid.Parse("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") }, // Prototyping
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") }, // Information Architecture
new ResumeSkill { SkillId = 72, UserId = Guid.Parse("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") }, // Interaction Design
new ResumeSkill { SkillId = 73, UserId = Guid.Parse("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") }, // Brand Identity
new ResumeSkill { SkillId = 74, UserId = Guid.Parse("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") }, // Print Design
new ResumeSkill { SkillId = 75, UserId = Guid.Parse("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") }, // Packaging Design
new ResumeSkill { SkillId = 76, UserId = Guid.Parse("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") }, // Logo Design

// Usuario: 3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b (José Manuel - Contador Público)
new ResumeSkill { SkillId = 51, UserId = Guid.Parse("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") }, // Microsoft Office
new ResumeSkill { SkillId = 52, UserId = Guid.Parse("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") }, // Excel
new ResumeSkill { SkillId = 53, UserId = Guid.Parse("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") }, // Word
new ResumeSkill { SkillId = 54, UserId = Guid.Parse("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") }, // PowerPoint
new ResumeSkill { SkillId = 55, UserId = Guid.Parse("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") }, // Outlook
new ResumeSkill { SkillId = 94, UserId = Guid.Parse("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") }, // Legal Compliance
new ResumeSkill { SkillId = 95, UserId = Guid.Parse("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") }, // Legal Consulting
new ResumeSkill { SkillId = 96, UserId = Guid.Parse("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") }, // Legal Research
new ResumeSkill { SkillId = 97, UserId = Guid.Parse("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") }, // Legal Writing
new ResumeSkill { SkillId = 98, UserId = Guid.Parse("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") }, // Legal Analysis

// Usuario: 4a6b6c16-1593-4425-935c-d2ddc3c8eef5 (Adriana Pérez - Diseñadora Gráfica)
new ResumeSkill { SkillId = 42, UserId = Guid.Parse("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") }, // Adobe Illustrator
new ResumeSkill { SkillId = 43, UserId = Guid.Parse("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") }, // Adobe InDesign
new ResumeSkill { SkillId = 44, UserId = Guid.Parse("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") }, // Sketch
new ResumeSkill { SkillId = 46, UserId = Guid.Parse("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") }, // AutoCAD
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") }, // Illustration
new ResumeSkill { SkillId = 67, UserId = Guid.Parse("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") }, // User Experience (UX) Design
new ResumeSkill { SkillId = 68, UserId = Guid.Parse("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") }, // User Interface (UI) Design
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") }, // Information Architecture
new ResumeSkill { SkillId = 76, UserId = Guid.Parse("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") }, // Logo Design
new ResumeSkill { SkillId = 77, UserId = Guid.Parse("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") }, // Motion Graphics

// Usuario: 3c36090f-464c-4c80-ac2b-e32ca07c44a4 (Francisco - Ingeniero de Software)
new ResumeSkill { SkillId = 2, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a4") }, // Javascript
new ResumeSkill { SkillId = 3, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a4") }, // C#
new ResumeSkill { SkillId = 4, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a4") }, // Python
new ResumeSkill { SkillId = 9, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a4") }, // Rust
new ResumeSkill { SkillId = 10, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a4") }, // Kotlin
new ResumeSkill { SkillId = 30, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a4") }, // Node.js
new ResumeSkill { SkillId = 31, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a4") }, // Express.js
new ResumeSkill { SkillId = 39, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a4") }, // TensorFlow
new ResumeSkill { SkillId = 40, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a4") }, // PyTorch
new ResumeSkill { SkillId = 78, UserId = Guid.Parse("3c36090f-464c-4c80-ac2b-e32ca07c44a4") }, // 2D Animation

// Usuario: 92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2 (Mónica García - Psicóloga Clínica)
new ResumeSkill { SkillId = 81, UserId = Guid.Parse("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") }, // Legal Writing
new ResumeSkill { SkillId = 82, UserId = Guid.Parse("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") }, // Corporate Law
new ResumeSkill { SkillId = 83, UserId = Guid.Parse("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") }, // Intellectual Property Law
new ResumeSkill { SkillId = 86, UserId = Guid.Parse("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") }, // Immigration Law
new ResumeSkill { SkillId = 89, UserId = Guid.Parse("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") }, // Criminal Law
new ResumeSkill { SkillId = 91, UserId = Guid.Parse("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") }, // Tax Law
new ResumeSkill { SkillId = 94, UserId = Guid.Parse("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") }, // Legal Compliance
new ResumeSkill { SkillId = 95, UserId = Guid.Parse("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") }, // Legal Consulting
new ResumeSkill { SkillId = 96, UserId = Guid.Parse("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") }, // Legal Research
new ResumeSkill { SkillId = 97, UserId = Guid.Parse("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") }, // Legal Writing

// Usuario: 38c07b15-1adc-47fb-adca-5a93ab1ec6c3 (Víctor Morales - Periodista)
new ResumeSkill { SkillId = 98, UserId = Guid.Parse("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") }, // Legal Analysis
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") }, // Illustration
new ResumeSkill { SkillId = 65, UserId = Guid.Parse("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") }, // Typography
new ResumeSkill { SkillId = 66, UserId = Guid.Parse("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") }, // Digital Painting
new ResumeSkill { SkillId = 67, UserId = Guid.Parse("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") }, // User Experience (UX) Design
new ResumeSkill { SkillId = 68, UserId = Guid.Parse("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") }, // User Interface (UI) Design
new ResumeSkill { SkillId = 69, UserId = Guid.Parse("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") }, // Wireframing
new ResumeSkill { SkillId = 70, UserId = Guid.Parse("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") }, // Prototyping
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") }, // Information Architecture
new ResumeSkill { SkillId = 73, UserId = Guid.Parse("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") }, // Brand Identity

// Usuario: 1b29f96a-23e1-4824-9e66-775d807af9ae (Carmen Flores - Enfermera)
new ResumeSkill { SkillId = 97, UserId = Guid.Parse("1b29f96a-23e1-4824-9e66-775d807af9ae") }, // Legal Writing
new ResumeSkill { SkillId = 65, UserId = Guid.Parse("1b29f96a-23e1-4824-9e66-775d807af9ae") }, // Typography
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("1b29f96a-23e1-4824-9e66-775d807af9ae") }, // Illustration
new ResumeSkill { SkillId = 78, UserId = Guid.Parse("1b29f96a-23e1-4824-9e66-775d807af9ae") }, // 2D Animation
new ResumeSkill { SkillId = 80, UserId = Guid.Parse("1b29f96a-23e1-4824-9e66-775d807af9ae") }, // Character Animation
new ResumeSkill { SkillId = 83, UserId = Guid.Parse("1b29f96a-23e1-4824-9e66-775d807af9ae") }, // Intellectual Property Law
new ResumeSkill { SkillId = 86, UserId = Guid.Parse("1b29f96a-23e1-4824-9e66-775d807af9ae") }, // Immigration Law
new ResumeSkill { SkillId = 89, UserId = Guid.Parse("1b29f96a-23e1-4824-9e66-775d807af9ae") }, // Criminal Law
new ResumeSkill { SkillId = 91, UserId = Guid.Parse("1b29f96a-23e1-4824-9e66-775d807af9ae") }, // Tax Law
new ResumeSkill { SkillId = 94, UserId = Guid.Parse("1b29f96a-23e1-4824-9e66-775d807af9ae") }, // Legal Compliance

// Usuario: c5f0f42f-255f-400d-b657-bed222ec9903 (Luis Miguel - Contador)
new ResumeSkill { SkillId = 81, UserId = Guid.Parse("c5f0f42f-255f-400d-b657-bed222ec9903") }, // Legal Writing
new ResumeSkill { SkillId = 82, UserId = Guid.Parse("c5f0f42f-255f-400d-b657-bed222ec9903") }, // Corporate Law
new ResumeSkill { SkillId = 85, UserId = Guid.Parse("c5f0f42f-255f-400d-b657-bed222ec9903") }, // Environmental Law
new ResumeSkill { SkillId = 89, UserId = Guid.Parse("c5f0f42f-255f-400d-b657-bed222ec9903") }, // Criminal Law
new ResumeSkill { SkillId = 91, UserId = Guid.Parse("c5f0f42f-255f-400d-b657-bed222ec9903") }, // Tax Law
new ResumeSkill { SkillId = 93, UserId = Guid.Parse("c5f0f42f-255f-400d-b657-bed222ec9903") }, // Administrative Law
new ResumeSkill { SkillId = 94, UserId = Guid.Parse("c5f0f42f-255f-400d-b657-bed222ec9903") }, // Legal Compliance
new ResumeSkill { SkillId = 95, UserId = Guid.Parse("c5f0f42f-255f-400d-b657-bed222ec9903") }, // Legal Consulting
new ResumeSkill { SkillId = 96, UserId = Guid.Parse("c5f0f42f-255f-400d-b657-bed222ec9903") }, // Legal Research
new ResumeSkill { SkillId = 97, UserId = Guid.Parse("c5f0f42f-255f-400d-b657-bed222ec9903") }, // Legal Writing

// Usuario: 4ce9ea91-e281-47df-9fc7-79f0c9a95ddd (Beatriz - Diseñadora de Moda)
new ResumeSkill { SkillId = 62, UserId = Guid.Parse("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") }, // ZBrush
new ResumeSkill { SkillId = 63, UserId = Guid.Parse("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") }, // SketchUp
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") }, // Illustration
new ResumeSkill { SkillId = 73, UserId = Guid.Parse("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") }, // Brand Identity
new ResumeSkill { SkillId = 74, UserId = Guid.Parse("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") }, // Print Design
new ResumeSkill { SkillId = 75, UserId = Guid.Parse("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") }, // Packaging Design
new ResumeSkill { SkillId = 76, UserId = Guid.Parse("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") }, // Logo Design
new ResumeSkill { SkillId = 77, UserId = Guid.Parse("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") }, // Motion Graphics
new ResumeSkill { SkillId = 78, UserId = Guid.Parse("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") }, // 2D Animation
new ResumeSkill { SkillId = 79, UserId = Guid.Parse("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") }, // 3D Animation

// Usuario: 60786725-191b-4172-acd8-ef669024173b (Jorge - Ingeniero Civil)
new ResumeSkill { SkillId = 90, UserId = Guid.Parse("60786725-191b-4172-acd8-ef669024173b") }, // Health Law
new ResumeSkill { SkillId = 91, UserId = Guid.Parse("60786725-191b-4172-acd8-ef669024173b") }, // Tax Law
new ResumeSkill { SkillId = 92, UserId = Guid.Parse("60786725-191b-4172-acd8-ef669024173b") }, // International Law
new ResumeSkill { SkillId = 93, UserId = Guid.Parse("60786725-191b-4172-acd8-ef669024173b") }, // Administrative Law
new ResumeSkill { SkillId = 94, UserId = Guid.Parse("60786725-191b-4172-acd8-ef669024173b") }, // Legal Compliance
new ResumeSkill { SkillId = 97, UserId = Guid.Parse("60786725-191b-4172-acd8-ef669024173b") }, // Legal Writing
new ResumeSkill { SkillId = 73, UserId = Guid.Parse("60786725-191b-4172-acd8-ef669024173b") }, // Brand Identity
new ResumeSkill { SkillId = 72, UserId = Guid.Parse("60786725-191b-4172-acd8-ef669024173b") }, // Interaction Design
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("60786725-191b-4172-acd8-ef669024173b") }, // Information Architecture
new ResumeSkill { SkillId = 69, UserId = Guid.Parse("60786725-191b-4172-acd8-ef669024173b") }, // Wireframing

// Usuario: ba7faac0-0e0c-4fb8-a329-5483da03032c (Fernando Gómez - Abogado)
new ResumeSkill { SkillId = 82, UserId = Guid.Parse("ba7faac0-0e0c-4fb8-a329-5483da03032c") }, // Corporate Law
new ResumeSkill { SkillId = 84, UserId = Guid.Parse("ba7faac0-0e0c-4fb8-a329-5483da03032c") }, // Family Law
new ResumeSkill { SkillId = 86, UserId = Guid.Parse("ba7faac0-0e0c-4fb8-a329-5483da03032c") }, // Immigration Law
new ResumeSkill { SkillId = 88, UserId = Guid.Parse("ba7faac0-0e0c-4fb8-a329-5483da03032c") }, // Bankruptcy Law
new ResumeSkill { SkillId = 89, UserId = Guid.Parse("ba7faac0-0e0c-4fb8-a329-5483da03032c") }, // Criminal Law
new ResumeSkill { SkillId = 91, UserId = Guid.Parse("ba7faac0-0e0c-4fb8-a329-5483da03032c") }, // Tax Law
new ResumeSkill { SkillId = 92, UserId = Guid.Parse("ba7faac0-0e0c-4fb8-a329-5483da03032c") }, // International Law
new ResumeSkill { SkillId = 93, UserId = Guid.Parse("ba7faac0-0e0c-4fb8-a329-5483da03032c") }, // Administrative Law
new ResumeSkill { SkillId = 94, UserId = Guid.Parse("ba7faac0-0e0c-4fb8-a329-5483da03032c") }, // Legal Compliance
new ResumeSkill { SkillId = 97, UserId = Guid.Parse("ba7faac0-0e0c-4fb8-a329-5483da03032c") }, // Legal Writing

// Usuario: 939a97f5-10b8-4d6c-ab74-ce77187d36df (Alejandra Hernández - Ingeniera de Software)
new ResumeSkill { SkillId = 1, UserId = Guid.Parse("939a97f5-10b8-4d6c-ab74-ce77187d36df") }, // Java
new ResumeSkill { SkillId = 2, UserId = Guid.Parse("939a97f5-10b8-4d6c-ab74-ce77187d36df") }, // Javascript
new ResumeSkill { SkillId = 3, UserId = Guid.Parse("939a97f5-10b8-4d6c-ab74-ce77187d36df") }, // C#
new ResumeSkill { SkillId = 30, UserId = Guid.Parse("939a97f5-10b8-4d6c-ab74-ce77187d36df") }, // Node.js
new ResumeSkill { SkillId = 31, UserId = Guid.Parse("939a97f5-10b8-4d6c-ab74-ce77187d36df") }, // Express.js
new ResumeSkill { SkillId = 32, UserId = Guid.Parse("939a97f5-10b8-4d6c-ab74-ce77187d36df") }, // Flask
new ResumeSkill { SkillId = 33, UserId = Guid.Parse("939a97f5-10b8-4d6c-ab74-ce77187d36df") }, // Ruby on Rails
new ResumeSkill { SkillId = 39, UserId = Guid.Parse("939a97f5-10b8-4d6c-ab74-ce77187d36df") }, // TensorFlow
new ResumeSkill { SkillId = 40, UserId = Guid.Parse("939a97f5-10b8-4d6c-ab74-ce77187d36df") }, // PyTorch
new ResumeSkill { SkillId = 42, UserId = Guid.Parse("939a97f5-10b8-4d6c-ab74-ce77187d36df") }, // Adobe Illustrator

// Usuario: c54c442f-e6a2-40b7-a022-3a58bccb2b3b (Gustavo Martínez - Arquitecto)
new ResumeSkill { SkillId = 62, UserId = Guid.Parse("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") }, // ZBrush
new ResumeSkill { SkillId = 63, UserId = Guid.Parse("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") }, // SketchUp
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") }, // Illustration
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") }, // Information Architecture
new ResumeSkill { SkillId = 72, UserId = Guid.Parse("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") }, // Interaction Design
new ResumeSkill { SkillId = 76, UserId = Guid.Parse("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") }, // Logo Design
new ResumeSkill { SkillId = 77, UserId = Guid.Parse("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") }, // Motion Graphics
new ResumeSkill { SkillId = 78, UserId = Guid.Parse("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") }, // 2D Animation
new ResumeSkill { SkillId = 79, UserId = Guid.Parse("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") }, // 3D Animation
new ResumeSkill { SkillId = 80, UserId = Guid.Parse("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") }, // Character Animation

// Usuario: 83ae68c3-f621-4f03-bda7-73d77aec8ce3 (Valeria González - Consultora de Marketing Digital)
new ResumeSkill { SkillId = 67, UserId = Guid.Parse("83ae68c3-f621-4f03-bda7-73d77aec8ce3") }, // User Experience (UX) Design
new ResumeSkill { SkillId = 68, UserId = Guid.Parse("83ae68c3-f621-4f03-bda7-73d77aec8ce3") }, // User Interface (UI) Design
new ResumeSkill { SkillId = 69, UserId = Guid.Parse("83ae68c3-f621-4f03-bda7-73d77aec8ce3") }, // Wireframing
new ResumeSkill { SkillId = 70, UserId = Guid.Parse("83ae68c3-f621-4f03-bda7-73d77aec8ce3") }, // Prototyping
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("83ae68c3-f621-4f03-bda7-73d77aec8ce3") }, // Information Architecture
new ResumeSkill { SkillId = 77, UserId = Guid.Parse("83ae68c3-f621-4f03-bda7-73d77aec8ce3") }, // Motion Graphics
new ResumeSkill { SkillId = 78, UserId = Guid.Parse("83ae68c3-f621-4f03-bda7-73d77aec8ce3") }, // 2D Animation
new ResumeSkill { SkillId = 79, UserId = Guid.Parse("83ae68c3-f621-4f03-bda7-73d77aec8ce3") }, // 3D Animation
new ResumeSkill { SkillId = 80, UserId = Guid.Parse("83ae68c3-f621-4f03-bda7-73d77aec8ce3") }, // Character Animation
new ResumeSkill { SkillId = 95, UserId = Guid.Parse("83ae68c3-f621-4f03-bda7-73d77aec8ce3") }, // Legal Consulting

// Usuario: 70e6cdc7-85df-452f-84ea-5e985024734c (Raúl Pérez - Contador Público)
new ResumeSkill { SkillId = 50, UserId = Guid.Parse("70e6cdc7-85df-452f-84ea-5e985024734c") }, // Contract Drafting
new ResumeSkill { SkillId = 51, UserId = Guid.Parse("70e6cdc7-85df-452f-84ea-5e985024734c") }, // Microsoft Office
new ResumeSkill { SkillId = 52, UserId = Guid.Parse("70e6cdc7-85df-452f-84ea-5e985024734c") }, // Excel
new ResumeSkill { SkillId = 53, UserId = Guid.Parse("70e6cdc7-85df-452f-84ea-5e985024734c") }, // Word
new ResumeSkill { SkillId = 54, UserId = Guid.Parse("70e6cdc7-85df-452f-84ea-5e985024734c") }, // PowerPoint
new ResumeSkill { SkillId = 55, UserId = Guid.Parse("70e6cdc7-85df-452f-84ea-5e985024734c") }, // Outlook
new ResumeSkill { SkillId = 81, UserId = Guid.Parse("70e6cdc7-85df-452f-84ea-5e985024734c") }, // Legal Writing
new ResumeSkill { SkillId = 82, UserId = Guid.Parse("70e6cdc7-85df-452f-84ea-5e985024734c") }, // Corporate Law
new ResumeSkill { SkillId = 93, UserId = Guid.Parse("70e6cdc7-85df-452f-84ea-5e985024734c") }, // Administrative Law
new ResumeSkill { SkillId = 94, UserId = Guid.Parse("70e6cdc7-85df-452f-84ea-5e985024734c") }, // Legal Compliance

// Usuario: a9805c2f-71d4-4c13-92fb-ac069cb7d633 (Camila Sánchez - Psicóloga Clínica)
new ResumeSkill { SkillId = 91, UserId = Guid.Parse("a9805c2f-71d4-4c13-92fb-ac069cb7d633") }, // Tax Law
new ResumeSkill { SkillId = 95, UserId = Guid.Parse("a9805c2f-71d4-4c13-92fb-ac069cb7d633") }, // Legal Consulting
new ResumeSkill { SkillId = 96, UserId = Guid.Parse("a9805c2f-71d4-4c13-92fb-ac069cb7d633") }, // Legal Research
new ResumeSkill { SkillId = 97, UserId = Guid.Parse("a9805c2f-71d4-4c13-92fb-ac069cb7d633") }, // Legal Writing
new ResumeSkill { SkillId = 98, UserId = Guid.Parse("a9805c2f-71d4-4c13-92fb-ac069cb7d633") }, // Legal Analysis
new ResumeSkill { SkillId = 99, UserId = Guid.Parse("a9805c2f-71d4-4c13-92fb-ac069cb7d633") }, // Psychology
new ResumeSkill { SkillId = 100, UserId = Guid.Parse("a9805c2f-71d4-4c13-92fb-ac069cb7d633") }, // Psychotherapy
new ResumeSkill { SkillId = 101, UserId = Guid.Parse("a9805c2f-71d4-4c13-92fb-ac069cb7d633") }, // Cognitive Behavioral Therapy (CBT)
new ResumeSkill { SkillId = 102, UserId = Guid.Parse("a9805c2f-71d4-4c13-92fb-ac069cb7d633") }, // Solution-Focused Therapy
new ResumeSkill { SkillId = 103, UserId = Guid.Parse("a9805c2f-71d4-4c13-92fb-ac069cb7d633") }, // Counseling

// Usuario: ffd79ac4-d69f-4b74-b7c2-67e92905239a (Felipe López - Desarrollador Web)
new ResumeSkill { SkillId = 2, UserId = Guid.Parse("ffd79ac4-d69f-4b74-b7c2-67e92905239a") }, // Javascript
new ResumeSkill { SkillId = 27, UserId = Guid.Parse("ffd79ac4-d69f-4b74-b7c2-67e92905239a") }, // React
new ResumeSkill { SkillId = 30, UserId = Guid.Parse("ffd79ac4-d69f-4b74-b7c2-67e92905239a") }, // Node.js
new ResumeSkill { SkillId = 31, UserId = Guid.Parse("ffd79ac4-d69f-4b74-b7c2-67e92905239a") }, // Express.js
new ResumeSkill { SkillId = 32, UserId = Guid.Parse("ffd79ac4-d69f-4b74-b7c2-67e92905239a") }, // Flask
new ResumeSkill { SkillId = 34, UserId = Guid.Parse("ffd79ac4-d69f-4b74-b7c2-67e92905239a") }, // Laravel
new ResumeSkill { SkillId = 36, UserId = Guid.Parse("ffd79ac4-d69f-4b74-b7c2-67e92905239a") }, // Hibernate
new ResumeSkill { SkillId = 39, UserId = Guid.Parse("ffd79ac4-d69f-4b74-b7c2-67e92905239a") }, // TensorFlow
new ResumeSkill { SkillId = 40, UserId = Guid.Parse("ffd79ac4-d69f-4b74-b7c2-67e92905239a") }, // PyTorch
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("ffd79ac4-d69f-4b74-b7c2-67e92905239a") }, // Information Architecture

// Usuario: 81319e22-745a-45c6-9402-6d1389fd0f44 (Natalia Ramírez - Diseñadora Gráfica)
new ResumeSkill { SkillId = 42, UserId = Guid.Parse("81319e22-745a-45c6-9402-6d1389fd0f44") }, // Adobe Illustrator
new ResumeSkill { SkillId = 43, UserId = Guid.Parse("81319e22-745a-45c6-9402-6d1389fd0f44") }, // Adobe InDesign
new ResumeSkill { SkillId = 44, UserId = Guid.Parse("81319e22-745a-45c6-9402-6d1389fd0f44") }, // Sketch
new ResumeSkill { SkillId = 60, UserId = Guid.Parse("81319e22-745a-45c6-9402-6d1389fd0f44") }, // Maya
new ResumeSkill { SkillId = 67, UserId = Guid.Parse("81319e22-745a-45c6-9402-6d1389fd0f44") }, // User Experience (UX) Design
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("81319e22-745a-45c6-9402-6d1389fd0f44") }, // Information Architecture
new ResumeSkill { SkillId = 74, UserId = Guid.Parse("81319e22-745a-45c6-9402-6d1389fd0f44") }, // Print Design
new ResumeSkill { SkillId = 75, UserId = Guid.Parse("81319e22-745a-45c6-9402-6d1389fd0f44") }, // Packaging Design
new ResumeSkill { SkillId = 76, UserId = Guid.Parse("81319e22-745a-45c6-9402-6d1389fd0f44") }, // Logo Design
new ResumeSkill { SkillId = 77, UserId = Guid.Parse("81319e22-745a-45c6-9402-6d1389fd0f44") }, // Motion Graphics

// Usuario: 5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2 (Alberto García - Consultor Financiero)
new ResumeSkill { SkillId = 51, UserId = Guid.Parse("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") }, // Microsoft Office
new ResumeSkill { SkillId = 52, UserId = Guid.Parse("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") }, // Excel
new ResumeSkill { SkillId = 85, UserId = Guid.Parse("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") }, // Environmental Law
new ResumeSkill { SkillId = 86, UserId = Guid.Parse("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") }, // Immigration Law
new ResumeSkill { SkillId = 89, UserId = Guid.Parse("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") }, // Criminal Law
new ResumeSkill { SkillId = 91, UserId = Guid.Parse("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") }, // Tax Law
new ResumeSkill { SkillId = 93, UserId = Guid.Parse("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") }, // Administrative Law
new ResumeSkill { SkillId = 94, UserId = Guid.Parse("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") }, // Legal Compliance
new ResumeSkill { SkillId = 95, UserId = Guid.Parse("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") }, // Legal Consulting
new ResumeSkill { SkillId = 99, UserId = Guid.Parse("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") }, // Legal Documentation

// Usuario: d496f336-c5ab-4648-841c-38853c4aa4f7 (Paola Díaz - Abogada)
new ResumeSkill { SkillId = 49, UserId = Guid.Parse("d496f336-c5ab-4648-841c-38853c4aa4f7") }, // Litigation
new ResumeSkill { SkillId = 88, UserId = Guid.Parse("d496f336-c5ab-4648-841c-38853c4aa4f7") }, // Bankruptcy Law
new ResumeSkill { SkillId = 89, UserId = Guid.Parse("d496f336-c5ab-4648-841c-38853c4aa4f7") }, // Criminal Law
new ResumeSkill { SkillId = 91, UserId = Guid.Parse("d496f336-c5ab-4648-841c-38853c4aa4f7") }, // Tax Law
new ResumeSkill { SkillId = 93, UserId = Guid.Parse("d496f336-c5ab-4648-841c-38853c4aa4f7") }, // Administrative Law
new ResumeSkill { SkillId = 96, UserId = Guid.Parse("d496f336-c5ab-4648-841c-38853c4aa4f7") }, // Legal Research
new ResumeSkill { SkillId = 97, UserId = Guid.Parse("d496f336-c5ab-4648-841c-38853c4aa4f7") }, // Legal Writing
new ResumeSkill { SkillId = 98, UserId = Guid.Parse("d496f336-c5ab-4648-841c-38853c4aa4f7") }, // Legal Analysis
new ResumeSkill { SkillId = 99, UserId = Guid.Parse("d496f336-c5ab-4648-841c-38853c4aa4f7") }, // Legal Documentation

// Usuario: 19d1cc4c-18e4-42fc-9cbd-56253b20165e (Claudia Ramírez - Enfermera)
new ResumeSkill { SkillId = 91, UserId = Guid.Parse("19d1cc4c-18e4-42fc-9cbd-56253b20165e") }, // Tax Law
new ResumeSkill { SkillId = 96, UserId = Guid.Parse("19d1cc4c-18e4-42fc-9cbd-56253b20165e") }, // Legal Research
new ResumeSkill { SkillId = 97, UserId = Guid.Parse("19d1cc4c-18e4-42fc-9cbd-56253b20165e") }, // Legal Writing
new ResumeSkill { SkillId = 98, UserId = Guid.Parse("19d1cc4c-18e4-42fc-9cbd-56253b20165e") }, // Legal Analysis
new ResumeSkill { SkillId = 99, UserId = Guid.Parse("19d1cc4c-18e4-42fc-9cbd-56253b20165e") }, // Legal Documentation
new ResumeSkill { SkillId = 100, UserId = Guid.Parse("19d1cc4c-18e4-42fc-9cbd-56253b20165e") }, // Data Entry

// Usuario: c2199980-e00d-45dd-bdb6-8497cfeac41d (Ricardo Morales - Ingeniero Mecánico)
new ResumeSkill { SkillId = 23, UserId = Guid.Parse("c2199980-e00d-45dd-bdb6-8497cfeac41d") }, // Assembly (x86, ARM)
new ResumeSkill { SkillId = 36, UserId = Guid.Parse("c2199980-e00d-45dd-bdb6-8497cfeac41d") }, // Hibernate
new ResumeSkill { SkillId = 39, UserId = Guid.Parse("c2199980-e00d-45dd-bdb6-8497cfeac41d") }, // TensorFlow
new ResumeSkill { SkillId = 46, UserId = Guid.Parse("c2199980-e00d-45dd-bdb6-8497cfeac41d") }, // AutoCAD
new ResumeSkill { SkillId = 47, UserId = Guid.Parse("c2199980-e00d-45dd-bdb6-8497cfeac41d") }, // Revit
new ResumeSkill { SkillId = 78, UserId = Guid.Parse("c2199980-e00d-45dd-bdb6-8497cfeac41d") }, // 2D Animation
new ResumeSkill { SkillId = 79, UserId = Guid.Parse("c2199980-e00d-45dd-bdb6-8497cfeac41d") }, // 3D Animation
new ResumeSkill { SkillId = 80, UserId = Guid.Parse("c2199980-e00d-45dd-bdb6-8497cfeac41d") }, // Character Animation

// Usuario: 1199aa46-b03b-4cc4-921e-62b08fd5247f (Rosa González - Profesional de Recursos Humanos)
new ResumeSkill { SkillId = 81, UserId = Guid.Parse("1199aa46-b03b-4cc4-921e-62b08fd5247f") }, // Legal Writing
new ResumeSkill { SkillId = 82, UserId = Guid.Parse("1199aa46-b03b-4cc4-921e-62b08fd5247f") }, // Corporate Law
new ResumeSkill { SkillId = 83, UserId = Guid.Parse("1199aa46-b03b-4cc4-921e-62b08fd5247f") }, // Intellectual Property Law
new ResumeSkill { SkillId = 84, UserId = Guid.Parse("1199aa46-b03b-4cc4-921e-62b08fd5247f") }, // Family Law
new ResumeSkill { SkillId = 85, UserId = Guid.Parse("1199aa46-b03b-4cc4-921e-62b08fd5247f") }, // Environmental Law
new ResumeSkill { SkillId = 86, UserId = Guid.Parse("1199aa46-b03b-4cc4-921e-62b08fd5247f") }, // Immigration Law
new ResumeSkill { SkillId = 87, UserId = Guid.Parse("1199aa46-b03b-4cc4-921e-62b08fd5247f") }, // Real Estate Law
new ResumeSkill { SkillId = 88, UserId = Guid.Parse("1199aa46-b03b-4cc4-921e-62b08fd5247f") }, // Bankruptcy Law
new ResumeSkill { SkillId = 89, UserId = Guid.Parse("1199aa46-b03b-4cc4-921e-62b08fd5247f") }, // Criminal Law
new ResumeSkill { SkillId = 90, UserId = Guid.Parse("1199aa46-b03b-4cc4-921e-62b08fd5247f") }, // Health Law

// Usuario: 17923d13-ffa5-4e87-9cab-3b313d44b3ea (Ignacio - Desarrollador de Software)
new ResumeSkill { SkillId = 1, UserId = Guid.Parse("17923d13-ffa5-4e87-9cab-3b313d44b3ea") }, // Java
new ResumeSkill { SkillId = 2, UserId = Guid.Parse("17923d13-ffa5-4e87-9cab-3b313d44b3ea") }, // Javascript
new ResumeSkill { SkillId = 3, UserId = Guid.Parse("17923d13-ffa5-4e87-9cab-3b313d44b3ea") }, // C#
new ResumeSkill { SkillId = 30, UserId = Guid.Parse("17923d13-ffa5-4e87-9cab-3b313d44b3ea") }, // Node.js
new ResumeSkill { SkillId = 31, UserId = Guid.Parse("17923d13-ffa5-4e87-9cab-3b313d44b3ea") }, // Express.js
new ResumeSkill { SkillId = 33, UserId = Guid.Parse("17923d13-ffa5-4e87-9cab-3b313d44b3ea") }, // Ruby on Rails
new ResumeSkill { SkillId = 34, UserId = Guid.Parse("17923d13-ffa5-4e87-9cab-3b313d44b3ea") }, // Laravel
new ResumeSkill { SkillId = 37, UserId = Guid.Parse("17923d13-ffa5-4e87-9cab-3b313d44b3ea") }, // Xamarin
new ResumeSkill { SkillId = 38, UserId = Guid.Parse("17923d13-ffa5-4e87-9cab-3b313d44b3ea") }, // Unity

// Usuario: 31550335-200e-442a-9cca-f1d0f62c0819 (Andrea Ramírez - Diseñadora de Moda)
new ResumeSkill { SkillId = 62, UserId = Guid.Parse("31550335-200e-442a-9cca-f1d0f62c0819") }, // ZBrush
new ResumeSkill { SkillId = 63, UserId = Guid.Parse("31550335-200e-442a-9cca-f1d0f62c0819") }, // SketchUp
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("31550335-200e-442a-9cca-f1d0f62c0819") }, // Illustration
new ResumeSkill { SkillId = 65, UserId = Guid.Parse("31550335-200e-442a-9cca-f1d0f62c0819") }, // Typography
new ResumeSkill { SkillId = 66, UserId = Guid.Parse("31550335-200e-442a-9cca-f1d0f62c0819") }, // Digital Painting
new ResumeSkill { SkillId = 67, UserId = Guid.Parse("31550335-200e-442a-9cca-f1d0f62c0819") }, // User Experience (UX) Design
new ResumeSkill { SkillId = 68, UserId = Guid.Parse("31550335-200e-442a-9cca-f1d0f62c0819") }, // User Interface (UI) Design
new ResumeSkill { SkillId = 69, UserId = Guid.Parse("31550335-200e-442a-9cca-f1d0f62c0819") }, // Wireframing
new ResumeSkill { SkillId = 70, UserId = Guid.Parse("31550335-200e-442a-9cca-f1d0f62c0819") }, // Prototyping
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("31550335-200e-442a-9cca-f1d0f62c0819") }, // Information Architecture

// Usuario: 2301041e-8c28-4711-b70d-9daed300ae21 (Víctor García - Contador Público)
new ResumeSkill { SkillId = 48, UserId = Guid.Parse("2301041e-8c28-4711-b70d-9daed300ae21") }, // Legal Research
new ResumeSkill { SkillId = 49, UserId = Guid.Parse("2301041e-8c28-4711-b70d-9daed300ae21") }, // Litigation
new ResumeSkill { SkillId = 50, UserId = Guid.Parse("2301041e-8c28-4711-b70d-9daed300ae21") }, // Contract Drafting
new ResumeSkill { SkillId = 51, UserId = Guid.Parse("2301041e-8c28-4711-b70d-9daed300ae21") }, // Microsoft Office
new ResumeSkill { SkillId = 52, UserId = Guid.Parse("2301041e-8c28-4711-b70d-9daed300ae21") }, // Excel
new ResumeSkill { SkillId = 53, UserId = Guid.Parse("2301041e-8c28-4711-b70d-9daed300ae21") }, // Word
new ResumeSkill { SkillId = 54, UserId = Guid.Parse("2301041e-8c28-4711-b70d-9daed300ae21") }, // PowerPoint
new ResumeSkill { SkillId = 55, UserId = Guid.Parse("2301041e-8c28-4711-b70d-9daed300ae21") }, // Outlook

// Usuario: 37991d47-ddc6-400b-a3fe-b17b998a76b2 (Lorena Díaz - Consultora de Marketing Digital)
new ResumeSkill { SkillId = 27, UserId = Guid.Parse("37991d47-ddc6-400b-a3fe-b17b998a76b2") }, // React
new ResumeSkill { SkillId = 28, UserId = Guid.Parse("37991d47-ddc6-400b-a3fe-b17b998a76b2") }, // Angular
new ResumeSkill { SkillId = 29, UserId = Guid.Parse("37991d47-ddc6-400b-a3fe-b17b998a76b2") }, // Vue.js
new ResumeSkill { SkillId = 31, UserId = Guid.Parse("37991d47-ddc6-400b-a3fe-b17b998a76b2") }, // Express.js
new ResumeSkill { SkillId = 32, UserId = Guid.Parse("37991d47-ddc6-400b-a3fe-b17b998a76b2") }, // Flask
new ResumeSkill { SkillId = 33, UserId = Guid.Parse("37991d47-ddc6-400b-a3fe-b17b998a76b2") }, // Ruby on Rails
new ResumeSkill { SkillId = 34, UserId = Guid.Parse("37991d47-ddc6-400b-a3fe-b17b998a76b2") }, // Laravel
new ResumeSkill { SkillId = 35, UserId = Guid.Parse("37991d47-ddc6-400b-a3fe-b17b998a76b2") }, // Symfony

// Usuario: 97767fcd-f146-4e88-87dd-f1f1806dec49 (Carlos Hernández - Arquitecto)
new ResumeSkill { SkillId = 61, UserId = Guid.Parse("97767fcd-f146-4e88-87dd-f1f1806dec49") }, // 3ds Max
new ResumeSkill { SkillId = 62, UserId = Guid.Parse("97767fcd-f146-4e88-87dd-f1f1806dec49") }, // ZBrush
new ResumeSkill { SkillId = 63, UserId = Guid.Parse("97767fcd-f146-4e88-87dd-f1f1806dec49") }, // SketchUp
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("97767fcd-f146-4e88-87dd-f1f1806dec49") }, // Illustration
new ResumeSkill { SkillId = 65, UserId = Guid.Parse("97767fcd-f146-4e88-87dd-f1f1806dec49") }, // Typography
new ResumeSkill { SkillId = 66, UserId = Guid.Parse("97767fcd-f146-4e88-87dd-f1f1806dec49") }, // Digital Painting
new ResumeSkill { SkillId = 67, UserId = Guid.Parse("97767fcd-f146-4e88-87dd-f1f1806dec49") }, // User Experience (UX) Design
new ResumeSkill { SkillId = 68, UserId = Guid.Parse("97767fcd-f146-4e88-87dd-f1f1806dec49") }, // User Interface (UI) Design
new ResumeSkill { SkillId = 69, UserId = Guid.Parse("97767fcd-f146-4e88-87dd-f1f1806dec49") }, // Wireframing
new ResumeSkill { SkillId = 70, UserId = Guid.Parse("97767fcd-f146-4e88-87dd-f1f1806dec49") }, // Prototyping

// Usuario: 2641ba50-9bdf-4107-80e8-a723e7feb06e (Miriam López - Periodista)
new ResumeSkill { SkillId = 12, UserId = Guid.Parse("2641ba50-9bdf-4107-80e8-a723e7feb06e") }, // Journalism
new ResumeSkill { SkillId = 13, UserId = Guid.Parse("2641ba50-9bdf-4107-80e8-a723e7feb06e") }, // News Writing
new ResumeSkill { SkillId = 14, UserId = Guid.Parse("2641ba50-9bdf-4107-80e8-a723e7feb06e") }, // Investigative Reporting
new ResumeSkill { SkillId = 15, UserId = Guid.Parse("2641ba50-9bdf-4107-80e8-a723e7feb06e") }, // Feature Writing
new ResumeSkill { SkillId = 16, UserId = Guid.Parse("2641ba50-9bdf-4107-80e8-a723e7feb06e") }, // Editing
new ResumeSkill { SkillId = 17, UserId = Guid.Parse("2641ba50-9bdf-4107-80e8-a723e7feb06e") }, // Photography
new ResumeSkill { SkillId = 18, UserId = Guid.Parse("2641ba50-9bdf-4107-80e8-a723e7feb06e") }, // Social Media Management
new ResumeSkill { SkillId = 19, UserId = Guid.Parse("2641ba50-9bdf-4107-80e8-a723e7feb06e") }, // Communication

// Usuario: 0497ee14-d660-49a1-916d-8d2391ba6cf2 (Marcos Pérez - Ingeniero de Software)
new ResumeSkill { SkillId = 1, UserId = Guid.Parse("0497ee14-d660-49a1-916d-8d2391ba6cf2") }, // C#
new ResumeSkill { SkillId = 2, UserId = Guid.Parse("0497ee14-d660-49a1-916d-8d2391ba6cf2") }, // .NET
new ResumeSkill { SkillId = 3, UserId = Guid.Parse("0497ee14-d660-49a1-916d-8d2391ba6cf2") }, // Java
new ResumeSkill { SkillId = 4, UserId = Guid.Parse("0497ee14-d660-49a1-916d-8d2391ba6cf2") }, // Python
new ResumeSkill { SkillId = 5, UserId = Guid.Parse("0497ee14-d660-49a1-916d-8d2391ba6cf2") }, // JavaScript
new ResumeSkill { SkillId = 6, UserId = Guid.Parse("0497ee14-d660-49a1-916d-8d2391ba6cf2") }, // React
new ResumeSkill { SkillId = 7, UserId = Guid.Parse("0497ee14-d660-49a1-916d-8d2391ba6cf2") }, // Angular
new ResumeSkill { SkillId = 8, UserId = Guid.Parse("0497ee14-d660-49a1-916d-8d2391ba6cf2") }, // Vue.js
new ResumeSkill { SkillId = 9, UserId = Guid.Parse("0497ee14-d660-49a1-916d-8d2391ba6cf2") }, // Node.js
new ResumeSkill { SkillId = 10, UserId = Guid.Parse("0497ee14-d660-49a1-916d-8d2391ba6cf2") }, // SQL

// Usuario: 2d624f65-a74a-4011-a187-862f58df7885 (Patricia Flores - Psicóloga Clínica)
new ResumeSkill { SkillId = 39, UserId = Guid.Parse("2d624f65-a74a-4011-a187-862f58df7885") }, // Cognitive Behavioral Therapy (CBT)
new ResumeSkill { SkillId = 40, UserId = Guid.Parse("2d624f65-a74a-4011-a187-862f58df7885") }, // Psychotherapy
new ResumeSkill { SkillId = 41, UserId = Guid.Parse("2d624f65-a74a-4011-a187-862f58df7885") }, // Mindfulness
new ResumeSkill { SkillId = 42, UserId = Guid.Parse("2d624f65-a74a-4011-a187-862f58df7885") }, // Counseling
new ResumeSkill { SkillId = 43, UserId = Guid.Parse("2d624f65-a74a-4011-a187-862f58df7885") }, // Mental Health Assessment
new ResumeSkill { SkillId = 44, UserId = Guid.Parse("2d624f65-a74a-4011-a187-862f58df7885") }, // Crisis Intervention
new ResumeSkill { SkillId = 45, UserId = Guid.Parse("2d624f65-a74a-4011-a187-862f58df7885") }, // Group Therapy
new ResumeSkill { SkillId = 46, UserId = Guid.Parse("2d624f65-a74a-4011-a187-862f58df7885") }, // Family Therapy
new ResumeSkill { SkillId = 47, UserId = Guid.Parse("2d624f65-a74a-4011-a187-862f58df7885") }, // Addiction Counseling
new ResumeSkill { SkillId = 48, UserId = Guid.Parse("2d624f65-a74a-4011-a187-862f58df7885") }, // Legal Research

// Usuario: 52432a25-6a28-480e-ab5c-17fd71be2ffb (Juliana González - Diseñadora Gráfica)
new ResumeSkill { SkillId = 49, UserId = Guid.Parse("52432a25-6a28-480e-ab5c-17fd71be2ffb") }, // Adobe Photoshop
new ResumeSkill { SkillId = 50, UserId = Guid.Parse("52432a25-6a28-480e-ab5c-17fd71be2ffb") }, // Adobe Illustrator
new ResumeSkill { SkillId = 51, UserId = Guid.Parse("52432a25-6a28-480e-ab5c-17fd71be2ffb") }, // Adobe InDesign
new ResumeSkill { SkillId = 52, UserId = Guid.Parse("52432a25-6a28-480e-ab5c-17fd71be2ffb") }, // Branding
new ResumeSkill { SkillId = 53, UserId = Guid.Parse("52432a25-6a28-480e-ab5c-17fd71be2ffb") }, // Typography
new ResumeSkill { SkillId = 54, UserId = Guid.Parse("52432a25-6a28-480e-ab5c-17fd71be2ffb") }, // Logo Design
new ResumeSkill { SkillId = 55, UserId = Guid.Parse("52432a25-6a28-480e-ab5c-17fd71be2ffb") }, // Print Design
new ResumeSkill { SkillId = 56, UserId = Guid.Parse("52432a25-6a28-480e-ab5c-17fd71be2ffb") }, // Digital Illustration
new ResumeSkill { SkillId = 57, UserId = Guid.Parse("52432a25-6a28-480e-ab5c-17fd71be2ffb") }, // UI/UX Design
new ResumeSkill { SkillId = 58, UserId = Guid.Parse("52432a25-6a28-480e-ab5c-17fd71be2ffb") }, // Responsive Design

// Usuario: f102e342-a664-4b43-bcdb-b1c6945bf241 (Roberto López - Abogado)
new ResumeSkill { SkillId = 26, UserId = Guid.Parse("f102e342-a664-4b43-bcdb-b1c6945bf241") }, // Labor Law
new ResumeSkill { SkillId = 27, UserId = Guid.Parse("f102e342-a664-4b43-bcdb-b1c6945bf241") }, // Employment Law
new ResumeSkill { SkillId = 28, UserId = Guid.Parse("f102e342-a664-4b43-bcdb-b1c6945bf241") }, // Legal Writing
new ResumeSkill { SkillId = 29, UserId = Guid.Parse("f102e342-a664-4b43-bcdb-b1c6945bf241") }, // Litigation
new ResumeSkill { SkillId = 30, UserId = Guid.Parse("f102e342-a664-4b43-bcdb-b1c6945bf241") }, // Negotiation
new ResumeSkill { SkillId = 31, UserId = Guid.Parse("f102e342-a664-4b43-bcdb-b1c6945bf241") }, // Dispute Resolution
new ResumeSkill { SkillId = 32, UserId = Guid.Parse("f102e342-a664-4b43-bcdb-b1c6945bf241") }, // Legal Research
new ResumeSkill { SkillId = 33, UserId = Guid.Parse("f102e342-a664-4b43-bcdb-b1c6945bf241") }, // Advocacy
new ResumeSkill { SkillId = 34, UserId = Guid.Parse("f102e342-a664-4b43-bcdb-b1c6945bf241") }, // Employment Contracts
new ResumeSkill { SkillId = 35, UserId = Guid.Parse("f102e342-a664-4b43-bcdb-b1c6945bf241") }, // Mediation

// Usuario: 31105ee2-5a05-4bcf-bff7-f07be401442e (María - Diseñadora de Moda)
new ResumeSkill { SkillId = 59, UserId = Guid.Parse("31105ee2-5a05-4bcf-bff7-f07be401442e") }, // Fashion Design
new ResumeSkill { SkillId = 60, UserId = Guid.Parse("31105ee2-5a05-4bcf-bff7-f07be401442e") }, // Pattern Making
new ResumeSkill { SkillId = 61, UserId = Guid.Parse("31105ee2-5a05-4bcf-bff7-f07be401442e") }, // Textile Design
new ResumeSkill { SkillId = 62, UserId = Guid.Parse("31105ee2-5a05-4bcf-bff7-f07be401442e") }, // Fashion Illustration
new ResumeSkill { SkillId = 63, UserId = Guid.Parse("31105ee2-5a05-4bcf-bff7-f07be401442e") }, // Draping
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("31105ee2-5a05-4bcf-bff7-f07be401442e") }, // Sewing
new ResumeSkill { SkillId = 65, UserId = Guid.Parse("31105ee2-5a05-4bcf-bff7-f07be401442e") }, // Garment Construction
new ResumeSkill { SkillId = 66, UserId = Guid.Parse("31105ee2-5a05-4bcf-bff7-f07be401442e") }, // Fashion Styling
new ResumeSkill { SkillId = 67, UserId = Guid.Parse("31105ee2-5a05-4bcf-bff7-f07be401442e") }, // Fashion Merchandising
new ResumeSkill { SkillId = 68, UserId = Guid.Parse("31105ee2-5a05-4bcf-bff7-f07be401442e") }, // Sustainable Fashion

// Usuario: 87dbaf90-f343-423e-9f14-e124fd145730 (Ana - Fotógrafa Profesional)
new ResumeSkill { SkillId = 41, UserId = Guid.Parse("87dbaf90-f343-423e-9f14-e124fd145730") }, // Adobe Photoshop
new ResumeSkill { SkillId = 42, UserId = Guid.Parse("87dbaf90-f343-423e-9f14-e124fd145730") }, // Adobe Illustrator
new ResumeSkill { SkillId = 46, UserId = Guid.Parse("87dbaf90-f343-423e-9f14-e124fd145730") }, // AutoCAD
new ResumeSkill { SkillId = 47, UserId = Guid.Parse("87dbaf90-f343-423e-9f14-e124fd145730") }, // Revit
new ResumeSkill { SkillId = 61, UserId = Guid.Parse("87dbaf90-f343-423e-9f14-e124fd145730") }, // 3ds Max
new ResumeSkill { SkillId = 79, UserId = Guid.Parse("87dbaf90-f343-423e-9f14-e124fd145730") }, // 3D Animation
new ResumeSkill { SkillId = 80, UserId = Guid.Parse("87dbaf90-f343-423e-9f14-e124fd145730") }, // Character Animation
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("87dbaf90-f343-423e-9f14-e124fd145730") }, // Illustration
new ResumeSkill { SkillId = 65, UserId = Guid.Parse("87dbaf90-f343-423e-9f14-e124fd145730") }, // Typography
new ResumeSkill { SkillId = 66, UserId = Guid.Parse("87dbaf90-f343-423e-9f14-e124fd145730") }, // Digital Painting

// Usuario: dd39eee3-6b17-4b39-95e0-075ad1b704bd (Pedro - Ingeniero de Software)
new ResumeSkill { SkillId = 2, UserId = Guid.Parse("dd39eee3-6b17-4b39-95e0-075ad1b704bd") }, // Javascript
new ResumeSkill { SkillId = 3, UserId = Guid.Parse("dd39eee3-6b17-4b39-95e0-075ad1b704bd") }, // C#
new ResumeSkill { SkillId = 4, UserId = Guid.Parse("dd39eee3-6b17-4b39-95e0-075ad1b704bd") }, // Python
new ResumeSkill { SkillId = 6, UserId = Guid.Parse("dd39eee3-6b17-4b39-95e0-075ad1b704bd") }, // PHP
new ResumeSkill { SkillId = 7, UserId = Guid.Parse("dd39eee3-6b17-4b39-95e0-075ad1b704bd") }, // Swift
new ResumeSkill { SkillId = 30, UserId = Guid.Parse("dd39eee3-6b17-4b39-95e0-075ad1b704bd") }, // Node.js
new ResumeSkill { SkillId = 39, UserId = Guid.Parse("dd39eee3-6b17-4b39-95e0-075ad1b704bd") }, // TensorFlow
new ResumeSkill { SkillId = 40, UserId = Guid.Parse("dd39eee3-6b17-4b39-95e0-075ad1b704bd") }, // PyTorch
new ResumeSkill { SkillId = 70, UserId = Guid.Parse("dd39eee3-6b17-4b39-95e0-075ad1b704bd") }, // Prototyping
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("dd39eee3-6b17-4b39-95e0-075ad1b704bd") }, // Information Architecture

// Usuario: 3a76ac51-89f5-4b7f-a2fb-cca12abc04e9 (Isabel - Escritora)
new ResumeSkill { SkillId = 81, UserId = Guid.Parse("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") }, // Legal Writing
new ResumeSkill { SkillId = 82, UserId = Guid.Parse("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") }, // Corporate Law
new ResumeSkill { SkillId = 96, UserId = Guid.Parse("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") }, // Legal Research
new ResumeSkill { SkillId = 97, UserId = Guid.Parse("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") }, // Legal Writing
new ResumeSkill { SkillId = 98, UserId = Guid.Parse("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") }, // Legal Analysis
new ResumeSkill { SkillId = 99, UserId = Guid.Parse("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") }, // Legal Documentation
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") }, // Illustration
new ResumeSkill { SkillId = 65, UserId = Guid.Parse("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") }, // Typography
new ResumeSkill { SkillId = 66, UserId = Guid.Parse("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") }, // Digital Painting
new ResumeSkill { SkillId = 72, UserId = Guid.Parse("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") }, // Interaction Design

// Usuario: ecf7b85e-8c3c-47ee-a80d-b0b360512c16 (David - Diseñador Gráfico)
new ResumeSkill { SkillId = 41, UserId = Guid.Parse("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") }, // Adobe Photoshop
new ResumeSkill { SkillId = 42, UserId = Guid.Parse("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") }, // Adobe Illustrator
new ResumeSkill { SkillId = 43, UserId = Guid.Parse("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") }, // Adobe InDesign
new ResumeSkill { SkillId = 59, UserId = Guid.Parse("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") }, // Blender
new ResumeSkill { SkillId = 60, UserId = Guid.Parse("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") }, // Maya
new ResumeSkill { SkillId = 61, UserId = Guid.Parse("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") }, // 3ds Max
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") }, // Illustration
new ResumeSkill { SkillId = 65, UserId = Guid.Parse("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") }, // Typography
new ResumeSkill { SkillId = 66, UserId = Guid.Parse("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") }, // Digital Painting
new ResumeSkill { SkillId = 67, UserId = Guid.Parse("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") }, // User Experience (UX) Design
new ResumeSkill { SkillId = 68, UserId = Guid.Parse("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") }, // User Interface (UI) Design

// Usuario: 866d732a-ab7e-42b8-aa7d-3bfb6e1477da (Mónica - Consultora de Marketing Digital)
new ResumeSkill { SkillId = 56, UserId = Guid.Parse("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") }, // Adobe Premiere Pro
new ResumeSkill { SkillId = 57, UserId = Guid.Parse("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") }, // Final Cut Pro
new ResumeSkill { SkillId = 58, UserId = Guid.Parse("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") }, // Avid Media Composer
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") }, // Information Architecture
new ResumeSkill { SkillId = 67, UserId = Guid.Parse("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") }, // User Experience (UX) Design
new ResumeSkill { SkillId = 70, UserId = Guid.Parse("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") }, // Prototyping
new ResumeSkill { SkillId = 73, UserId = Guid.Parse("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") }, // Brand Identity
new ResumeSkill { SkillId = 74, UserId = Guid.Parse("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") }, // Print Design
new ResumeSkill { SkillId = 75, UserId = Guid.Parse("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") }, // Packaging Design
new ResumeSkill { SkillId = 76, UserId = Guid.Parse("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") }, // Logo Design

// Usuario: 20b9c66b-7518-4cbc-aa39-f8bf41f0a423 (Fernando - Chef)
new ResumeSkill { SkillId = 10, UserId = Guid.Parse("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") }, // Kotlin
new ResumeSkill { SkillId = 44, UserId = Guid.Parse("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") }, // Sketch
new ResumeSkill { SkillId = 75, UserId = Guid.Parse("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") }, // Packaging Design
new ResumeSkill { SkillId = 80, UserId = Guid.Parse("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") }, // Character Animation
new ResumeSkill { SkillId = 81, UserId = Guid.Parse("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") }, // Legal Writing
new ResumeSkill { SkillId = 82, UserId = Guid.Parse("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") }, // Corporate Law
new ResumeSkill { SkillId = 83, UserId = Guid.Parse("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") }, // Intellectual Property Law
new ResumeSkill { SkillId = 84, UserId = Guid.Parse("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") }, // Family Law
new ResumeSkill { SkillId = 85, UserId = Guid.Parse("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") }, // Environmental Law
new ResumeSkill { SkillId = 86, UserId = Guid.Parse("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") }, // Immigration Law

// Usuario: 1cdb46ef-e0a5-427c-8409-9a58cde54ce9 (Luis - Desarrollador Web)
new ResumeSkill { SkillId = 2, UserId = Guid.Parse("1cdb46ef-e0a5-427c-8409-9a58cde54ce9") }, // JavaScript
new ResumeSkill { SkillId = 28, UserId = Guid.Parse("1cdb46ef-e0a5-427c-8409-9a58cde54ce9") }, // Angular
new ResumeSkill { SkillId = 29, UserId = Guid.Parse("1cdb46ef-e0a5-427c-8409-9a58cde54ce9") }, // Vue.js
new ResumeSkill { SkillId = 30, UserId = Guid.Parse("1cdb46ef-e0a5-427c-8409-9a58cde54ce9") }, // Node.js
new ResumeSkill { SkillId = 32, UserId = Guid.Parse("1cdb46ef-e0a5-427c-8409-9a58cde54ce9") }, // Flask

// Usuario: 3f059c7a-b764-49b9-bf1d-e5e2359e0cf6 (Carmen - Diseñadora Gráfica)
new ResumeSkill { SkillId = 42, UserId = Guid.Parse("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") }, // Adobe Illustrator
new ResumeSkill { SkillId = 43, UserId = Guid.Parse("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") }, // Adobe InDesign
new ResumeSkill { SkillId = 59, UserId = Guid.Parse("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") }, // Blender
new ResumeSkill { SkillId = 62, UserId = Guid.Parse("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") }, // ZBrush
new ResumeSkill { SkillId = 64, UserId = Guid.Parse("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") }, // Illustration
new ResumeSkill { SkillId = 76, UserId = Guid.Parse("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") }, // Logo Design
new ResumeSkill { SkillId = 77, UserId = Guid.Parse("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") }, // Motion Graphics

// Usuario: a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7 (Pablo - Consultor de Marketing Digital)
new ResumeSkill { SkillId = 51, UserId = Guid.Parse("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") }, // Microsoft Office
new ResumeSkill { SkillId = 52, UserId = Guid.Parse("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") }, // Excel
new ResumeSkill { SkillId = 53, UserId = Guid.Parse("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") }, // Word
new ResumeSkill { SkillId = 54, UserId = Guid.Parse("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") }, // PowerPoint
new ResumeSkill { SkillId = 55, UserId = Guid.Parse("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") }, // Outlook
new ResumeSkill { SkillId = 67, UserId = Guid.Parse("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") }, // User Experience (UX) Design
new ResumeSkill { SkillId = 71, UserId = Guid.Parse("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") }, // Information Architecture

// Usuario: b7d7964a-3f03-4930-a23d-59d90711f002 (Elena - Fotógrafa Profesional)
new ResumeSkill { SkillId = 56, UserId = Guid.Parse("b7d7964a-3f03-4930-a23d-59d90711f002") }, // Adobe Premiere Pro
new ResumeSkill { SkillId = 57, UserId = Guid.Parse("b7d7964a-3f03-4930-a23d-59d90711f002") }, // Final Cut Pro
new ResumeSkill { SkillId = 58, UserId = Guid.Parse("b7d7964a-3f03-4930-a23d-59d90711f002") }, // Avid Media Composer
new ResumeSkill { SkillId = 59, UserId = Guid.Parse("b7d7964a-3f03-4930-a23d-59d90711f002") }, // Blender
new ResumeSkill { SkillId = 60, UserId = Guid.Parse("b7d7964a-3f03-4930-a23d-59d90711f002") }, // Maya
new ResumeSkill { SkillId = 61, UserId = Guid.Parse("b7d7964a-3f03-4930-a23d-59d90711f002") }, // 3ds Max
new ResumeSkill { SkillId = 62, UserId = Guid.Parse("b7d7964a-3f03-4930-a23d-59d90711f002") }, // ZBrush
new ResumeSkill { SkillId = 63, UserId = Guid.Parse("b7d7964a-3f03-4930-a23d-59d90711f002") }, // SketchUp

// Usuario: 153ff2f4-ccb7-43b1-b163-8f995adb1d13 (Diego - Ingeniero Civil)
new ResumeSkill { SkillId = 23, UserId = Guid.Parse("153ff2f4-ccb7-43b1-b163-8f995adb1d13") }, // Assembly (x86, ARM)
new ResumeSkill { SkillId = 46, UserId = Guid.Parse("153ff2f4-ccb7-43b1-b163-8f995adb1d13") }, // AutoCAD
new ResumeSkill { SkillId = 47, UserId = Guid.Parse("153ff2f4-ccb7-43b1-b163-8f995adb1d13") }, // Revit

// Usuario: 7c5891f9-9fac-4dbf-9afd-2c9e01759e20 (Alejandra - Escritora Independiente)
new ResumeSkill { SkillId = 61, UserId = Guid.Parse("7c5891f9-9fac-4dbf-9afd-2c9e01759e20") }, // 3ds Max
new ResumeSkill { SkillId = 65, UserId = Guid.Parse("7c5891f9-9fac-4dbf-9afd-2c9e01759e20") }, // Typography
new ResumeSkill { SkillId = 76, UserId = Guid.Parse("7c5891f9-9fac-4dbf-9afd-2c9e01759e20") }, // Logo Design
new ResumeSkill { SkillId = 94, UserId = Guid.Parse("7c5891f9-9fac-4dbf-9afd-2c9e01759e20") } // Legal Compliance



                );
        }
    }

}
