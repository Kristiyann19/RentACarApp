using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentACarApp.Data.Configurations;
using RentACarApp.Data.Entities;

namespace RentACarApp.Data
{
    public class RentACarAppDbContext : IdentityDbContext<User>
    {
        private bool seedDb;

        public RentACarAppDbContext(DbContextOptions<RentACarAppDbContext> options, bool seed = true)
            : base(options)
        {
            if (Database.IsRelational())
            {
                Database.Migrate();
            }
            else
            {
                Database.EnsureCreated();
            }

            seedDb = seed;
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<TypeCar> Types { get; set; }

        public DbSet<Engine> Engines { get; set; }

        public DbSet<Agent> Agents { get; set; } 

        protected override void OnModelCreating(ModelBuilder builder)
        {

            builder
                .Entity<Car>()
                .HasOne(x => x.Agent)
                .WithMany()
                .HasForeignKey(x => x.AgentId)
                .OnDelete(DeleteBehavior.Restrict);
                

            builder
                .Entity<UserCars>()
                .HasKey(x => new { x.UserId, x.CarId });


            builder
                .Entity<User>()
                .Property(u => u.UserName)
                .HasMaxLength(30)
                .IsRequired();

            builder
                .Entity<User>()
                .Property(u => u.Email)
                .HasMaxLength(70)
                .IsRequired();

            if (seedDb)
            {
                builder.ApplyConfiguration(new TypeCarConfiguration());
                builder.ApplyConfiguration(new EngineConfiguration());
                builder.ApplyConfiguration(new CarConfiguration());
                builder.ApplyConfiguration(new AgentConfiguration());
                builder.ApplyConfiguration(new UserConfiguration());
            }
            


            base.OnModelCreating(builder);
        }

    }
}