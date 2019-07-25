using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KidsStore.Models
{
    public class LoginModel
    {
        [Key]
        [Display(Name = "Tên đăng nhập")]
        [Required(ErrorMessage = "Yêu cầu nhập tên đăng nhập")]
        public string UserName { set; get; }
        [Display(Name = "Nhập mật khẩu")]
        [Compare("Password", ErrorMessage = "Yêu cầu nhập mật khẩu.")]
        public string Password { set; get; }

    }
}