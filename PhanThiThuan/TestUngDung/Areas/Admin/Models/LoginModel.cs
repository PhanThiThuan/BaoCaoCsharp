﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestUngDung.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "mời nhập user name")]
        public string UserName { set; get; }
        [Required(ErrorMessage = "mời nhập password")]

        public string Password { set; get; }
        public bool RememberMe { set; get; }

    }
}