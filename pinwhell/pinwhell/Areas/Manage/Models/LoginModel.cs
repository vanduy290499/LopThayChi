using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace pinwhell.Areas.Manage.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage ="Vui lòng nhập Tên đăng nhập")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Vui lòng nhập Mật Khẩu")]
        public string PassWord { get; set; }

        public bool RememberMe { get; set; }
    }
}