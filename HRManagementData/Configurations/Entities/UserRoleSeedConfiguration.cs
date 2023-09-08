using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HRManagementData.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
               new IdentityUserRole<string>
               {
                   RoleId = "cac43a6e-f7bb-4448-baaf-1add431ccbbf",
                   UserId = "408aa945-3d84-4421-8342-7269ec64d949"
               },
               new IdentityUserRole<string>
               {
                   RoleId = "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                   UserId = "3f4631bd-f907-4409-b416-ba356312e659"
               },
               new IdentityUserRole<string>
               {
                   RoleId = "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                   UserId = "3f4631bd-f907-4410-b416-ba356312e659"
               },
               new IdentityUserRole<string>
               {
                   RoleId = "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                   UserId = "3f4631bd-f907-4411-b416-ba356312e659"
               },
               new IdentityUserRole<string>
               {
                   RoleId = "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                   UserId = "3f4631bd-f907-4412-b416-ba356312e659"
               },
               new IdentityUserRole<string>
               {
                   RoleId = "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                   UserId = "3f4631bd-f907-4413-b416-ba356312e659"
               },
               new IdentityUserRole<string>
               {
                   RoleId = "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                   UserId = "3f4631bd-f907-4414-b416-ba356312e659"
               },
               new IdentityUserRole<string>
               {
                   RoleId = "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                   UserId = "3f4631bd-f907-4415-b416-ba356312e659"
               },
               new IdentityUserRole<string>
               {
                   RoleId = "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                   UserId = "3f4631bd-f907-4416-b416-ba356312e659"
               },
               new IdentityUserRole<string>
               {
                   RoleId = "cac43a7e-f7cb-4148-baaf-1acb431eabbf",
                   UserId = "3f4631bd-f907-4417-b416-ba356312e659"
               }
           );
        }
    }
}