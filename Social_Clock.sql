CREATE DATABASE Social_Clock
GO
USE Social_Clock;
GO


CREATE TABLE Rol (
    idRol INT IDENTITY(1,1) PRIMARY KEY,
    nombreRol VARCHAR(25) NOT NULL
);
GO

CREATE TABLE Proyecto (
    idProyecto INT IDENTITY(1,1) PRIMARY KEY,
    nombreProyecto VARCHAR(40) NOT NULL,
    estadoProyecto BIT DEFAULT 0 NOT NULL
);
GO

CREATE TABLE Especialidad (
    idEspecialidad INT IDENTITY(1,1) PRIMARY KEY,
    nombreEspecialidad VARCHAR(40) NOT NULL
);
GO

CREATE TABLE NivelAcademico (
    idNivelAcademico INT IDENTITY(1,1) PRIMARY KEY,
    nombreNivel VARCHAR(30) NOT NULL
);
GO

CREATE TABLE Seccion(
    idSeccion INT IDENTITY(1,1) PRIMARY KEY,
    nombreSeccion VARCHAR(40) NOT NULL
);
GO

-- Tablas relacionadas
CREATE TABLE Esp_Niv_Sec(
    idEsp_Niv_Sec INT IDENTITY(1,1) PRIMARY KEY,
    id_Especialidad INT NOT NULL,
    id_NivelAcademico INT NOT NULL,
    id_Seccion INT NOT NULL,
    CONSTRAINT fkEspecialidad FOREIGN KEY (id_Especialidad)
        REFERENCES Especialidad(idEspecialidad) ON DELETE CASCADE,
    CONSTRAINT fkSeccion FOREIGN KEY (id_Seccion)
        REFERENCES Seccion(idSeccion) ON DELETE CASCADE,
    CONSTRAINT fkNivelAcademico FOREIGN KEY (id_NivelAcademico)
        REFERENCES NivelAcademico(idNivelAcademico) ON DELETE CASCADE
);
GO

CREATE TABLE Usuario (
    idUsuario INT IDENTITY(1,1) PRIMARY KEY,
    nombreUsuario VARCHAR(100) UNIQUE NOT NULL,
    clave VARCHAR(100) UNIQUE NOT NULL,
    estadoUsuario BIT DEFAULT 0 NOT NULL,
    id_Rol INT NOT NULL,
    primerLogin BIT NOT NULL,
    CONSTRAINT fkRol FOREIGN KEY (id_Rol)
        REFERENCES Rol(idRol) ON DELETE CASCADE
);
GO

CREATE TABLE Evento (
    idEvento INT IDENTITY(1,1) PRIMARY KEY,
    nombreEvento VARCHAR(40) NOT NULL,
    descripcionEvento VARCHAR(200) NOT NULL,
    fechaEvento DATE NOT NULL,
    fechaHoraPublicacion DATETIME NOT NULL,
    idUsuario INT NOT NULL,
    CONSTRAINT fkUsuario FOREIGN KEY (idUsuario)
        REFERENCES Usuario(idUsuario) ON DELETE CASCADE
);
GO

CREATE TABLE Estudiante (
    idEstudiante INT IDENTITY(1,1) PRIMARY KEY,
    nombreEstudiante VARCHAR(50) NOT NULL,
    carnet VARCHAR(8) UNIQUE NOT NULL,
    nie VARCHAR(8) DEFAULT 0,
    estadoEstudiante BIT DEFAULT 0 NOT NULL,
    id_Proyecto INT NOT NULL,
    id_EspNivSec INT NOT NULL,
    CONSTRAINT fkProyecto FOREIGN KEY (id_Proyecto)
        REFERENCES Proyecto(idProyecto) ON DELETE CASCADE,
    CONSTRAINT fkEspNivSec FOREIGN KEY (id_EspNivSec)
        REFERENCES Esp_Niv_Sec(idEsp_Niv_Sec) ON DELETE CASCADE
);
GO

CREATE TABLE BitacoraSocial (
    idBitacora INT IDENTITY(1,1) PRIMARY KEY,
    registroHoras INT NOT NULL,
    descripcion NVARCHAR(100) NOT NULL,
    fechaBitacora DATE NOT NULL,
    idEstudiante INT NOT NULL,
    CONSTRAINT fkEstudiante FOREIGN KEY(idEstudiante)
        REFERENCES Estudiante(idEstudiante) ON DELETE CASCADE
);
GO

-- Insertar datos iniciales
INSERT INTO Rol VALUES
('Administrador'), ('Colaborador');

