using UserApi.Entities;

namespace UserApi.Service;

public interface IUserService
{
    Task<User> GetByIdAsync(Guid id);
    Task<List<User>> GetAllAsync(Func<User, bool> p = null);
    Task<(bool IsSuccess, Exception e)> InsertAsync(User user);
    Task<(bool IsSuccess, Exception e)> UpdateAsync(User user);
    Task<(bool IsSuccess, Exception e)> DeleteIdAsync(Guid id);
}