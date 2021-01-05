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

        public virtual DbSet<DiasdaSemana> DiasdaSemanas { get; set; }
        public virtual DbSet<Dietum> Dieta { get; set; }
        public virtual DbSet<Perfil> Perfils { get; set; }
        public virtual DbSet<PorcaoDeAlimento> PorcaoDeAlimentos { get; set; }
        public virtual DbSet<Refeico> Refeicoes { get; set; }
        public virtual DbSet<Rel_Porc_Dietum> Rel_Porc_Dieta { get; set; }
        public virtual DbSet<Rel_Porc_Dium> Rel_Porc_Dia { get; set; }
        public virtual DbSet<Rel_Ref_Porc> Rel_Ref_Porcs { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=DESKTOP-UBOE2EP\\SQLEXPRESS;Database=DietCScharp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiasdaSemana>(entity =>
            {
                entity.ToTable("DiasdaSemana");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dietum>(entity =>
            {
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
                entity.HasOne(d => d.ID_DietaNavigation)
                    .WithMany(p => p.Rel_Porc_Dieta)
                    .HasForeignKey(d => d.ID_Dieta)
                    .HasConstraintName("FK_Rel_Porc_Dieta_Dieta");

                entity.HasOne(d => d.ID_PorcAlimentoNavigation)
                    .WithMany(p => p.Rel_Porc_Dieta)
                    .HasForeignKey(d => d.ID_PorcAlimento)
                    .HasConstraintName("FK_Rel_Porc_Dieta_PorcaoDeAlimento");
            });

            modelBuilder.Entity<Rel_Porc_Dium>(entity =>
            {
                entity.HasOne(d => d.ID_DiaSemanaNavigation)
                    .WithMany(p => p.Rel_Porc_Dia)
                    .HasForeignKey(d => d.ID_DiaSemana)
                    .HasConstraintName("FK_Rel_Porc_Dia_DiasdaSemana");

                entity.HasOne(d => d.ID_PorcAlimentoNavigation)
                    .WithMany(p => p.Rel_Porc_Dia)
                    .HasForeignKey(d => d.ID_PorcAlimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rel_Porc_Dia_PorcaoDeAlimento");
            });

            modelBuilder.Entity<Rel_Ref_Porc>(entity =>
            {
                entity.ToTable("Rel_Ref_Porc");

                entity.HasOne(d => d.ID_PorcAlimentoNavigation)
                    .WithMany(p => p.Rel_Ref_Porcs)
                    .HasForeignKey(d => d.ID_PorcAlimento)
                    .HasConstraintName("FK_Rel_Ref_Porc_PorcaoDeAlimento");

                entity.HasOne(d => d.ID_RefeicaoNavigation)
                    .WithMany(p => p.Rel_Ref_Porcs)
                    .HasForeignKey(d => d.ID_Refeicao)
                    .HasConstraintName("FK_Rel_Ref_Porc_Refeicoes");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
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
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Usuario_Dieta");

                entity.HasOne(d => d.ID_PerfilNavigation)
                    .WithMany(p => p.Usuarios)
                    .HasForeignKey(d => d.ID_Perfil)
                    .HasConstraintName("FK_Usuario_Perfil");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
