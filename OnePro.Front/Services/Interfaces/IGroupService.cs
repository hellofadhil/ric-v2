using Core.Contracts.Group.Requests;
using OnePro.Front.ViewModels.Group;

namespace OnePro.Front.Services.Interfaces
{
    public interface IGroupService
    {
        Task<GroupResponse?> GetMyGroupAsync(string token);
        Task<GroupCreateResponse?> CreateGroupAsync(string token, CreateGroupRequest request);
        Task<GroupResponse?> UpdateGroupAsync(string token, UpdateGroupRequest request);
        Task<GroupCreateResponse?> DeleteGroupAsync(string token);
        Task<bool> AddMemberAsync(string token, AddGroupMemberRequest request);
        Task<bool> UpdateRoleAsync(string token, Guid memberId, int role);
        Task<bool> DeleteMemberAsync(string token, Guid memberId);
    }
}
