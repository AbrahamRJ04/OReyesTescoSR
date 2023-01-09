CREATE TABLE DatosPersonalesResidencias
(
IdCandidato INT PRIMARY KEY IDENTITY(1,1),
NombreCompleto VARCHAR(50),
Sexo CHAR(2),
Telefono VARCHAR(25),
CorreoElectronico VARCHAR(50),
Calle VARCHAR(200),
NoExt INT,
NoInt INT,
Colonia VARCHAR(50),
Municipio VARCHAR(50),
Estado VARCHAR(50),
CodigoPostal VARCHAR(10),
IdCarrera INT REFERENCES Carreras(IdCarrera),
Especialidad VARCHAR(50),
Matricula VARCHAR(50),
VidaAcademica INT,
NoCreditos INT,
ConstanciaTerminoServicioSocial CHAR(2)
)

CREATE TABLE EmpresaResidencias
(
IdEmpresaResidencias INT PRIMARY KEY IDENTITY(1,1),
NombreDeEmpresa VARCHAR(50),
IdTipoEmpresa INT REFERENCES TipoEmpresa(IdTipoEmpresa),
IdGiro INT REFERENCES GiroEmpresa(IdGiro),
IdSector INT REFERENCES Sector(IdSector),
NombreTitular VARCHAR(50),
Cargo VARCHAR(50),
Telefono VARCHAR(50),
Extencion VARCHAR(10),
CorreoElectronico VARCHAR(100),
Calle VARCHAR(100),
NoExt VARCHAR(10),
NoInt VARCHAR(10),
Colonia VARCHAR(50),
Municipio VARCHAR(50),
Estado VARCHAR(50),
CodigoPostal VARCHAR(10),
PaginaWeb VARCHAR(50),
RedSocial VARCHAR(50)
)

CREATE TABLE TipoEmpresa
(
IdTipoEmpresa INT PRIMARY KEY IDENTITY(1,1),
TipoEmpresa VARCHAR(25)
)

CREATE TABLE GiroEmpresa
(
IdGiro INT PRIMARY KEY IDENTITY(1,1),
Giro VARCHAR(25)
)

CREATE TABLE Sector
(
IdSector INT PRIMARY KEY IDENTITY(1,1),
Sector VARCHAR(25)
)

CREATE TABLE Proyecto
(
IdProyecto INT PRIMARY KEY IDENTITY(1,1),
IdModalidad INT REFERENCES ModalidadResidencias(IdModalidadResidencias),
NombreIntegranteUno VARCHAR(50),
NombreIntegranteDos VARCHAR(50),
MatriculaIntegranteUno VARCHAR(50),
MatriculaIntegranteDos VARCHAR(50),
NombreProyecto VARCHAR(50),
NombreAsesorTesco VARCHAR(50),
NombreAsesorDependencia VARCHAR(50),
IdCandidato INT REFERENCES DatosPersonalesResidencias(IdCandidato),
IdEmpresaResidencias INT REFERENCES EmpresaResidencias(IdEmpresaResidencias)
)


CREATE TABLE ModalidadResidencias
(
IdModalidadResidencias INT PRIMARY KEY IDENTITY(1,1),
Modalidad VARCHAR(10)
)

---------------------------------------------------------------------------------------------------------------

--CREACION DE VIEW DE LAS TABLAS

