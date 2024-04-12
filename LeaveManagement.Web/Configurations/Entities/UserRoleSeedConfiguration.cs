using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<Microsoft.AspNetCore.Identity.IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "cac43a6f-f5cc-66a4-baa2-a1bfc5af2c6b",
                    UserId = "434271b6-429b-42a6-8f5d-9b9d32b8a5dc"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "cac13a0f-f5ac-6fa3-b3a1-a1bcc5bf2c8d",
                    UserId = "69abc1b6-413b-4586-85b2-964d2f9a5cc"
                }
            );
        }
    }
}