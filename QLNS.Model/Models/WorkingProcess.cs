using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model.Models
{
    [Table("WorkingProcess")]
    public class WorkingProcess : Abstracts.Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [Display(Name = "Mã nhân viên")]
        public long EmployeeId { get; set; }

        [Display(Name = "Mã phòng ban")]
        public int DepartmentId { get; set; }

        [Display(Name = "Mã chức vụ")]
        public int PositionId { get; set; }

        [Display(Name = "Ngày bắt đầu")]
        [Required]
        public DateTime StartDate { get; set; }

        [Display(Name = "Ngày kết thúc")]
        [Required]
        public DateTime EndDate { get; set; }

        //Navigation Properties
        [ForeignKey("EmployeeId")]
        public virtual Employee Employee { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }
    }
}
