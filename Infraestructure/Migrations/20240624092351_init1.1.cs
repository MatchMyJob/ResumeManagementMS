using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Infraestructure.Migrations
{
    /// <inheritdoc />
    public partial class init11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ResumeSkill",
                columns: new[] { "SkillId", "UserId" },
                values: new object[,]
                {
                    { 1, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") },
                    { 2, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") },
                    { 3, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") },
                    { 4, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") },
                    { 5, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") },
                    { 6, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") },
                    { 7, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") },
                    { 8, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") },
                    { 9, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") },
                    { 10, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") },
                    { 51, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") },
                    { 52, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") },
                    { 53, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") },
                    { 54, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") },
                    { 55, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") },
                    { 57, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") },
                    { 58, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") },
                    { 59, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") },
                    { 60, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") },
                    { 61, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") },
                    { 81, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") },
                    { 82, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") },
                    { 83, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") },
                    { 84, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") },
                    { 85, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") },
                    { 86, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") },
                    { 87, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") },
                    { 88, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") },
                    { 89, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") },
                    { 90, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") },
                    { 23, new Guid("153ff2f4-ccb7-43b1-b163-8f995adb1d13") },
                    { 46, new Guid("153ff2f4-ccb7-43b1-b163-8f995adb1d13") },
                    { 47, new Guid("153ff2f4-ccb7-43b1-b163-8f995adb1d13") },
                    { 1, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") },
                    { 2, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") },
                    { 3, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") },
                    { 30, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") },
                    { 31, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") },
                    { 33, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") },
                    { 34, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") },
                    { 37, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") },
                    { 38, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") },
                    { 91, new Guid("19d1cc4c-18e4-42fc-9cbd-56253b20165e") },
                    { 96, new Guid("19d1cc4c-18e4-42fc-9cbd-56253b20165e") },
                    { 97, new Guid("19d1cc4c-18e4-42fc-9cbd-56253b20165e") },
                    { 98, new Guid("19d1cc4c-18e4-42fc-9cbd-56253b20165e") },
                    { 99, new Guid("19d1cc4c-18e4-42fc-9cbd-56253b20165e") },
                    { 100, new Guid("19d1cc4c-18e4-42fc-9cbd-56253b20165e") },
                    { 64, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") },
                    { 65, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") },
                    { 78, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") },
                    { 80, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") },
                    { 83, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") },
                    { 86, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") },
                    { 89, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") },
                    { 91, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") },
                    { 94, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") },
                    { 97, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") },
                    { 2, new Guid("1cdb46ef-e0a5-427c-8409-9a58cde54ce9") },
                    { 28, new Guid("1cdb46ef-e0a5-427c-8409-9a58cde54ce9") },
                    { 29, new Guid("1cdb46ef-e0a5-427c-8409-9a58cde54ce9") },
                    { 30, new Guid("1cdb46ef-e0a5-427c-8409-9a58cde54ce9") },
                    { 32, new Guid("1cdb46ef-e0a5-427c-8409-9a58cde54ce9") },
                    { 10, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") },
                    { 44, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") },
                    { 75, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") },
                    { 80, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") },
                    { 81, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") },
                    { 82, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") },
                    { 83, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") },
                    { 84, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") },
                    { 85, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") },
                    { 86, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") },
                    { 48, new Guid("2301041e-8c28-4711-b70d-9daed300ae21") },
                    { 49, new Guid("2301041e-8c28-4711-b70d-9daed300ae21") },
                    { 50, new Guid("2301041e-8c28-4711-b70d-9daed300ae21") },
                    { 51, new Guid("2301041e-8c28-4711-b70d-9daed300ae21") },
                    { 52, new Guid("2301041e-8c28-4711-b70d-9daed300ae21") },
                    { 53, new Guid("2301041e-8c28-4711-b70d-9daed300ae21") },
                    { 54, new Guid("2301041e-8c28-4711-b70d-9daed300ae21") },
                    { 55, new Guid("2301041e-8c28-4711-b70d-9daed300ae21") },
                    { 12, new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e") },
                    { 13, new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e") },
                    { 14, new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e") },
                    { 15, new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e") },
                    { 16, new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e") },
                    { 17, new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e") },
                    { 18, new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e") },
                    { 19, new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e") },
                    { 39, new Guid("2d624f65-a74a-4011-a187-862f58df7885") },
                    { 40, new Guid("2d624f65-a74a-4011-a187-862f58df7885") },
                    { 41, new Guid("2d624f65-a74a-4011-a187-862f58df7885") },
                    { 42, new Guid("2d624f65-a74a-4011-a187-862f58df7885") },
                    { 43, new Guid("2d624f65-a74a-4011-a187-862f58df7885") },
                    { 44, new Guid("2d624f65-a74a-4011-a187-862f58df7885") },
                    { 45, new Guid("2d624f65-a74a-4011-a187-862f58df7885") },
                    { 46, new Guid("2d624f65-a74a-4011-a187-862f58df7885") },
                    { 47, new Guid("2d624f65-a74a-4011-a187-862f58df7885") },
                    { 48, new Guid("2d624f65-a74a-4011-a187-862f58df7885") },
                    { 1, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") },
                    { 3, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") },
                    { 4, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") },
                    { 5, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") },
                    { 7, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") },
                    { 11, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") },
                    { 13, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") },
                    { 16, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") },
                    { 20, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") },
                    { 24, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") },
                    { 59, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") },
                    { 60, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") },
                    { 61, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") },
                    { 62, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") },
                    { 63, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") },
                    { 64, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") },
                    { 65, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") },
                    { 66, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") },
                    { 67, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") },
                    { 68, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") },
                    { 62, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") },
                    { 63, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") },
                    { 64, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") },
                    { 65, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") },
                    { 66, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") },
                    { 67, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") },
                    { 68, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") },
                    { 69, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") },
                    { 70, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") },
                    { 71, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") },
                    { 46, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") },
                    { 47, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") },
                    { 59, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") },
                    { 61, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") },
                    { 62, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") },
                    { 67, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") },
                    { 68, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") },
                    { 70, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") },
                    { 71, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") },
                    { 72, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") },
                    { 75, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") },
                    { 76, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") },
                    { 77, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") },
                    { 78, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") },
                    { 79, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") },
                    { 80, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") },
                    { 81, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") },
                    { 82, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") },
                    { 83, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") },
                    { 84, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") },
                    { 27, new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2") },
                    { 28, new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2") },
                    { 29, new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2") },
                    { 31, new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2") },
                    { 32, new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2") },
                    { 33, new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2") },
                    { 34, new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2") },
                    { 35, new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2") },
                    { 64, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") },
                    { 65, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") },
                    { 66, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") },
                    { 67, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") },
                    { 68, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") },
                    { 69, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") },
                    { 70, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") },
                    { 71, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") },
                    { 73, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") },
                    { 98, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") },
                    { 64, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") },
                    { 65, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") },
                    { 66, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") },
                    { 72, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") },
                    { 81, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") },
                    { 82, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") },
                    { 96, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") },
                    { 97, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") },
                    { 98, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") },
                    { 99, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") },
                    { 51, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") },
                    { 52, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") },
                    { 53, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") },
                    { 54, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") },
                    { 55, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") },
                    { 94, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") },
                    { 95, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") },
                    { 96, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") },
                    { 97, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") },
                    { 98, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") },
                    { 2, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") },
                    { 3, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") },
                    { 4, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") },
                    { 9, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") },
                    { 10, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") },
                    { 30, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") },
                    { 31, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") },
                    { 39, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") },
                    { 40, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") },
                    { 78, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") },
                    { 7, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") },
                    { 10, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") },
                    { 22, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") },
                    { 23, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") },
                    { 24, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") },
                    { 39, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") },
                    { 40, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") },
                    { 45, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") },
                    { 46, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") },
                    { 47, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") },
                    { 56, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") },
                    { 57, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") },
                    { 58, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") },
                    { 77, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") },
                    { 78, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") },
                    { 79, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") },
                    { 80, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") },
                    { 94, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") },
                    { 95, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") },
                    { 97, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") },
                    { 42, new Guid("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") },
                    { 43, new Guid("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") },
                    { 59, new Guid("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") },
                    { 62, new Guid("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") },
                    { 64, new Guid("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") },
                    { 76, new Guid("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") },
                    { 77, new Guid("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") },
                    { 1, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") },
                    { 4, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") },
                    { 5, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") },
                    { 6, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") },
                    { 7, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") },
                    { 8, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") },
                    { 9, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") },
                    { 10, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") },
                    { 30, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") },
                    { 33, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") },
                    { 42, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") },
                    { 43, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") },
                    { 44, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") },
                    { 46, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") },
                    { 64, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") },
                    { 67, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") },
                    { 68, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") },
                    { 71, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") },
                    { 76, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") },
                    { 77, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") },
                    { 62, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") },
                    { 63, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") },
                    { 64, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") },
                    { 73, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") },
                    { 74, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") },
                    { 75, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") },
                    { 76, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") },
                    { 77, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") },
                    { 78, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") },
                    { 79, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") },
                    { 41, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") },
                    { 76, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") },
                    { 77, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") },
                    { 78, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") },
                    { 91, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") },
                    { 92, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") },
                    { 93, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") },
                    { 94, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") },
                    { 95, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") },
                    { 96, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") },
                    { 49, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") },
                    { 50, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") },
                    { 51, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") },
                    { 52, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") },
                    { 53, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") },
                    { 54, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") },
                    { 55, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") },
                    { 56, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") },
                    { 57, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") },
                    { 58, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") },
                    { 64, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") },
                    { 65, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") },
                    { 73, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") },
                    { 76, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") },
                    { 77, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") },
                    { 78, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") },
                    { 79, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") },
                    { 80, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") },
                    { 83, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") },
                    { 84, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") },
                    { 2, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") },
                    { 3, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") },
                    { 6, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") },
                    { 10, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") },
                    { 11, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") },
                    { 12, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") },
                    { 17, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") },
                    { 27, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") },
                    { 28, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") },
                    { 29, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") },
                    { 7, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") },
                    { 10, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") },
                    { 29, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") },
                    { 30, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") },
                    { 37, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") },
                    { 38, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") },
                    { 47, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") },
                    { 48, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") },
                    { 49, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") },
                    { 50, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") },
                    { 1, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") },
                    { 2, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") },
                    { 3, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") },
                    { 4, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") },
                    { 5, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") },
                    { 6, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") },
                    { 7, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") },
                    { 8, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") },
                    { 9, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") },
                    { 10, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") },
                    { 51, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") },
                    { 52, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") },
                    { 85, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") },
                    { 86, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") },
                    { 89, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") },
                    { 91, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") },
                    { 93, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") },
                    { 94, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") },
                    { 95, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") },
                    { 99, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") },
                    { 2, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") },
                    { 29, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") },
                    { 30, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") },
                    { 31, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") },
                    { 33, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") },
                    { 34, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") },
                    { 35, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") },
                    { 38, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") },
                    { 39, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") },
                    { 40, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") },
                    { 69, new Guid("60786725-191b-4172-acd8-ef669024173b") },
                    { 71, new Guid("60786725-191b-4172-acd8-ef669024173b") },
                    { 72, new Guid("60786725-191b-4172-acd8-ef669024173b") },
                    { 73, new Guid("60786725-191b-4172-acd8-ef669024173b") },
                    { 90, new Guid("60786725-191b-4172-acd8-ef669024173b") },
                    { 91, new Guid("60786725-191b-4172-acd8-ef669024173b") },
                    { 92, new Guid("60786725-191b-4172-acd8-ef669024173b") },
                    { 93, new Guid("60786725-191b-4172-acd8-ef669024173b") },
                    { 94, new Guid("60786725-191b-4172-acd8-ef669024173b") },
                    { 97, new Guid("60786725-191b-4172-acd8-ef669024173b") },
                    { 51, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") },
                    { 52, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") },
                    { 53, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") },
                    { 54, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") },
                    { 55, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") },
                    { 92, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") },
                    { 93, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") },
                    { 94, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") },
                    { 95, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") },
                    { 96, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") },
                    { 30, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") },
                    { 32, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") },
                    { 34, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") },
                    { 36, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") },
                    { 37, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") },
                    { 38, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") },
                    { 39, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") },
                    { 40, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") },
                    { 41, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") },
                    { 42, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") },
                    { 50, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") },
                    { 51, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") },
                    { 52, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") },
                    { 53, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") },
                    { 54, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") },
                    { 55, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") },
                    { 81, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") },
                    { 82, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") },
                    { 93, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") },
                    { 94, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") },
                    { 61, new Guid("7c5891f9-9fac-4dbf-9afd-2c9e01759e20") },
                    { 65, new Guid("7c5891f9-9fac-4dbf-9afd-2c9e01759e20") },
                    { 76, new Guid("7c5891f9-9fac-4dbf-9afd-2c9e01759e20") },
                    { 94, new Guid("7c5891f9-9fac-4dbf-9afd-2c9e01759e20") },
                    { 94, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") },
                    { 95, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") },
                    { 96, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") },
                    { 97, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") },
                    { 98, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") },
                    { 99, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") },
                    { 100, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") },
                    { 101, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") },
                    { 102, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") },
                    { 103, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") },
                    { 42, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") },
                    { 43, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") },
                    { 44, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") },
                    { 60, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") },
                    { 67, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") },
                    { 71, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") },
                    { 74, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") },
                    { 75, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") },
                    { 76, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") },
                    { 77, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") },
                    { 67, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") },
                    { 68, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") },
                    { 69, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") },
                    { 70, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") },
                    { 71, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") },
                    { 77, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") },
                    { 78, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") },
                    { 79, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") },
                    { 80, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") },
                    { 95, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") },
                    { 56, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") },
                    { 57, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") },
                    { 58, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") },
                    { 67, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") },
                    { 70, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") },
                    { 71, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") },
                    { 73, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") },
                    { 74, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") },
                    { 75, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") },
                    { 76, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") },
                    { 41, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") },
                    { 42, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") },
                    { 46, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") },
                    { 47, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") },
                    { 61, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") },
                    { 64, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") },
                    { 65, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") },
                    { 66, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") },
                    { 79, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") },
                    { 80, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") },
                    { 2, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") },
                    { 6, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") },
                    { 9, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") },
                    { 12, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") },
                    { 17, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") },
                    { 22, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") },
                    { 27, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") },
                    { 28, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") },
                    { 32, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") },
                    { 36, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") },
                    { 81, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") },
                    { 82, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") },
                    { 83, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") },
                    { 86, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") },
                    { 89, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") },
                    { 91, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") },
                    { 94, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") },
                    { 95, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") },
                    { 96, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") },
                    { 97, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") },
                    { 1, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") },
                    { 2, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") },
                    { 3, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") },
                    { 30, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") },
                    { 31, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") },
                    { 32, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") },
                    { 33, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") },
                    { 39, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") },
                    { 40, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") },
                    { 42, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") },
                    { 27, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") },
                    { 28, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") },
                    { 29, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") },
                    { 30, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") },
                    { 31, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") },
                    { 32, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") },
                    { 33, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") },
                    { 34, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") },
                    { 35, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") },
                    { 36, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") },
                    { 61, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") },
                    { 62, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") },
                    { 63, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") },
                    { 64, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") },
                    { 65, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") },
                    { 66, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") },
                    { 67, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") },
                    { 68, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") },
                    { 69, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") },
                    { 70, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") },
                    { 1, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") },
                    { 3, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") },
                    { 4, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") },
                    { 6, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") },
                    { 10, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") },
                    { 11, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") },
                    { 12, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") },
                    { 15, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") },
                    { 17, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") },
                    { 25, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") },
                    { 51, new Guid("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") },
                    { 52, new Guid("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") },
                    { 53, new Guid("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") },
                    { 54, new Guid("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") },
                    { 55, new Guid("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") },
                    { 67, new Guid("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") },
                    { 71, new Guid("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") },
                    { 91, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") },
                    { 95, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") },
                    { 96, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") },
                    { 97, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") },
                    { 98, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") },
                    { 99, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") },
                    { 100, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") },
                    { 101, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") },
                    { 102, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") },
                    { 103, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") },
                    { 56, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") },
                    { 57, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") },
                    { 58, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") },
                    { 59, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") },
                    { 60, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") },
                    { 61, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") },
                    { 62, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") },
                    { 63, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") },
                    { 64, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") },
                    { 65, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") },
                    { 59, new Guid("b2269673-9d47-471a-a958-24160608ae82") },
                    { 62, new Guid("b2269673-9d47-471a-a958-24160608ae82") },
                    { 64, new Guid("b2269673-9d47-471a-a958-24160608ae82") },
                    { 65, new Guid("b2269673-9d47-471a-a958-24160608ae82") },
                    { 68, new Guid("b2269673-9d47-471a-a958-24160608ae82") },
                    { 69, new Guid("b2269673-9d47-471a-a958-24160608ae82") },
                    { 70, new Guid("b2269673-9d47-471a-a958-24160608ae82") },
                    { 71, new Guid("b2269673-9d47-471a-a958-24160608ae82") },
                    { 73, new Guid("b2269673-9d47-471a-a958-24160608ae82") },
                    { 76, new Guid("b2269673-9d47-471a-a958-24160608ae82") },
                    { 56, new Guid("b7d7964a-3f03-4930-a23d-59d90711f002") },
                    { 57, new Guid("b7d7964a-3f03-4930-a23d-59d90711f002") },
                    { 58, new Guid("b7d7964a-3f03-4930-a23d-59d90711f002") },
                    { 59, new Guid("b7d7964a-3f03-4930-a23d-59d90711f002") },
                    { 60, new Guid("b7d7964a-3f03-4930-a23d-59d90711f002") },
                    { 61, new Guid("b7d7964a-3f03-4930-a23d-59d90711f002") },
                    { 62, new Guid("b7d7964a-3f03-4930-a23d-59d90711f002") },
                    { 63, new Guid("b7d7964a-3f03-4930-a23d-59d90711f002") },
                    { 67, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") },
                    { 68, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") },
                    { 69, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") },
                    { 70, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") },
                    { 71, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") },
                    { 72, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") },
                    { 73, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") },
                    { 74, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") },
                    { 75, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") },
                    { 76, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") },
                    { 104, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") },
                    { 105, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") },
                    { 106, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") },
                    { 107, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") },
                    { 108, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") },
                    { 109, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") },
                    { 110, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") },
                    { 111, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") },
                    { 112, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") },
                    { 113, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") },
                    { 82, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") },
                    { 84, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") },
                    { 86, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") },
                    { 88, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") },
                    { 89, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") },
                    { 91, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") },
                    { 92, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") },
                    { 93, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") },
                    { 94, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") },
                    { 97, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") },
                    { 81, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") },
                    { 82, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") },
                    { 83, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") },
                    { 84, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") },
                    { 85, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") },
                    { 86, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") },
                    { 87, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") },
                    { 88, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") },
                    { 89, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") },
                    { 90, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") },
                    { 23, new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d") },
                    { 36, new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d") },
                    { 39, new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d") },
                    { 46, new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d") },
                    { 47, new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d") },
                    { 78, new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d") },
                    { 79, new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d") },
                    { 80, new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d") },
                    { 81, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") },
                    { 82, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") },
                    { 83, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") },
                    { 84, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") },
                    { 94, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") },
                    { 95, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") },
                    { 96, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") },
                    { 97, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") },
                    { 98, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") },
                    { 99, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") },
                    { 62, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") },
                    { 63, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") },
                    { 64, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") },
                    { 71, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") },
                    { 72, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") },
                    { 76, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") },
                    { 77, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") },
                    { 78, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") },
                    { 79, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") },
                    { 80, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") },
                    { 81, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") },
                    { 82, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") },
                    { 85, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") },
                    { 89, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") },
                    { 91, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") },
                    { 93, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") },
                    { 94, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") },
                    { 95, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") },
                    { 96, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") },
                    { 97, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") },
                    { 67, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") },
                    { 68, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") },
                    { 69, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") },
                    { 70, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") },
                    { 71, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") },
                    { 72, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") },
                    { 73, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") },
                    { 74, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") },
                    { 75, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") },
                    { 76, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") },
                    { 62, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") },
                    { 63, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") },
                    { 64, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") },
                    { 65, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") },
                    { 66, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") },
                    { 67, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") },
                    { 68, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") },
                    { 69, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") },
                    { 70, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") },
                    { 71, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") },
                    { 74, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") },
                    { 75, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") },
                    { 76, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") },
                    { 77, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") },
                    { 78, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") },
                    { 79, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") },
                    { 80, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") },
                    { 81, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") },
                    { 82, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") },
                    { 83, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") },
                    { 23, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") },
                    { 45, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") },
                    { 46, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") },
                    { 47, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") },
                    { 61, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") },
                    { 67, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") },
                    { 68, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") },
                    { 69, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") },
                    { 70, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") },
                    { 71, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") },
                    { 62, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") },
                    { 63, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") },
                    { 64, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") },
                    { 65, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") },
                    { 66, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") },
                    { 67, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") },
                    { 68, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") },
                    { 69, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") },
                    { 70, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") },
                    { 71, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") },
                    { 49, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") },
                    { 88, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") },
                    { 89, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") },
                    { 91, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") },
                    { 93, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") },
                    { 96, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") },
                    { 97, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") },
                    { 98, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") },
                    { 99, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") },
                    { 2, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") },
                    { 3, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") },
                    { 4, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") },
                    { 6, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") },
                    { 7, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") },
                    { 30, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") },
                    { 39, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") },
                    { 40, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") },
                    { 70, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") },
                    { 71, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") },
                    { 1, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") },
                    { 3, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") },
                    { 4, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") },
                    { 5, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") },
                    { 7, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") },
                    { 11, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") },
                    { 13, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") },
                    { 16, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") },
                    { 20, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") },
                    { 24, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") },
                    { 41, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") },
                    { 42, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") },
                    { 43, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") },
                    { 59, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") },
                    { 60, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") },
                    { 61, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") },
                    { 64, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") },
                    { 65, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") },
                    { 66, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") },
                    { 67, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") },
                    { 68, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") },
                    { 26, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") },
                    { 27, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") },
                    { 28, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") },
                    { 29, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") },
                    { 30, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") },
                    { 31, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") },
                    { 32, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") },
                    { 33, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") },
                    { 34, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") },
                    { 35, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") },
                    { 84, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") },
                    { 85, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") },
                    { 86, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") },
                    { 87, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") },
                    { 88, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") },
                    { 89, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") },
                    { 90, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") },
                    { 91, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") },
                    { 92, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") },
                    { 93, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") },
                    { 2, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") },
                    { 27, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") },
                    { 30, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") },
                    { 31, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") },
                    { 32, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") },
                    { 34, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") },
                    { 36, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") },
                    { 39, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") },
                    { 40, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") },
                    { 71, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, new Guid("0497ee14-d660-49a1-916d-8d2391ba6cf2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 51, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 52, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 53, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 54, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 55, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 57, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 58, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 59, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 60, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 61, new Guid("0835e1cc-d304-4b61-9b58-135ab2d27b3f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 81, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 82, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 83, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 84, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 85, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 86, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 87, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 88, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 89, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 90, new Guid("1199aa46-b03b-4cc4-921e-62b08fd5247f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 23, new Guid("153ff2f4-ccb7-43b1-b163-8f995adb1d13") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 46, new Guid("153ff2f4-ccb7-43b1-b163-8f995adb1d13") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 47, new Guid("153ff2f4-ccb7-43b1-b163-8f995adb1d13") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 30, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 31, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 33, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 34, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 37, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 38, new Guid("17923d13-ffa5-4e87-9cab-3b313d44b3ea") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 91, new Guid("19d1cc4c-18e4-42fc-9cbd-56253b20165e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 96, new Guid("19d1cc4c-18e4-42fc-9cbd-56253b20165e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 97, new Guid("19d1cc4c-18e4-42fc-9cbd-56253b20165e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 98, new Guid("19d1cc4c-18e4-42fc-9cbd-56253b20165e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 99, new Guid("19d1cc4c-18e4-42fc-9cbd-56253b20165e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 100, new Guid("19d1cc4c-18e4-42fc-9cbd-56253b20165e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 65, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 78, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 80, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 83, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 86, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 89, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 91, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 94, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 97, new Guid("1b29f96a-23e1-4824-9e66-775d807af9ae") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, new Guid("1cdb46ef-e0a5-427c-8409-9a58cde54ce9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 28, new Guid("1cdb46ef-e0a5-427c-8409-9a58cde54ce9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 29, new Guid("1cdb46ef-e0a5-427c-8409-9a58cde54ce9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 30, new Guid("1cdb46ef-e0a5-427c-8409-9a58cde54ce9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 32, new Guid("1cdb46ef-e0a5-427c-8409-9a58cde54ce9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 44, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 75, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 80, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 81, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 82, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 83, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 84, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 85, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 86, new Guid("20b9c66b-7518-4cbc-aa39-f8bf41f0a423") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 48, new Guid("2301041e-8c28-4711-b70d-9daed300ae21") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 49, new Guid("2301041e-8c28-4711-b70d-9daed300ae21") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 50, new Guid("2301041e-8c28-4711-b70d-9daed300ae21") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 51, new Guid("2301041e-8c28-4711-b70d-9daed300ae21") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 52, new Guid("2301041e-8c28-4711-b70d-9daed300ae21") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 53, new Guid("2301041e-8c28-4711-b70d-9daed300ae21") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 54, new Guid("2301041e-8c28-4711-b70d-9daed300ae21") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 55, new Guid("2301041e-8c28-4711-b70d-9daed300ae21") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 14, new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 18, new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 19, new Guid("2641ba50-9bdf-4107-80e8-a723e7feb06e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 39, new Guid("2d624f65-a74a-4011-a187-862f58df7885") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 40, new Guid("2d624f65-a74a-4011-a187-862f58df7885") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 41, new Guid("2d624f65-a74a-4011-a187-862f58df7885") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 42, new Guid("2d624f65-a74a-4011-a187-862f58df7885") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 43, new Guid("2d624f65-a74a-4011-a187-862f58df7885") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 44, new Guid("2d624f65-a74a-4011-a187-862f58df7885") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 45, new Guid("2d624f65-a74a-4011-a187-862f58df7885") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 46, new Guid("2d624f65-a74a-4011-a187-862f58df7885") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 47, new Guid("2d624f65-a74a-4011-a187-862f58df7885") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 48, new Guid("2d624f65-a74a-4011-a187-862f58df7885") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 20, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 24, new Guid("2f5c9c2f-de8c-4396-90af-534f4e163439") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 59, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 60, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 61, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 62, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 63, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 65, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 66, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 67, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 68, new Guid("31105ee2-5a05-4bcf-bff7-f07be401442e") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 62, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 63, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 65, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 66, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 67, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 68, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 69, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 70, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("31550335-200e-442a-9cca-f1d0f62c0819") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 46, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 47, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 59, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 61, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 62, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 67, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 68, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 70, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 72, new Guid("347c951c-16c5-4043-bedc-a847c40fcb7f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 75, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 76, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 77, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 78, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 79, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 80, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 81, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 82, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 83, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 84, new Guid("35a26eb2-c01c-4df3-b98d-40561190ae36") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 27, new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 28, new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 29, new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 31, new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 32, new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 33, new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 34, new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 35, new Guid("37991d47-ddc6-400b-a3fe-b17b998a76b2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 65, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 66, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 67, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 68, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 69, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 70, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 73, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 98, new Guid("38c07b15-1adc-47fb-adca-5a93ab1ec6c3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 65, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 66, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 72, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 81, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 82, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 96, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 97, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 98, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 99, new Guid("3a76ac51-89f5-4b7f-a2fb-cca12abc04e9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 51, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 52, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 53, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 54, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 55, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 94, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 95, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 96, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 97, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 98, new Guid("3b2a5c6e-7f9d-4b1e-8a3c-2d5a9c7f6e1b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 30, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 31, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 39, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 40, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 78, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a4") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 22, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 23, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 24, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 39, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 40, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 45, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 46, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 47, new Guid("3c36090f-464c-4c80-ac2b-e32ca07c44a9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 56, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 57, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 58, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 77, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 78, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 79, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 80, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 94, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 95, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 97, new Guid("3e0f155c-6f59-4214-a4e4-2d992447488f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 42, new Guid("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 43, new Guid("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 59, new Guid("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 62, new Guid("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 76, new Guid("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 77, new Guid("3f059c7a-b764-49b9-bf1d-e5e2359e0cf6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 30, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 33, new Guid("43b4e2b2-a2ce-4e8b-b07f-9d20b014bb5f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 42, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 43, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 44, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 46, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 67, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 68, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 76, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 77, new Guid("4a6b6c16-1593-4425-935c-d2ddc3c8eef5") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 62, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 63, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 73, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 74, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 75, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 76, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 77, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 78, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 79, new Guid("4ce9ea91-e281-47df-9fc7-79f0c9a95ddd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 41, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 76, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 77, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 78, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 91, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 92, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 93, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 94, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 95, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 96, new Guid("4f2d3b1e-6a9c-4d7f-8e5b-1c7a5d3b4e2f") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 49, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 50, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 51, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 52, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 53, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 54, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 55, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 56, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 57, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 58, new Guid("52432a25-6a28-480e-ab5c-17fd71be2ffb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 65, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 73, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 76, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 77, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 78, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 79, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 80, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 83, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 84, new Guid("525d6c44-e75c-466a-9510-fb4c0d8f28d1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 27, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 28, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 29, new Guid("53a20833-f2ef-4cb7-a049-326d0cb255ad") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 29, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 30, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 37, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 38, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 47, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 48, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 49, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 50, new Guid("55d9f2d3-8b0e-48da-baf5-f782a7b2d5f8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 8, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, new Guid("597719b7-3036-4f95-92f8-5163b3e18931") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 51, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 52, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 85, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 86, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 89, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 91, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 93, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 94, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 95, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 99, new Guid("5ac8a9fd-f2bf-478b-afc0-492f8aa7bed2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 29, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 30, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 31, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 33, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 34, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 35, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 38, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 39, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 40, new Guid("5b68ad8c-f42e-40d7-87de-3622d34dcf84") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 69, new Guid("60786725-191b-4172-acd8-ef669024173b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("60786725-191b-4172-acd8-ef669024173b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 72, new Guid("60786725-191b-4172-acd8-ef669024173b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 73, new Guid("60786725-191b-4172-acd8-ef669024173b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 90, new Guid("60786725-191b-4172-acd8-ef669024173b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 91, new Guid("60786725-191b-4172-acd8-ef669024173b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 92, new Guid("60786725-191b-4172-acd8-ef669024173b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 93, new Guid("60786725-191b-4172-acd8-ef669024173b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 94, new Guid("60786725-191b-4172-acd8-ef669024173b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 97, new Guid("60786725-191b-4172-acd8-ef669024173b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 51, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 52, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 53, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 54, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 55, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 92, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 93, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 94, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 95, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 96, new Guid("6ca18a54-6c7b-46af-b298-fa756919a4f1") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 30, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 32, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 34, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 36, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 37, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 38, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 39, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 40, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 41, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 42, new Guid("6d46504c-1a72-4036-98e3-3434676e05bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 50, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 51, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 52, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 53, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 54, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 55, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 81, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 82, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 93, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 94, new Guid("70e6cdc7-85df-452f-84ea-5e985024734c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 61, new Guid("7c5891f9-9fac-4dbf-9afd-2c9e01759e20") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 65, new Guid("7c5891f9-9fac-4dbf-9afd-2c9e01759e20") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 76, new Guid("7c5891f9-9fac-4dbf-9afd-2c9e01759e20") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 94, new Guid("7c5891f9-9fac-4dbf-9afd-2c9e01759e20") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 94, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 95, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 96, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 97, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 98, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 99, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 100, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 101, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 102, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 103, new Guid("7e246319-564e-4920-bd8c-6029be2a7729") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 42, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 43, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 44, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 60, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 67, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 74, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 75, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 76, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 77, new Guid("81319e22-745a-45c6-9402-6d1389fd0f44") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 67, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 68, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 69, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 70, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 77, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 78, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 79, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 80, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 95, new Guid("83ae68c3-f621-4f03-bda7-73d77aec8ce3") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 56, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 57, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 58, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 67, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 70, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 73, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 74, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 75, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 76, new Guid("866d732a-ab7e-42b8-aa7d-3bfb6e1477da") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 41, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 42, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 46, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 47, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 61, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 65, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 66, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 79, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 80, new Guid("87dbaf90-f343-423e-9f14-e124fd145730") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 9, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 22, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 27, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 28, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 32, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 36, new Guid("8fa4d8c8-aa4b-4d01-9cd3-a1e94628e473") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 81, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 82, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 83, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 86, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 89, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 91, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 94, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 95, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 96, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 97, new Guid("92bbd7a3-42a9-4b3e-8e9c-6fa4830404d2") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 30, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 31, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 32, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 33, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 39, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 40, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 42, new Guid("939a97f5-10b8-4d6c-ab74-ce77187d36df") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 27, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 28, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 29, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 30, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 31, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 32, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 33, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 34, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 35, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 36, new Guid("944cbcf3-7479-4eed-97f1-80fd4c50eda6") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 61, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 62, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 63, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 65, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 66, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 67, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 68, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 69, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 70, new Guid("97767fcd-f146-4e88-87dd-f1f1806dec49") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 10, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 12, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 15, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 17, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 25, new Guid("a0deb200-955f-4b6c-b550-9ca1712392a8") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 51, new Guid("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 52, new Guid("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 53, new Guid("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 54, new Guid("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 55, new Guid("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 67, new Guid("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("a748c5cb-884e-46a4-b1c3-1bd4a4c2d7c7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 91, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 95, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 96, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 97, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 98, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 99, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 100, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 101, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 102, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 103, new Guid("a9805c2f-71d4-4c13-92fb-ac069cb7d633") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 56, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 57, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 58, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 59, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 60, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 61, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 62, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 63, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 65, new Guid("b0c0659c-a57a-4acb-a906-5e3bf9ab2675") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 59, new Guid("b2269673-9d47-471a-a958-24160608ae82") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 62, new Guid("b2269673-9d47-471a-a958-24160608ae82") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("b2269673-9d47-471a-a958-24160608ae82") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 65, new Guid("b2269673-9d47-471a-a958-24160608ae82") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 68, new Guid("b2269673-9d47-471a-a958-24160608ae82") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 69, new Guid("b2269673-9d47-471a-a958-24160608ae82") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 70, new Guid("b2269673-9d47-471a-a958-24160608ae82") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("b2269673-9d47-471a-a958-24160608ae82") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 73, new Guid("b2269673-9d47-471a-a958-24160608ae82") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 76, new Guid("b2269673-9d47-471a-a958-24160608ae82") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 56, new Guid("b7d7964a-3f03-4930-a23d-59d90711f002") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 57, new Guid("b7d7964a-3f03-4930-a23d-59d90711f002") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 58, new Guid("b7d7964a-3f03-4930-a23d-59d90711f002") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 59, new Guid("b7d7964a-3f03-4930-a23d-59d90711f002") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 60, new Guid("b7d7964a-3f03-4930-a23d-59d90711f002") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 61, new Guid("b7d7964a-3f03-4930-a23d-59d90711f002") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 62, new Guid("b7d7964a-3f03-4930-a23d-59d90711f002") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 63, new Guid("b7d7964a-3f03-4930-a23d-59d90711f002") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 67, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 68, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 69, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 70, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 72, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 73, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 74, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 75, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 76, new Guid("b9b2181b-d620-4db0-9561-9c1ba02480bb") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 104, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 105, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 106, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 107, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 108, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 109, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 110, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 111, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 112, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 113, new Guid("ba694638-8e1c-4398-a3db-50b879ea1414") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 82, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 84, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 86, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 88, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 89, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 91, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 92, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 93, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 94, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 97, new Guid("ba7faac0-0e0c-4fb8-a329-5483da03032c") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 81, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 82, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 83, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 84, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 85, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 86, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 87, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 88, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 89, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 90, new Guid("bb491436-8b44-4049-8f28-60b5689b6fd7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 23, new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 36, new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 39, new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 46, new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 47, new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 78, new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 79, new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 80, new Guid("c2199980-e00d-45dd-bdb6-8497cfeac41d") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 81, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 82, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 83, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 84, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 94, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 95, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 96, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 97, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 98, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 99, new Guid("c2c1137a-2957-489a-b6bc-a520a28c3206") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 62, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 63, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 72, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 76, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 77, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 78, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 79, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 80, new Guid("c54c442f-e6a2-40b7-a022-3a58bccb2b3b") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 81, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 82, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 85, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 89, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 91, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 93, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 94, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 95, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 96, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 97, new Guid("c5f0f42f-255f-400d-b657-bed222ec9903") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 67, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 68, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 69, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 70, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 72, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 73, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 74, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 75, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 76, new Guid("c9ea88e7-aba3-4aa3-8dd7-0977a84004c9") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 62, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 63, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 65, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 66, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 67, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 68, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 69, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 70, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("ca6dcc5d-3c35-4bd9-9a4c-f1e76f85c978") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 74, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 75, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 76, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 77, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 78, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 79, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 80, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 81, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 82, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 83, new Guid("cca9654e-d839-4e21-a23d-01fbb75e0a26") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 23, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 45, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 46, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 47, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 61, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 67, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 68, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 69, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 70, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("ccedb55a-6010-4ec9-913b-caa122d34ba7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 62, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 63, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 65, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 66, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 67, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 68, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 69, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 70, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("cd88e529-eedb-42c5-a88d-384f5976a754") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 49, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 88, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 89, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 91, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 93, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 96, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 97, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 98, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 99, new Guid("d496f336-c5ab-4648-841c-38853c4aa4f7") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 6, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 30, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 39, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 40, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 70, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("dd39eee3-6b17-4b39-95e0-075ad1b704bd") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 1, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 3, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 4, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 5, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 7, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 11, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 13, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 16, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 20, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 24, new Guid("e60df533-79d7-42f2-a36d-99362dbc6f85") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 41, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 42, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 43, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 59, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 60, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 61, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 64, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 65, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 66, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 67, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 68, new Guid("ecf7b85e-8c3c-47ee-a80d-b0b360512c16") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 26, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 27, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 28, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 29, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 30, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 31, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 32, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 33, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 34, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 35, new Guid("f102e342-a664-4b43-bcdb-b1c6945bf241") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 84, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 85, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 86, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 87, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 88, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 89, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 90, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 91, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 92, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 93, new Guid("f3952051-fbde-4d44-a9b7-c3cb54027090") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 2, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 27, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 30, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 31, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 32, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 34, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 36, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 39, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 40, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") });

            migrationBuilder.DeleteData(
                table: "ResumeSkill",
                keyColumns: new[] { "SkillId", "UserId" },
                keyValues: new object[] { 71, new Guid("ffd79ac4-d69f-4b74-b7c2-67e92905239a") });
        }
    }
}
