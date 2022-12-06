using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using RentACarApp.Data.Configurations;
using RentACarApp.Data.Entities;

namespace RentACarApp.Data
{
    public class RentACarAppDbContext : IdentityDbContext<User>
    {

        public RentACarAppDbContext(DbContextOptions<RentACarAppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Car> Cars { get; set; }

        public DbSet<TypeCar> Types { get; set; }

        public DbSet<Engine> Engines { get; set; }

        public DbSet<Agent> Agents { get; set; } 

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<UserCars>()
                .HasKey(x => new { x.UserId, x.CarId });


            builder.Entity<User>()
                .Property(u => u.UserName)
                .HasMaxLength(30)
                .IsRequired();

            builder.Entity<User>()
                .Property(u => u.Email)
                .HasMaxLength(70)
                .IsRequired();

            builder.ApplyConfiguration(new TypeCarConfiguration());
            builder.ApplyConfiguration(new EngineConfiguration());
            builder.ApplyConfiguration(new CarConfiguration());
            builder.ApplyConfiguration(new AgentConfiguration());
            builder.ApplyConfiguration(new UserConfiguration());


            base.OnModelCreating(builder);
        }

    }
}