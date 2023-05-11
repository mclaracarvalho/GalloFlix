using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GalloFlix.Migrations
{
    public partial class popularusuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9f79304f-7f4b-43dd-87bc-8003eca6024b", "64a40bb2-8a27-4c5b-8ea7-ae6d065fa9e3", "Usuário", "USUÁRIO" },
                    { "dc44385c-6435-470e-bd1d-14619d3ef507", "a44e7be5-4156-4e77-98d0-43e30e2364a0", "Moderador", "MODERADOR" },
                    { "fa9db466-5cf5-443b-94d2-ea4eeb8eea85", "62b10778-97cf-4cca-938c-a73c38f319aa", "Administrador", "ADMINISTRADOR" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Discriminator", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c9f0d183-737c-4b81-98e2-fe2f40d943ff", 0, "5b2536fc-a190-471b-ac31-100f6fba3f99", new DateTime(2005, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "AppUser", "mclara18062005@gmail.com", true, false, null, "Maria Clara Carvalho dos Santos", "MCLARA18062005@GMAIL.COM", "MCLARA", "AQAAAAEAACcQAAAAEO8oxUIo9UkaWIL7NlXO8JmmkQ4zjEPafHADcCw1G2WDJpt6/+AqJvMlcAV1GDDm6g==", "14997692684", true, "/img/users/avatar.png", "159f67fd-bde2-42da-9915-87f420684ad2", false, "Mclara" });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "fa9db466-5cf5-443b-94d2-ea4eeb8eea85", "c9f0d183-737c-4b81-98e2-fe2f40d943ff" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "9f79304f-7f4b-43dd-87bc-8003eca6024b");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "dc44385c-6435-470e-bd1d-14619d3ef507");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fa9db466-5cf5-443b-94d2-ea4eeb8eea85", "c9f0d183-737c-4b81-98e2-fe2f40d943ff" });

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: "fa9db466-5cf5-443b-94d2-ea4eeb8eea85");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: "c9f0d183-737c-4b81-98e2-fe2f40d943ff");
        }
    }
}