USE [AReyesTescoServicio]
GO
CREATE VIEW ProyectoResindencias AS
SELECT Proyecto.[IdProyecto]
      ,Proyecto.IdModalidadResidencias
	  ,ModalidadResidencias.Modalidad
      ,Proyecto.[NombreIntegranteUno]
      ,Proyecto.[NombreIntegranteDos]
      ,Proyecto.[MatriculaIntegranteUno]
      ,Proyecto.[MatriculaIntegranteDos]
      ,Proyecto.[NombreProyecto]
      ,Proyecto.[NombreAsesorTesco]
      ,Proyecto.[NombreAsesorDependencia]
      ,Proyecto.[IdCandidato]
	  ,DatosPersonalesResidencias.[NombreCompleto]
      ,DatosPersonalesResidencias.[Sexo]
      ,DatosPersonalesResidencias.[Telefono]
      ,DatosPersonalesResidencias.[CorreoElectronico]
      ,DatosPersonalesResidencias.[Calle]
      ,DatosPersonalesResidencias.[NoExt]
      ,DatosPersonalesResidencias.[NoInt]
      ,DatosPersonalesResidencias.[Colonia]
      ,DatosPersonalesResidencias.[Municipio]
      ,DatosPersonalesResidencias.[Estado]
      ,DatosPersonalesResidencias.[CodigoPostal]
      ,DatosPersonalesResidencias.[IdCarrera]
	  ,Carreras.Nombre as CarreraDeAlumno
      ,DatosPersonalesResidencias.[Especialidad]
      ,DatosPersonalesResidencias.[Matricula]
      ,DatosPersonalesResidencias.[VidaAcademica]
      ,DatosPersonalesResidencias.[NoCreditos]
      ,DatosPersonalesResidencias.[ConstanciaTerminoServicioSocial]
      ,Proyecto.[IdEmpresaResidencias]
	  ,EmpresaResidencias.[NombreDeEmpresa]
      ,EmpresaResidencias.[IdTipoEmpresa]
	  ,TipoEmpresa.TipoEmpresa
      ,EmpresaResidencias.[IdGiro]
	  ,GiroEmpresa.Giro
      ,EmpresaResidencias.[IdSector]
	  ,Sector.Sector
      ,EmpresaResidencias.[NombreTitular] AS TitularEmpresa
      ,EmpresaResidencias.[Cargo]
      ,EmpresaResidencias.[Telefono] AS TelefonoDeTitular
      ,EmpresaResidencias.[Extencion]
      ,EmpresaResidencias.[CorreoElectronico] AS CorreoDelTitular
      ,EmpresaResidencias.[Calle] AS CalleEmpresa
      ,EmpresaResidencias.[NoExt] AS NumeroExtEmpresa
      ,EmpresaResidencias.[NoInt] AS NumeroIntEmpresa
      ,EmpresaResidencias.[Colonia] AS ColoniaEmpresa
      ,EmpresaResidencias.[Municipio] AS MunicipioEmpresa
      ,EmpresaResidencias.[Estado] AS EstadoEmpresa
      ,EmpresaResidencias.[CodigoPostal] AS CodigoPostalEmpresa
      ,EmpresaResidencias.[PaginaWeb]
      ,EmpresaResidencias.[RedSocial]
  FROM [dbo].[Proyecto]
  INNER JOIN ModalidadResidencias ON ModalidadResidencias.IdModalidadResidencias = Proyecto.IdModalidadResidencias
  INNER JOIN DatosPersonalesResidencias ON DatosPersonalesResidencias.IdCandidato = Proyecto.IdCandidato
  INNER JOIN Carreras ON Carreras.IdCarrera = DatosPersonalesResidencias.IdCarrera
  INNER JOIN EmpresaResidencias ON EmpresaResidencias.IdEmpresaResidencias = Proyecto.IdEmpresaResidencias
  INNER JOIN TipoEmpresa ON TipoEmpresa.IdTipoEmpresa = EmpresaResidencias.IdTipoEmpresa
  INNER JOIN GiroEmpresa ON GiroEmpresa.IdGiro = EmpresaResidencias.IdGiro
  INNER JOIN Sector ON Sector.IdSector = EmpresaResidencias.IdSector
GO

--------------------------------------------------------------------------------------------------------------------

-- GETALL PROYECTO

