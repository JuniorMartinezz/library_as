using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WebApi.Domain;

namespace WebApi.Data.Types
{
    public class BookMap : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.ToTable("books");

            builder.Property(i => i.Id).HasColumnName("id");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Isbn)
                .HasColumnName("isbn")
                .IsRequired()
                .HasColumnType("long(13)");

            builder.Property(i => i.ReleaseDate)
                .HasColumnName("release_date")
                .IsRequired()
                .HasColumnType("varchar(10)");

            builder.Property(i => i.Title)
                .HasColumnName("title")
                .IsRequired()
                .HasColumnType("varchar(200)");

            builder.HasMany(i =>i.Authors)
                .WithOne(a => a.Book);
        }
    }
}