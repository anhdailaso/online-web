using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BooShop.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="mời bạn nhập user name.")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="mời bạn nhập password.")]
        public string PassWord { get; set; }

        public bool Remember { get; set; }
    }
}