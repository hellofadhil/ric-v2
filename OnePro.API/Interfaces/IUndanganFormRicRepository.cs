using Core.Models.Entities;
using Core.Contracts.Ric.Responses;

namespace OnePro.API.Interfaces
{
    public interface IUndanganFormRicRepository
    {
        Task<List<UndanganFormRicResponse>> GetAllAsync();
        Task<UndanganFormRicResponse?> GetByIdAsync(Guid id);

        Task<bool> CreateAsync(UndanganFormRic model);
        Task<bool> UpdateAsync(UndanganFormRic model);
        Task<bool> DeleteAsync(Guid id);
    }
}
