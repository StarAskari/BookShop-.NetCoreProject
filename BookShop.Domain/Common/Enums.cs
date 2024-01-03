using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Domain.Common
{
    public enum EnumActiveOrNot
    {
        [EnumMember]
        Active=1,
        [EnumMember]
        NotActive=2,
    }

    public enum EnumNoeUser
    {
        [EnumMember]
        Admin=1,
        [EnumMember]
        User=2
    }
}
