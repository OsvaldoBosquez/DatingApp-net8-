using API.Entities;
using Microsoft.EntityFrameworkCore;

namespace API.Data;

public class DataContext(DbContextOptions options) : DbContext(options)
{
    //Users is going to be the name of the table
    //AppUser is the class that has the parameters to be inserted in the Table users
    public DbSet<AppUsers> Users { get; set; }
}
