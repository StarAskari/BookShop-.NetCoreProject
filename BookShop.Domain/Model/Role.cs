using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Domain.Model
{
    public class Role:BaseEntity
    {
        public string RoleName { get; set; }
        public string Description { get; set; }
        public int? ParentRoleId { get; set; }
        public Role ParentRole { get; set; }
        public ICollection<Role> childRoles { get; set; }

    }
}
