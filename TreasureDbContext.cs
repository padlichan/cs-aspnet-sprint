using ASPNET;
using System.Text.Json;
using Microsoft.EntityFrameworkCore;

public class TreasureDbContext : DbContext
{
    public DbSet<Rule> Rules { get; set; }
    public DbSet<Shop> Shops { get; set; }
    public DbSet<Treasure> Treasures { get; set; }
    public DbSet<About> About { get; set; }

    public TreasureDbContext(DbContextOptions<TreasureDbContext> options)
   : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        var rulesData = JsonSerializer.Deserialize<List<Rule>>(File.ReadAllText("Resources/Rules.json"));
        modelBuilder.Entity<Rule>().HasData(rulesData);
        List<Treasure> treasureData = JsonSerializer.Deserialize<List<Treasure>>(File.ReadAllText("Resources/Treasures.json"));
        modelBuilder.Entity<Treasure>().HasData(treasureData);
        var shopData = JsonSerializer.Deserialize<List<Shop>>(File.ReadAllText("Resources/Shops.json"));
        modelBuilder.Entity<Shop>().HasData(shopData);
        var aboutData = JsonSerializer.Deserialize<About>(File.ReadAllText("Resources/About.json"));
        modelBuilder.Entity<About>().HasData(aboutData);
    }
}