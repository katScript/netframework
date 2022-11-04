using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace WDP2022A2Win.Data
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder builder)
        {
            var passwordHasher = new PasswordHasher<IdentityUser>();

            // Seed Roles
            var adminRole = new IdentityRole("Admin");
            adminRole.NormalizedName = adminRole.Name.ToUpper();

            List<IdentityRole> roles = new List<IdentityRole>() { 
                adminRole
            };

            builder.Entity<IdentityRole>().HasData(roles);

            // Seed Users
            var adminUser = new IdentityUser
            {
                UserName = "admin@asp.net",
                Email = "admin@asp.net",
                EmailConfirmed = true,
            };
            adminUser.NormalizedUserName = adminUser.UserName.ToUpper();
            adminUser.NormalizedEmail = adminUser.Email.ToUpper();
            adminUser.PasswordHash = passwordHasher.HashPassword(adminUser, "Admin1@3");

            var memberUser = new IdentityUser
            {
                UserName = "user@asp.net",
                Email = "user@asp.net",
                EmailConfirmed = true,
            };
            memberUser.NormalizedUserName = memberUser.UserName.ToUpper();
            memberUser.NormalizedEmail = memberUser.Email.ToUpper();
            memberUser.PasswordHash = passwordHasher.HashPassword(memberUser, "User1@3");

            List<IdentityUser> users = new List<IdentityUser>() {
                adminUser,
                memberUser
            };

            builder.Entity<IdentityUser>().HasData(users);

            // Seed UserRoles
            List<IdentityUserRole<string>> userRoles = new List<IdentityUserRole<string>>();

            userRoles.Add(new IdentityUserRole<string>
            {
                UserId = users[0].Id,
                RoleId = roles.First(q => q.Name == "Admin").Id
            });

            builder.Entity<IdentityUserRole<string>>().HasData(userRoles);
        }
    }

}