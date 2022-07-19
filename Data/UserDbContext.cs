using Microsoft.EntityFrameworkCore;
using UserApi.Entities;

namespace UserApi.Data;

public class UserDbContext : DbContext
{
    public DbSet<User> Users { get; set; }
    public UserDbContext(DbContextOptions<UserDbContext> options)
        :base(options) { }
}