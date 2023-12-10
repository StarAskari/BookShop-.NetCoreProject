﻿using BookShop.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookShop.Domain.Model
{
    public class User : BaseEntity
    {
        private int? _iterations;
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string ConfirmedEmail { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime? ValidDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public string PasswordHash { get; set; }
        public EnumNoeUser NoeUser { get; set; }
        public System.DateTime? LastPasswordChangeDate { get; set; }
        public int? Iterations
        {
            get { return null; }
            set { _iterations = value; }
        }
    }
}