USE [AReyesTescoServicio]
GO
CREATE PROCEDURE ProeyctoGetAll
AS
BEGIN
SELECT [IdProyecto]
      ,[IdModalidadResidencias]
      ,[Modalidad]
      ,[NombreIntegranteUno]
      ,[NombreIntegranteDos]
      ,[MatriculaIntegranteUno]
      ,[MatriculaIntegranteDos]
      ,[NombreProyecto]
      ,[NombreAsesorTesco]
      ,[NombreAsesorDependencia]
      ,[IdCandidato]
      ,[NombreCompleto]
      ,[Sexo]
      ,[Telefono]
      ,[CorreoElectronico]
      ,[Calle]
      ,[NoExt]
      ,[NoInt]
      ,[Colonia]
      ,[Municipio]
      ,[Estado]
      ,[CodigoPostal]
      ,[IdCarrera]
      ,[CarreraDeAlumno]
      ,[Especialidad]
      ,[Matricula]
      ,[VidaAcademica]
      ,[NoCreditos]
      ,[ConstanciaTerminoServicioSocial]
      ,[IdEmpresaResidencias]
      ,[NombreDeEmpresa]
      ,[IdTipoEmpresa]
      ,[TipoEmpresa]
      ,[IdGiro]
      ,[Giro]
      ,[IdSector]
      ,[Sector]
      ,[TitularEmpresa]
      ,[Cargo]
      ,[TelefonoDeTitular]
      ,[Extencion]
      ,[CorreoDelTitular]
      ,[CalleEmpresa]
      ,[NumeroExtEmpresa]
      ,[NumeroIntEmpresa]
      ,[ColoniaEmpresa]
      ,[MunicipioEmpresa]
      ,[EstadoEmpresa]
      ,[CodigoPostalEmpresa]
      ,[PaginaWeb]
      ,[RedSocial]
  FROM [dbo].[ProyectoResindencias]
END


--------------------------------------------------------------------------------------------------------------

--GET BY ID PROYECTO

USE [AReyesTescoServicio]
GO
CREATE PROCEDURE ProeyctoGetById
@IdProyecto INT
AS
BEGIN
SELECT [IdProyecto]
      ,[IdModalidadResidencias]
      ,[Modalidad]
      ,[NombreIntegranteUno]
      ,[NombreIntegranteDos]
      ,[MatriculaIntegranteUno]
      ,[MatriculaIntegranteDos]
      ,[NombreProyecto]
      ,[NombreAsesorTesco]
      ,[NombreAsesorDependencia]
      ,[IdCandidato]
      ,[NombreCompleto]
      ,[Sexo]
      ,[Telefono]
      ,[CorreoElectronico]
      ,[Calle]
      ,[NoExt]
      ,[NoInt]
      ,[Colonia]
      ,[Municipio]
      ,[Estado]
      ,[CodigoPostal]
      ,[IdCarrera]
      ,[CarreraDeAlumno]
      ,[Especialidad]
      ,[Matricula]
      ,[VidaAcademica]
      ,[NoCreditos]
      ,[ConstanciaTerminoServicioSocial]
      ,[IdEmpresaResidencias]
      ,[NombreDeEmpresa]
      ,[IdTipoEmpresa]
      ,[TipoEmpresa]
      ,[IdGiro]
      ,[Giro]
      ,[IdSector]
      ,[Sector]
      ,[TitularEmpresa]
      ,[Cargo]
      ,[TelefonoDeTitular]
      ,[Extencion]
      ,[CorreoDelTitular]
      ,[CalleEmpresa]
      ,[NumeroExtEmpresa]
      ,[NumeroIntEmpresa]
      ,[ColoniaEmpresa]
      ,[MunicipioEmpresa]
      ,[EstadoEmpresa]
      ,[CodigoPostalEmpresa]
      ,[PaginaWeb]
      ,[RedSocial]
  FROM [dbo].[ProyectoResindencias]
  WHERE IdProyecto = @IdProyecto
END

----------------------------------------------------------------------------------------------------------------
--GetAll catalogo Tipo Empresa
USE [AReyesTescoServicio]
GO
CREATE PROCEDURE TipoEmpresaGetAll
AS
BEGIN
SELECT [IdTipoEmpresa]
      ,[TipoEmpresa]
  FROM [dbo].[TipoEmpresa]
END


GO
-------------------------------------------------------------------------------------------------------------------------------

--Get All GiroEmpresa

USE [AReyesTescoServicio]
GO
CREATE PROCEDURE GiroEmpresaGetAll
AS
BEGIN
SELECT [IdGiro]
      ,[Giro]
  FROM [dbo].[GiroEmpresa]
  END
GO

------------------------------------------------------------------------------------------------------------------

--Sector GetAll

