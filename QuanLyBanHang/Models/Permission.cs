﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyBanHang.Models
{
    public class Permission
    {
       

        public int Id { get; set; }
        [Display(Name = "Name")]
        public string name { get; set; }

        public virtual ICollection<Permission_Role> Permission_Role { get; set; }
    }
}