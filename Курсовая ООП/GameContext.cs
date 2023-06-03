using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace Курсовая_ООП;

public partial class GameContext : DbContext
{
    public GameContext()
    {
    }

    public GameContext(DbContextOptions<GameContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Game> Games { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost; Port = 5432; Database= Game; Username = postgres; Password= 1234");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Game>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("game_pkey");

            entity.ToTable("game");

            entity.Property(e => e.Id)
                .UseIdentityAlwaysColumn()
                .HasColumnName("id");
            entity.Property(e => e.Datatime)
                .HasDefaultValueSql("CURRENT_TIMESTAMP")
                .HasColumnType("timestamp without time zone")
                .HasColumnName("datatime");
            entity.Property(e => e.Level1try).HasColumnName("level1try");
            entity.Property(e => e.Level2try).HasColumnName("level2try");
            entity.Property(e => e.Level3try).HasColumnName("level3try");
            entity.Property(e => e.True1).HasColumnName("true1");
            entity.Property(e => e.True2).HasColumnName("true2");
            entity.Property(e => e.True3).HasColumnName("true3");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
