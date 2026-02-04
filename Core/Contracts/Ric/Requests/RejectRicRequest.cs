using System.ComponentModel.DataAnnotations;
using Core.Models.Enums;

namespace Core.Contracts.Ric.Requests
{
    public class RejectRicRequest
    {
        [Required]
        public string Catatan { get; set; } = default!;

        // [Required]
        // public RoleReview RoleReview { get; set; }
    }
}
