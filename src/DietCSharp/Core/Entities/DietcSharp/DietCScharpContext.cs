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

        public virtual DbSet<DiaDaSemana> DiaDaSemanas { get; set; }
        public virtual DbSet<Dietum> Dieta { get; set; }
        public virtual DbSet<Perfil> Perfils { get; set; }
        public virtual DbSet<PorcaoDeAlimento> PorcaoDeAlimentos { get; set; }
        public virtual DbSet<PorcaoDeAlimentoDiasdaSemana> PorcaoDeAlimentoDiasdaSemanas { get; set; }
        public virtual DbSet<PorcaoDeAlimentoDietum> PorcaoDeAlimentoDieta { get; set; }
        public virtual DbSet<PorcaoDeAlimentoRegistroDeAtividade> PorcaoDeAlimentoRegistroDeAtividades { get; set; }
        public virtual DbSet<Refeicao> Refeicaos { get; set; }
        public virtual DbSet<RefeicaoPorcaoDeAlimento> RefeicaoPorcaoDeAlimentos { get; set; }
        public virtual DbSet<RegistroDeAtividade> RegistroDeAtividades { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost;Database=DietCScharp;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DiaDaSemana>(entity =>
            {
                entity.ToTable("DiaDaSemana");

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

            modelBuilder.Entity<PorcaoDeAlimentoDiasdaSemana>(entity =>
            {
                entity.ToTable("PorcaoDeAlimentoDiasdaSemana");

                entity.HasOne(d => d.ID_DiaSemanaNavigation)
                    .WithMany(p => p.PorcaoDeAlimentoDiasdaSemanas)
                    .HasForeignKey(d => d.ID_DiaSemana)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rel_Porc_Dia_DiasdaSemana");

                entity.HasOne(d => d.ID_PorcaoAlimentoNavigation)
                    .WithMany(p => p.PorcaoDeAlimentoDiasdaSemanas)
                    .HasForeignKey(d => d.ID_PorcaoAlimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rel_Porc_Dia_PorcaoDeAlimento");
            });

            modelBuilder.Entity<PorcaoDeAlimentoDietum>(entity =>
            {
                entity.HasOne(d => d.ID_DietaNavigation)
                    .WithMany(p => p.PorcaoDeAlimentoDieta)
                    .HasForeignKey(d => d.ID_Dieta)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rel_Porc_Dieta_Dieta");

                entity.HasOne(d => d.ID_PorcAlimentoNavigation)
                    .WithMany(p => p.PorcaoDeAlimentoDieta)
                    .HasForeignKey(d => d.ID_PorcAlimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rel_Porc_Dieta_PorcaoDeAlimento");
            });

            modelBuilder.Entity<PorcaoDeAlimentoRegistroDeAtividade>(entity =>
            {
                entity.ToTable("PorcaoDeAlimentoRegistroDeAtividade");

                entity.HasOne(d => d.ID_PorcAlimentoNavigation)
                    .WithMany(p => p.PorcaoDeAlimentoRegistroDeAtividades)
                    .HasForeignKey(d => d.ID_PorcAlimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rel_Porc_RegistroDeAtividade_PorcaoDeAlimento");

                entity.HasOne(d => d.ID_RegistroDeAtividadeNavigation)
                    .WithMany(p => p.PorcaoDeAlimentoRegistroDeAtividades)
                    .HasForeignKey(d => d.ID_RegistroDeAtividade)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PorcaoDeAlimentoRegistroDeAtividade_PorcaoDeAlimentoRegistroDeAtividade");
            });

            modelBuilder.Entity<Refeicao>(entity =>
            {
                entity.ToTable("Refeicao");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RefeicaoPorcaoDeAlimento>(entity =>
            {
                entity.ToTable("RefeicaoPorcaoDeAlimento");

                entity.HasOne(d => d.ID_PorcAlimentoNavigation)
                    .WithMany(p => p.RefeicaoPorcaoDeAlimentos)
                    .HasForeignKey(d => d.ID_PorcAlimento)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rel_Ref_Porc_PorcaoDeAlimento");

                entity.HasOne(d => d.ID_RefeicaoNavigation)
                    .WithMany(p => p.RefeicaoPorcaoDeAlimentos)
                    .HasForeignKey(d => d.ID_Refeicao)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rel_Ref_Porc_Refeicoes");
            });

            modelBuilder.Entity<RegistroDeAtividade>(entity =>
            {
                entity.ToTable("RegistroDeAtividade");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nome)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Registro).HasColumnType("datetime");

                entity.Property(e => e.Sentimento)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
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
