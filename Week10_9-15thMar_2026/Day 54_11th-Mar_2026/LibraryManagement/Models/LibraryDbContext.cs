using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace LibraryManagement.Models;

public partial class LibraryDbContext : DbContext
{
    public LibraryDbContext()
    {
    }

    public LibraryDbContext(DbContextOptions<LibraryDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Author> Authors { get; set; }
    public virtual DbSet<Book> Books { get; set; }
    public virtual DbSet<BookBorrower> BookBorrowers { get; set; }
    public virtual DbSet<Borrower> Borrowers { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // ---------------- AUTHORS ----------------
        modelBuilder.Entity<Author>(entity =>
        {
            entity.HasKey(e => e.AuthorId);

            entity.Property(e => e.Name)
                .HasMaxLength(100);

            entity.Property(e => e.Country)
                .HasMaxLength(100);
        });

        // ---------------- BOOKS ----------------
        modelBuilder.Entity<Book>(entity =>
        {
            entity.HasKey(e => e.BookId);

            entity.Property(e => e.Title)
                .HasMaxLength(200);

            entity.Property(e => e.Isbn)
                .HasMaxLength(50)
                .HasColumnName("ISBN");

            entity.HasOne(d => d.Author)
                .WithMany(p => p.Books)
                .HasForeignKey(d => d.AuthorId);
        });

        // ---------------- BOOK BORROWER ----------------
        modelBuilder.Entity<BookBorrower>(entity =>
        {
            // Composite Primary Key
            entity.HasKey(e => new { e.BookId, e.BorrowerId });

            entity.Property(e => e.BorrowDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Book)
                .WithMany(p => p.BookBorrowers)
                .HasForeignKey(d => d.BookId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Borrower)
                .WithMany(p => p.BookBorrowers)
                .HasForeignKey(d => d.BorrowerId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        // ---------------- BORROWERS ----------------
        modelBuilder.Entity<Borrower>(entity =>
        {
            entity.HasKey(e => e.BorrowerId);

            entity.Property(e => e.FullName)
                .HasMaxLength(100);

            entity.Property(e => e.Email)
                .HasMaxLength(100);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}