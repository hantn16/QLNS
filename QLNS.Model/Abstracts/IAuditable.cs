using System;

namespace QLNS.Model.Abstracts
{
    interface IAuditable
    {
        bool Status { get; set; }
        DateTime CreatedAt { get; set; }
        string CreatedBy { get; set; }
        DateTime? ModifiedAt { get; set; }
        string ModifiedBy { get; set; }
    }
}
