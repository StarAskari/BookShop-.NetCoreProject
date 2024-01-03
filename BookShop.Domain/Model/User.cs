using BookShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Domain.Model
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ConfirmedEmail { get; set; }
        public string PhoneNumber { get; set; }
        public string ValidDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string PasswordHash { get; set; }
        public EnumNoeUser NoeUser { get; set; }
        public System.DateTime? LastPasswordChangeDate { get; set; }
        public ICollection<UserRole> UserRoles { get; set; }

    }
}
