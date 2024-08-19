using Microsoft.EntityFrameworkCore;

namespace Psyche.Models;

public partial class DBContext : DbContext
{
    public DBContext(DbContextOptions<DBContext> options)
        : base(options)
    {
    }

    public DBContext() : base() { }

    public virtual DbSet<Sr45> Sr45s { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Sr45>(entity =>
        {
            entity.ToTable("SR45");

            entity.HasIndex(e => e.Id, "IX_SR45_ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.EndTime).IsRequired();
            entity.Property(e => e.Question1).IsRequired();
            entity.Property(e => e.Question10).IsRequired();
            entity.Property(e => e.Question11).IsRequired();
            entity.Property(e => e.Question12).IsRequired();
            entity.Property(e => e.Question13).IsRequired();
            entity.Property(e => e.Question14).IsRequired();
            entity.Property(e => e.Question15).IsRequired();
            entity.Property(e => e.Question16).IsRequired();
            entity.Property(e => e.Question17).IsRequired();
            entity.Property(e => e.Question18).IsRequired();
            entity.Property(e => e.Question19).IsRequired();
            entity.Property(e => e.Question2).IsRequired();
            entity.Property(e => e.Question20).IsRequired();
            entity.Property(e => e.Question21).IsRequired();
            entity.Property(e => e.Question22).IsRequired();
            entity.Property(e => e.Question23).IsRequired();
            entity.Property(e => e.Question24).IsRequired();
            entity.Property(e => e.Question25).IsRequired();
            entity.Property(e => e.Question26).IsRequired();
            entity.Property(e => e.Question27).IsRequired();
            entity.Property(e => e.Question28).IsRequired();
            entity.Property(e => e.Question29).IsRequired();
            entity.Property(e => e.Question3).IsRequired();
            entity.Property(e => e.Question30).IsRequired();
            entity.Property(e => e.Question31).IsRequired();
            entity.Property(e => e.Question32).IsRequired();
            entity.Property(e => e.Question33).IsRequired();
            entity.Property(e => e.Question34).IsRequired();
            entity.Property(e => e.Question35).IsRequired();
            entity.Property(e => e.Question36).IsRequired();
            entity.Property(e => e.Question37).IsRequired();
            entity.Property(e => e.Question38).IsRequired();
            entity.Property(e => e.Question39).IsRequired();
            entity.Property(e => e.Question4).IsRequired();
            entity.Property(e => e.Question40).IsRequired();
            entity.Property(e => e.Question41).IsRequired();
            entity.Property(e => e.Question42).IsRequired();
            entity.Property(e => e.Question43).IsRequired();
            entity.Property(e => e.Question44).IsRequired();
            entity.Property(e => e.Question45).IsRequired();
            entity.Property(e => e.Question5).IsRequired();
            entity.Property(e => e.Question6).IsRequired();
            entity.Property(e => e.Question7).IsRequired();
            entity.Property(e => e.Question8).IsRequired();
            entity.Property(e => e.Question9).IsRequired();
            entity.Property(e => e.StartTime).IsRequired();
            entity.Property(e => e.UserName).IsRequired();
            entity.Property(e => e.UserPlatoon).IsRequired();
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.Id, "IX_Users_ID").IsUnique();

            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.Name).IsRequired();
            entity.Property(e => e.Platoon).IsRequired();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite("Data Source=Psyche.db");
    }
}