using BookShop.Domain.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Domain.FluentAPIs
{
    public class RoleFluentAPIs : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(x => x.RoleName).HasColumnName("RoleName").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasColumnName("Description").HasColumnType("nvarchar(MAX)").IsRequired();
            builder.Property(x => x.ParentRoleId).HasColumnName("ParentRoleId").HasColumnType("int");
            builder.HasOne(x => x.ParentRole).WithMany(x => x.childRoles).HasForeignKey(x => x.ParentRoleId).OnDelete(DeleteBehavior.NoAction); ;
            builder.ToTable("Role");
        }
    }
}
