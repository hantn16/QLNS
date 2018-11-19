using System;

namespace QLNS.Model.Abstracts
{
    interface IAuditable
    {
        bool Status { get; set; }
        DateTime CreatedDate { get; set; }
        string CreatedBy { get; set; }
        DateTime? ModifiedDate { get; set; }
        string ModifiedBy { get; set; }
    }
}
