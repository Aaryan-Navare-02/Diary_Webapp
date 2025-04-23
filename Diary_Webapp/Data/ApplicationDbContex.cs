using Diary_Webapp.Models;
using Microsoft.EntityFrameworkCore;

namespace Diary_Webapp.Data
{
    public class ApplicationDbContex:DbContext
    {

        public ApplicationDbContex(DbContextOptions<ApplicationDbContex> options) : base(options)
        {

        }

        public DbSet<DiaryEntry> DiaryEntry { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<DiaryEntry>().HasData(
                new DiaryEntry
                {
                    Id = 1,
                    Title = "First Entry",
                    Content = "This is my first diary entry.",
                    CreatedAt = new DateTime(2024, 1, 1)
                },
                new DiaryEntry
                {
                    Id = 2,
                    Title = "Second Entry",
                    Content = "This is my second diary entry.",
                    CreatedAt = new DateTime(2024, 1, 2)
                }
            );
        }
    }
}
