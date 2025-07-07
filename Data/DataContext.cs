using Microsoft.EntityFrameworkCore;
using RTC.Models;

namespace RTC.Data
{
  public class DataContext : DbContext
  {
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    { }

    public DbSet<User> Users { get; set; }

  }
}