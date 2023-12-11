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
    public class PermissionFluentAPIs : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.Property(x => x.PermissionName).HasColumnName("PermissionName").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Description).HasColumnName("Description").HasColumnType("nvarchar(MAX)").IsRequired();
            builder.Property(x => x.ParentPermissionId).HasColumnName("ParentPermissionId").HasColumnType("int");
            builder.HasOne(x => x.ParentPermission).WithMany(x => x.ChildParentPermissions).HasForeignKey(x => x.ParentPermissionId).OnDelete(DeleteBehavior.Restrict); ;
            builder.ToTable("Permission");  
        }
    }
}
