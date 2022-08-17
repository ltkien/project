using BloodFlow.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace BloodFlow.Data;

public static class SeedData
{
    public static void Seed(this ModelBuilder builder)
        {
            #region RoleData

            var adminRole = new IdentityRole()
            {
                Name = "Admin",
                NormalizedName = "ADMIN",
            };
            var userRole = new IdentityRole()
            {
                Name = "User",
                NormalizedName = "USER",
            };

            builder.Entity<IdentityRole>().HasData(
                adminRole,
                userRole
            );

            #endregion RoleData

            #region UserData

            var hasher = new PasswordHasher<User>();
            var admin = new User()
            {
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN",
                FullName = "Le Trung Kien",
                Email = "admin@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
            };
            var user = new User()
            {
                UserName = "user@gmail.com",
                FullName = "User",
                Email = "user@gmail.com",
                EmailConfirmed = true,
                PhoneNumberConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "User@123"),
            };
            builder.Entity<User>().HasData(
                admin,
                user
                );

            #endregion UserData

            #region UserRole

            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string> { UserId = admin.Id, RoleId = adminRole.Id },
                new IdentityUserRole<string> { UserId = user.Id, RoleId = userRole.Id }
                );

            #endregion UserRole
        }
}