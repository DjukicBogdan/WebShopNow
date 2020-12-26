using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Newtonsoft.Json;

namespace WebShopClient.Models
{
    public partial class WebshopdbContext : DbContext
    {
        public WebshopdbContext()
        {
        }

        public WebshopdbContext(DbContextOptions<WebshopdbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Porucbenica> Porucbenicas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<Porucbenica>(entity =>
            {
                entity.HasKey(e => e.OsobaId)
                    .HasName("PK__Porucben__BD4904F59B36515A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}