USE [AReyesTescoServicio]
GO
CREATE PROCEDURE SectorGetAll
AS
BEGIN
SELECT [IdSector]
      ,[Sector]
  FROM [dbo].[Sector]
  END
GO

-------------------------------------------------------------------------------------------------------------------

-- ModalidadResidencias GetAll

USE [AReyesTescoServicio]
GO
CREATE PROCEDURE ModalidadResidenciasGetAll
AS
BEGIN
SELECT [IdModalidadResidencias]
      ,[Modalidad]
  FROM [dbo].[ModalidadResidencias]
  END
GO


------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE ResidenciaGetAll
AS
BEGIN
SELECT Proyecto.[IdProyecto]
      ,Proyecto.IdModalidadResidencias
	  ,ModalidadResidencias.Modalidad
      ,Proyecto.[NombreIntegranteUno]
      ,Proyecto.[NombreIntegranteDos]
      ,Proyecto.[MatriculaIntegranteUno]
      ,Proyecto.[MatriculaIntegranteDos]
      ,Proyecto.[NombreProyecto]
      ,Proyecto.[NombreAsesorTesco]
      ,Proyecto.[NombreAsesorDependencia]
      ,Proyecto.[IdCandidato]
	  ,DatosPersonalesResidencias.[NombreCompleto]
      ,DatosPersonalesResidencias.[Sexo]
      ,DatosPersonalesResidencias.[Telefono]
      ,DatosPersonalesResidencias.[CorreoElectronico]
      ,DatosPersonalesResidencias.[Calle]
      ,DatosPersonalesResidencias.[NoExt]
      ,DatosPersonalesResidencias.[NoInt]
      ,DatosPersonalesResidencias.[Colonia]
      ,DatosPersonalesResidencias.[Municipio]
      ,DatosPersonalesResidencias.[Estado]
      ,DatosPersonalesResidencias.[CodigoPostal]
      ,DatosPersonalesResidencias.[IdCarrera] 
	  ,Carreras.Nombre as CarreraDeAlumno
      ,DatosPersonalesResidencias.[Especialidad]
      ,DatosPersonalesResidencias.[Matricula]
      ,DatosPersonalesResidencias.[VidaAcademica]
      ,DatosPersonalesResidencias.[NoCreditos]
      ,DatosPersonalesResidencias.[ConstanciaTerminoServicioSocial]
      ,Proyecto.[IdEmpresaResidencias]
	  ,EmpresaResidencias.[NombreDeEmpresa]
      ,EmpresaResidencias.[IdTipoEmpresa]
	  ,TipoEmpresa.TipoEmpresa
      ,EmpresaResidencias.[IdGiro]
	  ,GiroEmpresa.Giro
      ,EmpresaResidencias.[IdSector]
	  ,Sector.Sector
      ,EmpresaResidencias.[NombreTitular] AS TitularEmpresa
      ,EmpresaResidencias.[Cargo]
      ,EmpresaResidencias.[Telefono] AS TelefonoDeTitular
      ,EmpresaResidencias.[Extencion]
      ,EmpresaResidencias.[CorreoElectronico] AS CorreoDelTitular
      ,EmpresaResidencias.[Calle] AS CalleEmpresa
      ,EmpresaResidencias.[NoExt] AS NumeroExtEmpresa
      ,EmpresaResidencias.[NoInt] AS NumeroIntEmpresa
      ,EmpresaResidencias.[Colonia] AS ColoniaEmpresa
      ,EmpresaResidencias.[Municipio] AS MunicipioEmpresa
      ,EmpresaResidencias.[Estado] AS EstadoEmpresa
      ,EmpresaResidencias.[CodigoPostal] AS CodigoPostalEmpresa
      ,EmpresaResidencias.[PaginaWeb]
      ,EmpresaResidencias.[RedSocial]
  FROM [dbo].[Proyecto]
  INNER JOIN ModalidadResidencias ON ModalidadResidencias.IdModalidadResidencias = Proyecto.IdModalidadResidencias
  INNER JOIN DatosPersonalesResidencias ON DatosPersonalesResidencias.IdCandidato = Proyecto.IdCandidato
  INNER JOIN Carreras ON Carreras.IdCarrera = DatosPersonalesResidencias.IdCarrera
  INNER JOIN EmpresaResidencias ON EmpresaResidencias.IdEmpresaResidencias = Proyecto.IdEmpresaResidencias
  INNER JOIN TipoEmpresa ON TipoEmpresa.IdTipoEmpresa = EmpresaResidencias.IdTipoEmpresa
  INNER JOIN GiroEmpresa ON GiroEmpresa.IdGiro = EmpresaResidencias.IdGiro
  INNER JOIN Sector ON Sector.IdSector = EmpresaResidencias.IdSector
  END



