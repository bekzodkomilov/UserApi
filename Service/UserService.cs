using UserApi.Data;
using UserApi.Entities;

namespace UserApi.Service;

public class UserService : IUserService
{
    private readonly UserDbContext _context;
    private readonly Logger<UserService> _logger;

    public UserService (UserDbContext context, Logger<UserService> logger)
    {
        _context = context;
        _logger  = logger;
    }  
    public Task<(bool IsSuccess, Exception e)> DeleteIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<List<User>> GetAllAsync(Func<User, bool> p = null)
    {
        throw new NotImplementedException();
    }

    public Task<User> GetByIdAsync(Guid id)
    {
        throw new NotImplementedException();
    }
     public Task<(bool IsSuccess, Exception e)> UpdateAsync(User user)
    {
        throw new NotImplementedException();
    }

    public Task<(bool IsSuccess, Exception e)> InsertAsync(User user)
    {
        throw new NotImplementedException();
    }

}