namespace Core.Models.Enums
{
    public enum StatusRicRollOut
    {
        Draft = 0,
        Submitted_To_BR = 1,
        Review_BR = 2,

        Rejected_By_BR = 3,
        Submitted_To_BR_Manager = 4, // legacy
        Approved_By_BR_Manager = 5,  // legacy

        Approval_Manager_User = 6,
        Approval_VP_User = 7,
        Approval_Manager_BR = 8,
        Done = 9,
    }
}