----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
-- Get By Id Poryecto

CREATE PROCEDURE ResidenciaGetById
@IdProyecto INT
AS
BEGIN
SELECT Proyecto.[IdProyecto]
      ,Proyecto.IdModalidadResidencias
	  ,ModalidadResidencias.Modalidad
      ,Proyecto.[NombreIntegranteUno]
      ,Proyecto.[NombreIntegranteDos]
      ,Proyecto.[MatriculaIntegranteUno]
      ,Proyecto.[MatriculaIntegranteDos]
      ,Proyecto.[NombreProyecto]
      ,Proyecto.[NombreAsesorTesco]
      ,Proyecto.[NombreAsesorDependencia]
      ,Proyecto.[IdCandidato]
	  ,DatosPersonalesResidencias.[NombreCompleto]
      ,DatosPersonalesResidencias.[Sexo]
      ,DatosPersonalesResidencias.[Telefono]
      ,DatosPersonalesResidencias.[CorreoElectronico]
      ,DatosPersonalesResidencias.[Calle]
      ,DatosPersonalesResidencias.[NoExt]
      ,DatosPersonalesResidencias.[NoInt]
      ,DatosPersonalesResidencias.[Colonia]
      ,DatosPersonalesResidencias.[Municipio]
      ,DatosPersonalesResidencias.[Estado]
      ,DatosPersonalesResidencias.[CodigoPostal]
      ,DatosPersonalesResidencias.[IdCarrera] 
	  ,Carreras.Nombre as CarreraDeAlumno
      ,DatosPersonalesResidencias.[Especialidad]
      ,DatosPersonalesResidencias.[Matricula]
      ,DatosPersonalesResidencias.[VidaAcademica]
      ,DatosPersonalesResidencias.[NoCreditos]
      ,DatosPersonalesResidencias.[ConstanciaTerminoServicioSocial]
      ,Proyecto.[IdEmpresaResidencias]
	  ,EmpresaResidencias.[NombreDeEmpresa]
      ,EmpresaResidencias.[IdTipoEmpresa]
	  ,TipoEmpresa.TipoEmpresa
      ,EmpresaResidencias.[IdGiro]
	  ,GiroEmpresa.Giro
      ,EmpresaResidencias.[IdSector]
	  ,Sector.Sector
      ,EmpresaResidencias.[NombreTitular] AS TitularEmpresa
      ,EmpresaResidencias.[Cargo]
      ,EmpresaResidencias.[Telefono] AS TelefonoDeTitular
      ,EmpresaResidencias.[Extencion]
      ,EmpresaResidencias.[CorreoElectronico] AS CorreoDelTitular
      ,EmpresaResidencias.[Calle] AS CalleEmpresa
      ,EmpresaResidencias.[NoExt] AS NumeroExtEmpresa
      ,EmpresaResidencias.[NoInt] AS NumeroIntEmpresa
      ,EmpresaResidencias.[Colonia] AS ColoniaEmpresa
      ,EmpresaResidencias.[Municipio] AS MunicipioEmpresa
      ,EmpresaResidencias.[Estado] AS EstadoEmpresa
      ,EmpresaResidencias.[CodigoPostal] AS CodigoPostalEmpresa
      ,EmpresaResidencias.[PaginaWeb]
      ,EmpresaResidencias.[RedSocial]
  FROM [dbo].[Proyecto]
  INNER JOIN ModalidadResidencias ON ModalidadResidencias.IdModalidadResidencias = Proyecto.IdModalidadResidencias
  INNER JOIN DatosPersonalesResidencias ON DatosPersonalesResidencias.IdCandidato = Proyecto.IdCandidato
  INNER JOIN Carreras ON Carreras.IdCarrera = DatosPersonalesResidencias.IdCarrera
  INNER JOIN EmpresaResidencias ON EmpresaResidencias.IdEmpresaResidencias = Proyecto.IdEmpresaResidencias
  INNER JOIN TipoEmpresa ON TipoEmpresa.IdTipoEmpresa = EmpresaResidencias.IdTipoEmpresa
  INNER JOIN GiroEmpresa ON GiroEmpresa.IdGiro = EmpresaResidencias.IdGiro
  INNER JOIN Sector ON Sector.IdSector = EmpresaResidencias.IdSector
  WHERE IdProyecto = @IdProyecto
  END
  -----------------------------------------------------------------------------------------------------
  CREATE PROCEDURE ProyectoDelete
