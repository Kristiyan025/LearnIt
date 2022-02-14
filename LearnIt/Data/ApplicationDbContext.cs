namespace LearnIt.Data
{
    using LearnIt.Models;
    using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore;

    public class ApplicationDbContext : IdentityDbContext<UserDataModel> /*DbContext*/
    {
        public ApplicationDbContext() 
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            //Database.EnsureDeleted();
            Database.EnsureCreated();
        }
        public DbSet<UserDataModel> Users { get; set; }

        public DbSet<CourseDataModel> Courses { get; set; }

        public DbSet<UsersCoursesDataModel> UsersCourses { get; set; }

        public DbSet<LectureDataModel> Lectures { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.Entity<CourseDataModel>()
                .HasKey(i => i.Id);
            builder.Entity<LectureDataModel>()
                .HasKey(i => i.Id);
            builder.Entity<UserDataModel>()
                .HasKey(i => i.Id);
            builder.Entity<UserDataModel>(b =>
            { // Each User can have many UserClaims
                b.HasMany(e => e.Claims)
                    .WithOne()
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();
            });
            builder.Entity<CourseDataModel>()
                .HasMany(x => x.Lectures)
                .WithOne(x => x.Course)
                .OnDelete(DeleteBehavior.NoAction)
                .IsRequired();

            builder.Entity<UsersCoursesDataModel>()
                .HasKey(x => new { x.UserId, x.CourseId });
        }
    }
}
