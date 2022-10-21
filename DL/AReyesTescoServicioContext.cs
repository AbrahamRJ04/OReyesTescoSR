using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DL
{
    public partial class AReyesTescoServicioContext : DbContext
    {
        public AReyesTescoServicioContext()
        {
        }

        public AReyesTescoServicioContext(DbContextOptions<AReyesTescoServicioContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Alumno> Alumnos { get; set; } = null!;
        public virtual DbSet<Carrera> Carreras { get; set; } = null!;
        public virtual DbSet<Programa> Programas { get; set; } = null!;
        public virtual DbSet<ServicioSocial> ServicioSocials { get; set; } = null!;
        public virtual DbSet<TipoDependencium> TipoDependencia { get; set; } = null!;
        public virtual DbSet<TipoServicio> TipoServicios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-AVT6ORL\\SQLEXPRESS;Initial Catalog=AReyesTescoServicio;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(entity =>
            {
                entity.HasKey(e => e.IdAlumno)
                    .HasName("PK__Alumno__460B4740B5439425");

                entity.ToTable("Alumno");

                entity.Property(e => e.ApellidoMaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ApellidoPaterno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoInstitucional)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroCreditos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Promedio).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.Sexo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.VidaAcademica)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCarreraNavigation)
                    .WithMany(p => p.Alumnos)
                    .HasForeignKey(d => d.IdCarrera)
                    .HasConstraintName("FK__Alumno__IdCarrer__38996AB5");

                entity.HasOne(d => d.IdServicioSocialNavigation)
                    .WithMany(p => p.Alumnos)
                    .HasForeignKey(d => d.IdServicioSocial)
                    .HasConstraintName("FK__Alumno__IdServic__440B1D61");
            });

            modelBuilder.Entity<Carrera>(entity =>
            {
                entity.HasKey(e => e.IdCarrera)
                    .HasName("PK__Carreras__884A8F1F971AFDD9");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Programa>(entity =>
            {
                entity.HasKey(e => e.IdPrograma)
                    .HasName("PK__Programa__AF94ECA525656088");

                entity.ToTable("Programa");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServicioSocial>(entity =>
            {
                entity.HasKey(e => e.IdServicioSocial)
                    .HasName("PK__Servicio__507A7B0E8008C652");

                entity.ToTable("ServicioSocial");

                entity.Property(e => e.Actividades)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CargoResponsable)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Domicilio)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaInicio).HasColumnType("date");

                entity.Property(e => e.FechaTermino).HasColumnType("date");

                entity.Property(e => e.Municipio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreDepartamento)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreDependencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ResponsableNombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Turno)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdProgramaNavigation)
                    .WithMany(p => p.ServicioSocials)
                    .HasForeignKey(d => d.IdPrograma)
                    .HasConstraintName("FK__ServicioS__IdPro__4222D4EF");

                entity.HasOne(d => d.IdTipoDependenciaNavigation)
                    .WithMany(p => p.ServicioSocials)
                    .HasForeignKey(d => d.IdTipoDependencia)
                    .HasConstraintName("FK__ServicioS__IdTip__412EB0B6");

                entity.HasOne(d => d.IdTipoServicioNavigation)
                    .WithMany(p => p.ServicioSocials)
                    .HasForeignKey(d => d.IdTipoServicio)
                    .HasConstraintName("FK__ServicioS__IdTip__4316F928");
            });

            modelBuilder.Entity<TipoDependencium>(entity =>
            {
                entity.HasKey(e => e.IdTipoDependencia)
                    .HasName("PK__TipoDepe__15DD82E82DCCECCB");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TipoServicio>(entity =>
            {
                entity.HasKey(e => e.IdTipoServicio)
                    .HasName("PK__TipoServ__E29B3EA7CE6AFD14");

                entity.ToTable("TipoServicio");

                entity.Property(e => e.Nombre)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
