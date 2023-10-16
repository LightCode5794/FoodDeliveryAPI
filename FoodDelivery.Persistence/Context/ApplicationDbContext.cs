using FoodDelivery.Domain.Common;
using FoodDelivery.Domain.Common.Interfaces;
using FoodDelivery.Domain.Entities;
using MediatR;
using Microsoft.EntityFrameworkCore;

using System.Reflection;

namespace FoodDelivery.Persistence.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        private readonly IDomainEventDispatcher _dispatcher;

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options,
          IDomainEventDispatcher dispatcher)
            : base(options)
        {
            _dispatcher = dispatcher;
        }

        public DbSet<User> User => Set<User>();
        public DbSet<Permission> Permission => Set<Permission>();
        public DbSet<Role> Role => Set<Role>();
        public DbSet<FoodStore> Food_Store => Set<FoodStore>();
        public DbSet<Food> Food => Set<Food>();
        //public DbSet<FoodImage> Food_Image => Set<FoodImage>();
        public DbSet<Coupon> Coupon => Set<Coupon>();
        public DbSet<FoodReview> Food_Review => Set<FoodReview>();
        //public DbSet<ReviewImage> Review_Image => Set<ReviewImage>();
        public DbSet<Oder> Oder  => Set<Oder>();
        public DbSet<OderDetail> Oder_Detail => Set<OderDetail>();
        public DbSet<Notification> Notification => Set<Notification>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            // Indirect many-to-many setup for User review food
            modelBuilder.Entity<FoodReview>()
        .   HasKey(x => new { x.UserId, x.FoodId });

            // Indirect many-to-many setup for Oder and Food
            modelBuilder.Entity<OderDetail>()
            .HasKey(x => new { x.OderId, x.FoodId });
          
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            int result = await base.SaveChangesAsync(cancellationToken).ConfigureAwait(false);

            // ignore events if no dispatcher provided
            if (_dispatcher == null) return result;

            // dispatch events only if save was successful
            var entitiesWithEvents = ChangeTracker.Entries<BaseEntity>()
                .Select(e => e.Entity)
                .Where(e => e.DomainEvents.Any())
                .ToArray();

            await _dispatcher.DispatchAndClearEvents(entitiesWithEvents);

            return result;
        }

        public override int SaveChanges()
        {
            return SaveChangesAsync().GetAwaiter().GetResult();
        }
    }
}
