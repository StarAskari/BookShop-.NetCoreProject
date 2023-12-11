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
    public class UserFluentAPIs : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Name).HasColumnName("Name").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.UserName).HasColumnName("UserName").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.Email).HasColumnName("Email").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.ConfirmedEmail).HasColumnName("ConfirmedEmail").HasColumnType("nvarchar").HasMaxLength(50).IsRequired();
            builder.Property(x => x.PhoneNumber).HasColumnName("PhoneNumber").HasColumnType("char").IsFixedLength().HasMaxLength(11).IsRequired();
            builder.Property(x => x.NoeUser).HasColumnName("NoeUser").HasColumnType("int").IsRequired();
            builder.Property(u => u.ValidDate).HasColumnName(@"ValidDate").HasColumnType("char").IsFixedLength().IsUnicode(false).HasMaxLength(10).IsRequired();
            builder.Property(u => u.LastLoginDate).HasColumnName(@"LastLoginDate").HasColumnType("datetime");
            builder.Property(u => u.LastPasswordChangeDate).HasColumnName(@"LastPasswordChangeDate").HasColumnType("datetime");
            builder.ToTable("User");  
        }
    }
}
