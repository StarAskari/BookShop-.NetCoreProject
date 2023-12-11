using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Domain.Model
{
    public class Permission:BaseEntity
    {
        public string PermissionName { get; set; }
        public string Description { get; set; }
        public int? ParentPermissionId { get; set; }
        public Permission ParentPermission { get; set; }
        public ICollection<Permission> ChildParentPermissions { get; set; }
    }
}
