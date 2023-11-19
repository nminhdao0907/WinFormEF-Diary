using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace NhatKi2023.Models
{
    public partial class Nhatki2023Context : DbContext
    {
        public Nhatki2023Context()
        {
        }

        public Nhatki2023Context(DbContextOptions<Nhatki2023Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Comment> Comments { get; set; } = null!;
        public virtual DbSet<Entry> Entries { get; set; } = null!;
        public virtual DbSet<Tag> Tags { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                              .SetBasePath(Directory.GetCurrentDirectory())
                              .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            IConfigurationRoot configuration = builder.Build();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("MyCnn"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>(entity =>
            {
                entity.Property(e => e.CommentId).HasColumnName("CommentID");

                entity.Property(e => e.CommentDate).HasColumnType("datetime");

                entity.Property(e => e.CommentText).HasColumnType("text");

                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Entry)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.EntryId)
                    .HasConstraintName("FK__Comments__EntryI__5070F446");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Comments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Comments__UserID__5165187F");
            });

            modelBuilder.Entity<Entry>(entity =>
            {
                entity.Property(e => e.EntryId).HasColumnName("EntryID");

                entity.Property(e => e.Content).HasColumnType("text");

                entity.Property(e => e.EntryDate).HasColumnType("datetime");

                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Tag)
                    .WithMany(p => p.Entries)
                    .HasForeignKey(d => d.TagId)
                    .HasConstraintName("FK__Entries__TagID__4D94879B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Entries)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Entries__UserID__4CA06362");
            });

            modelBuilder.Entity<Tag>(entity =>
            {
                entity.Property(e => e.TagId).HasColumnName("TagID");

                entity.Property(e => e.TagName)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.Username, "UQ__Users__536C85E4A158B179")
                    .IsUnique();

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.ConPassword)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("conPassword");

                entity.Property(e => e.Password)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Username)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
