using System;
using System.ComponentModel.DataAnnotations;

namespace QLNS.Model.Abstracts
{
    public class Auditable : IAuditable
    {
        [Display(Name = "Tình trạng")]
        public bool Status { get; set; }

        [Display(Name = "Ngày tạo")]
        public DateTime CreatedDate { get; set; }

        [Display(Name = "Người tạo")]
        public string CreatedBy { get; set; }

        [Display(Name = "Ngày sửa")]
        public DateTime? ModifiedDate { get; set; }

        [Display(Name = "Người sửa")]
        public string ModifiedBy { get; set; }
    }
}