INSERT INTO Proyecto VALUES
('Stant Cultural',0), ('Psicología',0),
('OPV asistencia',0), ('Vida comunitaria',0),
('Mural de enfermería',0), ('Tutor de inglés',0),
('Tutor de software',0), ('Tutor de arquitectura',0),
('Orquesta ITR',0), ('Comunicaciones',0),
('Desafío matemático',0), ('Evangelización',0),
('Gestion de mobiliario',0), ('Logística',0),
('Infraestructura tecnológica',0), ('Seguridad y emergencia',0),
('Protocolo',0), ('Cultural',0),
('Técnico científico',0), ('Seleccion deportiva',0),
('Coreografía RICO',0), ('Apoyo en psicología',0),
('Teatro logística',0), ('Escuela prof.Sandor',0),
('Teletón',0), ('Externo',0);

INSERT INTO Especialidad VALUES
('Desarrollo de software'), ('Diseño gráfico'), ('Electromecánica'),
('Arquitectura'), ('Administrativo contable'), ('Electrónica'),
('Energías renovables'), ('Mantenimiento Automotriz');

INSERT INTO Seccion VALUES 
('A-1'),('A-2'),('A-3'),('A-4'),('A-5'),
('B-1'),('B-2'),('B-3'),('B-4');

INSERT INTO NivelAcademico VALUES
('Primer año'),('Segundo año'),('Tercer año');

-- Insertar combinaciones de especialidad, nivel y sección (Esp_Niv_Sec)
INSERT INTO Esp_Niv_Sec VALUES 
(1,1,1),(1,1,2),(1,1,3),(1,1,4),(1,1,5),(1,1,6),(1,1,7),(1,1,8),(1,1,9),
(1,2,1),(1,2,2),(1,2,3),(1,2,4),(1,2,6),(1,2,7),(1,2,8),(1,2,9),
(1,3,1),(1,3,2),(1,3,3),(1,3,4),(1,3,6),(1,3,7),(1,3,8),(1,3,9);

-- Procedimientos almacenados de estadísticas
CREATE PROC CantidadAlumnosPrimer
AS
SELECT 
    Proyecto.nombreProyecto AS [Proyectos],
    COUNT(Estudiante.idEstudiante) AS [N° de estudiantes]
FROM Proyecto
LEFT JOIN Estudiante ON Proyecto.idProyecto = Estudiante.id_Proyecto
INNER JOIN Esp_Niv_Sec ON Estudiante.id_EspNivSec = Esp_Niv_Sec.idEsp_Niv_Sec
INNER JOIN NivelAcademico ON Esp_Niv_Sec.id_NivelAcademico = NivelAcademico.idNivelAcademico
WHERE NivelAcademico.nombreNivel = 'Primer año'
GROUP BY Proyecto.nombreProyecto
ORDER BY Proyecto.nombreProyecto;
GO

CREATE PROC CantidadAlumnosSegundo
AS
SELECT 
    Proyecto.nombreProyecto AS [Proyectos],
    COUNT(Estudiante.idEstudiante) AS [N° de estudiantes]
FROM Proyecto
LEFT JOIN Estudiante ON Proyecto.idProyecto = Estudiante.id_Proyecto
INNER JOIN Esp_Niv_Sec ON Estudiante.id_EspNivSec = Esp_Niv_Sec.idEsp_Niv_Sec
INNER JOIN NivelAcademico ON Esp_Niv_Sec.id_NivelAcademico = NivelAcademico.idNivelAcademico
WHERE NivelAcademico.nombreNivel = 'Segundo año'
GROUP BY Proyecto.nombreProyecto
ORDER BY Proyecto.nombreProyecto;
GO

CREATE PROC CantidadAlumnosTercer
AS
SELECT 
    Proyecto.nombreProyecto AS [Proyectos],
    COUNT(Estudiante.idEstudiante) AS [N° de estudiantes]
FROM Proyecto
LEFT JOIN Estudiante ON Proyecto.idProyecto = Estudiante.id_Proyecto
INNER JOIN Esp_Niv_Sec ON Estudiante.id_EspNivSec = Esp_Niv_Sec.idEsp_Niv_Sec
INNER JOIN NivelAcademico ON Esp_Niv_Sec.id_NivelAcademico = NivelAcademico.idNivelAcademico
WHERE NivelAcademico.nombreNivel = 'Tercer año'
GROUP BY Proyecto.nombreProyecto
ORDER BY Proyecto.nombreProyecto;
GO

CREATE PROC LabibisPorProyecto1
AS
SELECT  Proyecto.nombreProyecto AS Proyecto,
COUNT(E.idEstudiante) AS Alumnos 
FROM Proyecto  
LEFT JOIN Estudiante E ON E.id_Proyecto = Proyecto.idProyecto
GROUP BY Proyecto.nombreProyecto
ORDER BY Proyecto;
GO


delete from Usuario
select *from Usuario