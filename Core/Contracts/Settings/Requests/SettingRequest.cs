using Core.Models.Entities;

namespace Core.Contracts.Settings.Requests
{
    public class SettingRequest : Setting
    {
        public string Type { get; set; } = default!;
    }
}
