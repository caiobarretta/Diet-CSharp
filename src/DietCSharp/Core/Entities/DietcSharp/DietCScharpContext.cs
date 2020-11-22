using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace Core.Entities.DietcSharp
{
    public partial class DietCScharpContext : DbContext
    {
        public DietCScharpContext()
        {
        }

        public DietCScharpContext(DbContextOptions<DietCScharpContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dietum> Dieta { get; set; }
        public virtual DbSet<Perfil> Perfils { get; set; }
        public virtual DbSet<PorcaoDeAlimento> PorcaoDeAlimentos { get; set; }
        public virtual DbSet<Refeico> Refeicoes { get; set; }
        public virtual DbSet<Rel_Porc_Dietum> Rel_Porc_Dieta { get; set; }
        public virtual DbSet<Rel_Ref_Porc> Rel_Ref_Porcs { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-ICV15QV;Database=DietCScharp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Dietum>(entity =>
            {
                entity.HasKey(e => e.ID_Dieta);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.HasKey(e => e.ID_Perfil);

                entity.ToTable("Perfil");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PorcaoDeAlimento>(entity =>
            {
                entity.HasKey(e => e.ID_PorcAlimento);

                entity.ToTable("PorcaoDeAlimento");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Refeico>(entity =>
            {
                entity.HasKey(e => e.ID_Refeicao);

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rel_Porc_Dietum>(entity =>
            {
                entity.HasNoKey();

                entity.HasOne(d => d.ID_DietaNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ID_Dieta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rel_Porc_Dieta_Dieta");

                entity.HasOne(d => d.ID_PorcAlimentoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ID_PorcAlimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rel_Porc_Dieta_PorcaoDeAlimento");
            });

            modelBuilder.Entity<Rel_Ref_Porc>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Rel_Ref_Porc");

                entity.HasOne(d => d.ID_PorcAlimentoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ID_PorcAlimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rel_Ref_Porc_PorcaoDeAlimento");

                entity.HasOne(d => d.ID_RefeicaoNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.ID_Refeicao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rel_Ref_Porc_Refeicoes");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.ID_Usuario);

                entity.ToTable("Usuario");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Senha)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario1)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("Usuario");

                entity.HasOne(d => d.ID_DietaNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.ID_Dieta)
                    .HasConstraintName("FK_Usuario_Dieta");

                entity.HasOne(d => d.ID_PerfilNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.ID_Perfil)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Usuario_Perfil");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
