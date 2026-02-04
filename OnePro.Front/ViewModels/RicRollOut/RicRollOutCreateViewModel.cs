using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;
using Core.Contracts.RicRollOut.Responses;

namespace OnePro.Front.ViewModels.RicRollOut
{
    public class RicRollOutCreateViewModel
    {
        public Guid Id { get; set; }

        [Required]
        public string? Entitas { get; set; }

        [Required]
        public string? JudulAplikasi { get; set; }

        public List<string>? Hashtags { get; set; } = new();

        // upload baru
        public IEnumerable<IFormFile>? CompareWithAsIsHoldingProcessFiles { get; set; }
        public IEnumerable<IFormFile>? StkAsIsToBeFiles { get; set; }

        // existing urls (untuk edit/update)
        public List<string>? ExistingCompareWithAsIsHoldingProcessFileUrls { get; set; } = new();
        public List<string>? ExistingStkAsIsToBeFileUrls { get; set; } = new();

        // checklist
        public bool IsJoinedDomainAdPertamina { get; set; }
        public bool IsUsingErpPertamina { get; set; }
        public bool IsImplementedRequiredActivation { get; set; }
        public bool HasDataCenterConnection { get; set; }
        public bool HasRequiredResource { get; set; }

        // ===== EXTRA DISPLAY =====
        public List<RicRollOutReviewResponse> Reviews { get; set; } = new();
        public List<RicRollOutHistoryResponse> Histories { get; set; } = new();
    }
}
