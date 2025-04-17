using Microsoft.EntityFrameworkCore;
using SocialAssistanceFund.Models;
using System.Collections.Generic;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Applicant> Applicants { get; set; }
    public DbSet<Village> Villages { get; set; }
    public DbSet<SubLocation> SubLocations { get; set; }
    public DbSet<Location> Locations { get; set; }
    public DbSet<SubCounty> SubCounties { get; set; }
    public DbSet<County> Counties { get; set; }
    public DbSet<Sex> Sexes { get; set; }
    public DbSet<MaritalStatus> MaritalStatuses { get; set; }
    public DbSet<SocialProgram> SocialPrograms { get; set; }
    public DbSet<ApplicantProgram> ApplicantPrograms { get; set; }
    public DbSet<Officer> Officers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<SocialProgram>()
       .HasKey(sp => sp.ProgramId);
        // Fluent API setup here (relationships, constraints, seeding, etc.)
    }
}
