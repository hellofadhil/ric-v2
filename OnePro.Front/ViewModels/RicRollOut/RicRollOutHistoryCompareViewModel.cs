using Core.Contracts.RicRollOut.Responses;

namespace OnePro.Front.ViewModels.RicRollOut
{
    public class RicRollOutHistoryCompareViewModel
    {
        public Guid RollOutId { get; set; }
        public RicRollOutHistoryResponse Current { get; set; } = default!;
        public RicRollOutHistoryResponse? Previous { get; set; }
        public string Title { get; set; } = "RIC RollOut History Compare";
        public string BackUrl { get; set; } = "/RicRollOut/User";
    }
}
