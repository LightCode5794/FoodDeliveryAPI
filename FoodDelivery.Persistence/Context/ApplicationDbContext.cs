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

        public DbSet<UserEntity> User => Set<UserEntity>();
        public DbSet<PermissionEntity> Permission => Set<PermissionEntity>();
        public DbSet<RoleEntity> Role => Set<RoleEntity>();
        public DbSet<FoodStoreEntity> Food_Store => Set<FoodStoreEntity>();
        public DbSet<FoodEntity> Food => Set<FoodEntity>();
        public DbSet<FoodImageEntity> Food_Image => Set<FoodImageEntity>();
        public DbSet<CouponEntity> Coupon => Set<CouponEntity>();
        public DbSet<FoodReviewEntity> Food_Review => Set<FoodReviewEntity>();
        public DbSet<ReviewImageEntity> Review_Image => Set<ReviewImageEntity>();
        public DbSet<OderEntity> Oder  => Set<OderEntity>();
        public DbSet<OderDetailEntity> Oder_Detail => Set<OderDetailEntity>();
        public DbSet<NotificationEntity> Notification => Set<NotificationEntity>();


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());


            // Indirect many-to-many setup for User review food
            modelBuilder.Entity<FoodReviewEntity>()
        .   HasKey(x => new { x.UserId, x.FoodId });

            // Indirect many-to-many setup for Oder and Food
            modelBuilder.Entity<OderDetailEntity>()
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
