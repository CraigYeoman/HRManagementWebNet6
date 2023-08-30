using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRManagementData.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                 new Employee
                 {
                     Id = "408aa945-3d84-4421-8342-7269ec64d949",
                     Email = "admin@localhost.com",
                     NormalizedEmail = "ADMIN@LOCALHOST.COM",
                     NormalizedUserName = "ADMIN@LOCALHOST.COM",
                     UserName = "admin@localhost.com",
                     Firstname = "System",
                     Lastname = "Admin",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 },
                 new Employee
                 {
                     Id = "3f4631bd-f907-4409-b416-ba356312e659",
                     Email = "user1@localhost.com",
                     NormalizedEmail = "USER1@LOCALHOST.COM",
                     NormalizedUserName = "USER1@LOCALHOST.COM",
                     UserName = "user1@localhost.com",
                     Firstname = "John",
                     Lastname = "Connor",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 },
                 new Employee
                 {
                     Id = "3f4631bd-f907-4410-b416-ba356312e659",
                     Email = "user2@localhost.com",
                     NormalizedEmail = "USER2@LOCALHOST.COM",
                     NormalizedUserName = "USER2@LOCALHOST.COM",
                     UserName = "user2@localhost.com",
                     Firstname = "Sarah",
                     Lastname = "Connor",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 },
                 new Employee
                 {
                     Id = "3f4631bd-f907-4411-b416-ba356312e659",
                     Email = "user3@localhost.com",
                     NormalizedEmail = "USER3@LOCALHOST.COM",
                     NormalizedUserName = "USER3@LOCALHOST.COM",
                     UserName = "user3@localhost.com",
                     Firstname = "Niki",
                     Lastname = "Lauda",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 },
                 new Employee
                 {
                     Id = "3f4631bd-f907-4412-b416-ba356312e659",
                     Email = "user4@localhost.com",
                     NormalizedEmail = "USER4@LOCALHOST.COM",
                     NormalizedUserName = "USER4@LOCALHOST.COM",
                     UserName = "user4@localhost.com",
                     Firstname = "James",
                     Lastname = "Hunt",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 },
                 new Employee
                 {
                     Id = "3f4631bd-f907-4413-b416-ba356312e659",
                     Email = "user5@localhost.com",
                     NormalizedEmail = "USER5@LOCALHOST.COM",
                     NormalizedUserName = "USER5@LOCALHOST.COM",
                     UserName = "user5@localhost.com",
                     Firstname = "Mario",
                     Lastname = "Andretti",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 },
                 new Employee
                 {
                     Id = "3f4631bd-f907-4414-b416-ba356312e659",
                     Email = "user6@localhost.com",
                     NormalizedEmail = "USER6@LOCALHOST.COM",
                     NormalizedUserName = "USER6@LOCALHOST.COM",
                     UserName = "use6r@localhost.com",
                     Firstname = "Scott",
                     Lastname = "Bloomquist",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 },
                 new Employee
                 {
                     Id = "3f4631bd-f907-4415-b416-ba356312e659",
                     Email = "user7@localhost.com",
                     NormalizedEmail = "USER7@LOCALHOST.COM",
                     NormalizedUserName = "USER7@LOCALHOST.COM",
                     UserName = "user7@localhost.com",
                     Firstname = "John",
                     Lastname = "Force",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 },
                 new Employee
                 {
                     Id = "3f4631bd-f907-4416-b416-ba356312e659",
                     Email = "user8@localhost.com",
                     NormalizedEmail = "USER8@LOCALHOST.COM",
                     NormalizedUserName = "USER8@LOCALHOST.COM",
                     UserName = "user8@localhost.com",
                     Firstname = "Don",
                     Lastname = "Prudhomme",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 },
                 new Employee
                 {
                     Id = "3f4631bd-f907-4417-b416-ba356312e659",
                     Email = "user9@localhost.com",
                     NormalizedEmail = "USER9@LOCALHOST.COM",
                     NormalizedUserName = "USER9@LOCALHOST.COM",
                     UserName = "user9@localhost.com",
                     Firstname = "Tom",
                     Lastname = "McEwen",
                     PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                     EmailConfirmed = true
                 }
            );
        }
    }
}