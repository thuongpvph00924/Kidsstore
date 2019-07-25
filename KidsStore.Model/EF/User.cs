namespace KidsStore.Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
        public long ID { get; set; }

        [StringLength(50)]
        [Display(Name = "Tài Khoản")]
        public string UserName { get; set; }

        [StringLength(32)]

        public string Password { get; set; }

        [StringLength(20)]
        public string GroupID { get; set; }

        [StringLength(50)]
        [Display(Name = "Họ Tên")]
        public string Name { get; set; }

        [StringLength(50)]
        [Display(Name = "Địa Chỉ")]
        public string Address { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        [Display(Name = "Điện Thoại")]
        public string Phone { get; set; }

        public int? ProvinceID { get; set; }

        public int? DistrictID { get; set; }
        [Display(Name = "Ngày Tạo")]
        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public bool? Status { get; set; }
    }
}