@IdProyecto INT,
@IdCandidato INT,
@IdEmpresaResidencias INT
AS
BEGIN

DELETE FROM [dbo].[DatosPersonalesResidencias]
      WHERE IdCandidato = @IdCandidato
	  
DELETE FROM [dbo].[EmpresaResidencias]
      WHERE IdEmpresaResidencias = @IdEmpresaResidencias

DELETE FROM [dbo].[Proyecto]
      WHERE IdProyecto = @IdProyecto

END

-------------------------------------------------------------------------------------------------------------

CREATE TABLE VacantesServicioSocial(
IdVacante INT PRIMARY KEY IDENTITY(1,1),
Nombre VARCHAR(50),
Telefono VARCHAR(50),
Direccion VARCHAR(250),
VacanteDescripcion VARCHAR(250),
Logo VARCHAR(MAX)
)


-----------------------------------------------------------------------------------------------------------


CREATE PROCEDURE VacanteGetAll
AS
BEGIN
SELECT [IdVacante]
      ,[Nombre]
      ,[Telefono]
      ,[Direccion]
      ,[VacanteDescripcion]
      ,[Logo]
  FROM [dbo].[VacantesServicioSocial]
END
______________________________________________________________________________________________________________

CREATE PROCEDURE VacanteGetById 
@IdVacante INT
AS
BEGIN
SELECT [IdVacante]
      ,[Nombre]
      ,[Telefono]
      ,[Direccion]
      ,[VacanteDescripcion]
      ,[Logo]
  FROM [dbo].[VacantesServicioSocial]
  WHERE IdVacante = @IdVacante
END

------------------------------------------------------------------------------------------------------------------------


CREATE PROCEDURE VacanteDelete
@IdVacante INT
AS
BEGIN
DELETE FROM [dbo].[VacantesServicioSocial]
      WHERE IdVacante = @IdVacante
END

--------------------------------------------------------------------------------------------------------------------------

CREATE PROCEDURE VacanteUpdate
@IdVacante INT,
@Nombre VARCHAR(50),
@Telefono VARCHAR(50),
@Direccion VARCHAR(250),
@vacanteDescripcion VARCHAR(250),
@Logo VARCHAR(MAX)
AS
BEGIN 
UPDATE [dbo].[VacantesServicioSocial]
   SET [Nombre] = @Nombre
      ,[Telefono] = @Telefono
      ,[Direccion] = @Direccion
      ,[VacanteDescripcion] = @VacanteDescripcion
      ,[Logo] = @Logo
 WHERE IdVacante = @IdVacante

 END

 -------------------------------------------------------------------------------------------

 CREATE PROCEDURE VacanteAdd
@Nombre VARCHAR(50),
@Telefono VARCHAR(50),
@Direccion VARCHAR(250),
@vacanteDescripcion VARCHAR(250),
@Logo VARCHAR(MAX)
AS
BEGIN
INSERT INTO [dbo].[VacantesServicioSocial]
           ([Nombre]
           ,[Telefono]
           ,[Direccion]
           ,[VacanteDescripcion]
           ,[Logo])
     VALUES
           (@Nombre
           ,@Telefono
           ,@Direccion
           ,@vacanteDescripcion
           ,@Logo)

END