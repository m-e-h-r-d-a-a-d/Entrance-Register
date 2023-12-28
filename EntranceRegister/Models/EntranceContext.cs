using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace EntranceRegister.Models;

public partial class EntranceContext : DbContext
{

    public EntranceContext()
    {
    }

    public EntranceContext(DbContextOptions<EntranceContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Blacklist> Blacklists { get; set; }

    public virtual DbSet<Gate> Gates { get; set; }

    public virtual DbSet<Host> Hosts { get; set; }

    public virtual DbSet<Person> People { get; set; }

    public virtual DbSet<Presence> Presences { get; set; }

    public virtual DbSet<User> Users { get; set; }

    // protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    // {
    //     // Configure your database connection using the provided connection string
    //     optionsBuilder.UseSqlServer(_connectionString);
    // }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Blacklist>(entity =>
        {
            entity.HasKey(e => e.PersonId).HasName("PK__Blacklis__AA2FFBE51DE57479");

            entity.ToTable("Blacklist");

            entity.Property(e => e.PersonId).ValueGeneratedNever();
            entity.Property(e => e.Note).HasColumnType("ntext");

            entity.HasOne(d => d.Person).WithOne(p => p.Blacklist)
                .HasForeignKey<Blacklist>(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Blacklist_Person");
        });

        modelBuilder.Entity<Gate>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Gates__3214EC070425A276");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Host>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Hosts__3214EC0707F6335A");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Name).HasMaxLength(50);
        });

        modelBuilder.Entity<Person>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__People__3214EC070F975522");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Fullname).HasMaxLength(50);
            entity.Property(e => e.NationalNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<Presence>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Presence__3214EC071367E606");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Photo).HasColumnType("image");
            entity.Property(e => e.RegistrarUsername).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");

            entity.HasOne(d => d.Person).WithMany(p => p.Presences)
                .HasForeignKey(d => d.PersonId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Presence_Person");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.Username).HasName("PK__Users__536C85E50BC6C43E");

            entity.Property(e => e.Username).HasMaxLength(50);
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
