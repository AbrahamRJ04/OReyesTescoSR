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
        public virtual DbSet<DatosPersonalesResidencia> DatosPersonalesResidencias { get; set; } = null!;
        public virtual DbSet<EmpresaResidencia> EmpresaResidencias { get; set; } = null!;
        public virtual DbSet<GiroEmpresa> GiroEmpresas { get; set; } = null!;
        public virtual DbSet<ModalidadResidencia> ModalidadResidencias { get; set; } = null!;
        public virtual DbSet<Programa> Programas { get; set; } = null!;
        public virtual DbSet<Proyecto> Proyectos { get; set; } = null!;
        public virtual DbSet<ProyectoResindencia> ProyectoResindencias { get; set; } = null!;
        public virtual DbSet<Sector> Sectors { get; set; } = null!;
        public virtual DbSet<ServicioSocial> ServicioSocials { get; set; } = null!;
        public virtual DbSet<TipoDependencium> TipoDependencia { get; set; } = null!;
        public virtual DbSet<TipoEmpresa> TipoEmpresas { get; set; } = null!;
        public virtual DbSet<TipoServicio> TipoServicios { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-AVT6ORL\\SQLEXPRESS ;Database=AReyesTescoServicio;Trusted_Connection=True;");
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

            modelBuilder.Entity<DatosPersonalesResidencia>(entity =>
            {
                entity.HasKey(e => e.IdCandidato)
                    .HasName("PK__DatosPer__D5598905CCD5C30B");

                entity.Property(e => e.Calle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConstanciaTerminoServicioSocial)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Especialidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Matricula)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCarreraNavigation)
                    .WithMany(p => p.DatosPersonalesResidencia)
                    .HasForeignKey(d => d.IdCarrera)
                    .HasConstraintName("FK__DatosPers__IdCar__7A672E12");
            });

            modelBuilder.Entity<EmpresaResidencia>(entity =>
            {
                entity.HasKey(e => e.IdEmpresaResidencias)
                    .HasName("PK__EmpresaR__C7E57D2C4360B2F1");

                entity.Property(e => e.Calle)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cargo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Extencion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NoExt)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NoInt)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NombreDeEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreTitular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaginaWeb)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RedSocial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdGiroNavigation)
                    .WithMany(p => p.EmpresaResidencia)
                    .HasForeignKey(d => d.IdGiro)
                    .HasConstraintName("FK__EmpresaRe__IdGir__76969D2E");

                entity.HasOne(d => d.IdSectorNavigation)
                    .WithMany(p => p.EmpresaResidencia)
                    .HasForeignKey(d => d.IdSector)
                    .HasConstraintName("FK__EmpresaRe__IdSec__778AC167");

                entity.HasOne(d => d.IdTipoEmpresaNavigation)
                    .WithMany(p => p.EmpresaResidencia)
                    .HasForeignKey(d => d.IdTipoEmpresa)
                    .HasConstraintName("FK__EmpresaRe__IdTip__75A278F5");
            });

            modelBuilder.Entity<GiroEmpresa>(entity =>
            {
                entity.HasKey(e => e.IdGiro)
                    .HasName("PK__GiroEmpr__98AAAF2CF6202B8D");

                entity.ToTable("GiroEmpresa");

                entity.Property(e => e.Giro)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModalidadResidencia>(entity =>
            {
                entity.HasKey(e => e.IdModalidadResidencias)
                    .HasName("PK__Modalida__B71133F73F1CDC4A");

                entity.Property(e => e.Modalidad)
                    .HasMaxLength(10)
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

            modelBuilder.Entity<Proyecto>(entity =>
            {
                entity.HasKey(e => e.IdProyecto)
                    .HasName("PK__Proyecto__F4888673B9AD2F9F");

                entity.ToTable("Proyecto");

                entity.Property(e => e.MatriculaIntegranteDos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MatriculaIntegranteUno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAsesorDependencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAsesorTesco)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreIntegranteDos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreIntegranteUno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProyecto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.IdCandidatoNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdCandidato)
                    .HasConstraintName("FK__Proyecto__IdCand__00200768");

                entity.HasOne(d => d.IdEmpresaResidenciasNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdEmpresaResidencias)
                    .HasConstraintName("FK__Proyecto__IdEmpr__01142BA1");

                entity.HasOne(d => d.IdModalidadResidenciasNavigation)
                    .WithMany(p => p.Proyectos)
                    .HasForeignKey(d => d.IdModalidadResidencias)
                    .HasConstraintName("FK__Proyecto__IdModa__7F2BE32F");
            });

            modelBuilder.Entity<ProyectoResindencia>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProyectoResindencias");

                entity.Property(e => e.Calle)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CalleEmpresa)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Cargo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CarreraDeAlumno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostal)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.CodigoPostalEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Colonia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ColoniaEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ConstanciaTerminoServicioSocial)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.CorreoDelTitular)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CorreoElectronico)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Especialidad)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EstadoEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Extencion)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Giro)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Matricula)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MatriculaIntegranteDos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MatriculaIntegranteUno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Modalidad)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MunicipioEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAsesorDependencia)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreAsesorTesco)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreCompleto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreDeEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreIntegranteDos)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreIntegranteUno)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NombreProyecto)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroExtEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NumeroIntEmpresa)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaginaWeb)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.RedSocial)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Sector)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Sexo)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Telefono)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TelefonoDeTitular)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TipoEmpresa)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TitularEmpresa)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sector>(entity =>
            {
                entity.HasKey(e => e.IdSector)
                    .HasName("PK__Sector__D0011C18ABCD6B25");

                entity.ToTable("Sector");

                entity.Property(e => e.Sector1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("Sector");
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

            modelBuilder.Entity<TipoEmpresa>(entity =>
            {
                entity.HasKey(e => e.IdTipoEmpresa)
                    .HasName("PK__TipoEmpr__1ECA987F5B00F48E");

                entity.ToTable("TipoEmpresa");

                entity.Property(e => e.TipoEmpresa1)
                    .HasMaxLength(25)
                    .IsUnicode(false)
                    .HasColumnName("TipoEmpresa");
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
