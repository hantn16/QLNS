using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace QLNS.Model.Models
{
    [Table("Employee")]
    public class Employee : Abstracts.Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }

        [MaxLength(50)]
        [Display(Name = "Họ và tên")]
        public string Name { get; set; }

        [Display(Name = "Ngày sinh")]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Giới tính")]
        public bool Gender { get; set; }

        [Display(Name = "Điện thoại")]
        public string Phone { get; set; }

        public string Email { get; set; }

        [Display(Name = "CMND")]
        public string IDCardNo { get; set; }

        [Display(Name = "Ngày cấp")]
        public DateTime DateIssued { get; set; }

        [Display(Name = "Nơi cấp")]
        public string PlaceIssued { get; set; }

        [Display(Name = "Ngày vào làm")]
        [DataType(DataType.Date)]
        public DateTime JoinDate { get; set; }

        [Display(Name = "Mã phòng ban")]
        public int DepartmentId { get; set; }

        [Display(Name = "Mã QLTT")]
        public long? LeaderId { get; set; }

        [Display(Name = "Mã chức vụ")]
        public int PositionId { get; set; }

        //Navigation Properties
        public virtual ICollection<WorkingProcess> WorkingProcesses { get; set; }

        [ForeignKey("PositionId")]
        public virtual Position Position { get; set; }

        [ForeignKey("LeaderId")]
        public virtual Employee Leader { get; set; }

        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
    }
}
