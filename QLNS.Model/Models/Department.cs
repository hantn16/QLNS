using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Model.Models
{

    [Table("Department")]
    public class Department : Abstracts.Auditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        [Display(Name = "Tên phòng ban")]
        public string Name { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName = "varchar")]
        public string Alias { get; set; }

        //Navigation Properties
        public virtual ICollection<Employee> Employees { get; set; }

        public virtual ICollection<WorkingProcess> WorkingProcesses { get; set; }
    }
    
}
