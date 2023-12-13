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
    public class RolePermissionFluentAPIs : IEntityTypeConfiguration<RolePermission>
    {
        public void Configure(EntityTypeBuilder<RolePermission> builder)
        {
            builder.Property(x => x.RoleId).HasColumnName("RoleId").HasColumnType("int").IsRequired();
            builder.Property(x => x.PermissionId).HasColumnName("PermissionId").HasColumnType("int").IsRequired();

            builder.HasOne(x => x.Role).WithMany(x => x.rolePermissions).HasForeignKey(x => x.RoleId).OnDelete(DeleteBehavior.NoAction); ;
            builder.HasOne(x => x.Permission).WithMany(x => x.rolePermissions).HasForeignKey(x => x.PermissionId).OnDelete(DeleteBehavior.NoAction); ;
            builder.ToTable("RolePermission");
        }
    }
}
