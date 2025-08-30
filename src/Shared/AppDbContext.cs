using Microsoft.EntityFrameworkCore;

namespace Shared;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    // TODO: Add DbSets for Identity, Wallet, Catalog, etc.
    // public DbSet<User> Users { get; set; }
    // public DbSet<Wallet> Wallets { get; set; }
}