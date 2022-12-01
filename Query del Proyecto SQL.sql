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

