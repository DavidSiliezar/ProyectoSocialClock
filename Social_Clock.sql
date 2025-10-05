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
insert into Rol values
('Administrador'),
('Colaborador');

insert into Proyecto values
('Stant Cultural',0),
('Psicología',0);

insert into Proyecto values
('OPV asistencia',0),
('Vida comunitaria',0),
('Mural de enfermería',0),
('Tutor de inglés',0),
('Tutor de software',0),
('Tutor de arquitectura',0),
('Orquesta ITR',0),
('Comunicaciones',0),
('Desafío matemático',0),
('Evangelización',0),
('Gestion de mobiliario',0),
('Logística',0),
('Infraestructura tecnológica',0),
('Seguridad y emergencia',0),
('Protocolo',0),
('Cultural',0),
('Técnico científico',0),
('Seleccion deportiva',0),
('Coreografía RICO',0),
('Apoyo en psicología',0),
('Teatro logística',0),
('Escuela prof.Sandor',0),
('Teletón',0),
('Externo',0);

insert into Especialidad values
('Desarrollo de software'),
('Diseño gráfico'),
('Electromecánica'),
('Arquitectura'),
('Administrativo contable'),
('Electrónica'),
('Energías renovables'),
('Mantenimiento Automotriz');

insert into Seccion values 
('A-1'),
('A-2'),
('A-3'),
('A-4'),
('A-5'),
('B-1'),
('B-2'),
('B-3'),
('B-4');

insert into NivelAcademico values
('Primer año'),
('Segundo año'),
('Tercer año');

insert into Esp_Niv_Sec values 
(1,1,1),
(1,1,2);

--Para software
insert into Esp_Niv_Sec values 
(1,1,3),
(1,1,4),
(1,1,5),
(1,1,6),
(1,1,7),
(1,1,8),
(1,1,9),
(1,2,1),
(1,2,2),
(1,2,3),
(1,2,4),
(1,2,6),
(1,2,7),
(1,2,8),
(1,2,9),
(1,3,1),
(1,3,2),
(1,3,3),
(1,3,4),
(1,3,6),
(1,3,7),
(1,3,8),
(1,3,9);

--Para Diseño Grafico
insert into Esp_Niv_Sec values 
(2,1,1),
(2,1,2),
(2,1,3),
(2,1,4),
(2,1,5),
(2,1,6),
(2,1,7),
(2,1,8),
(2,1,9),
(2,2,1),
(2,2,2),
(2,2,3),
(2,2,4),
(2,2,6),
(2,2,7),
(2,2,8),
(2,2,9),
(2,3,1),
(2,3,2),
(2,3,3),
(2,3,4),
(2,3,6),
(2,3,7),
(2,3,8),
(2,3,9);

--Para EMCA
insert into Esp_Niv_Sec values 
(3,1,1),
(3,1,2),
(3,1,3),
(3,1,4),
(3,1,5),
(3,1,6),
(3,1,7),
(3,1,8),
(3,1,9),
(3,2,1),
(3,2,2),
(3,2,3),
(3,2,4),
(3,2,6),
(3,2,7),
(3,2,8),
(3,2,9),
(3,3,1),
(3,3,2),
(3,3,3),
(3,3,4),
(3,3,6),
(3,3,7),
(3,3,8),
(3,3,9);

--Para Arquitectura
insert into Esp_Niv_Sec values 
(4,1,1),
(4,1,2),
(4,1,3),
(4,1,4),
(4,1,5),
(4,1,6),
(4,1,7),
(4,1,8),
(4,1,9),
(4,2,1),
(4,2,2),
(4,2,3),
(4,2,4),
(4,2,6),
(4,2,7),
(4,2,8),
(4,2,9),
(4,3,1),
(4,3,2),
(4,3,3),
(4,3,4),
(4,3,6),
(4,3,7),
(4,3,8),
(4,3,9);

--Para Administracion Contable
insert into Esp_Niv_Sec values 
(5,1,1),
(5,1,2),
(5,1,3),
(5,1,4),
(5,1,5),
(5,1,6),
(5,1,7),
(5,1,8),
(5,1,9),
(5,2,1),
(5,2,2),
(5,2,3),
(5,2,4),
(5,2,6),
(5,2,7),
(5,2,8),
(5,2,9),
(5,3,1),
(5,3,2),
(5,3,3),
(5,3,4),
(5,3,6),
(5,3,7),
(5,3,8),
(5,3,9);

--Para ECA
insert into Esp_Niv_Sec values 
(6,1,1),
(6,1,2),
(6,1,3),
(6,1,4),
(6,1,5),
(6,1,6),
(6,1,7),
(6,1,8),
(6,1,9),
(6,2,1),
(6,2,2),
(6,2,3),
(6,2,4),
(6,2,6),
(6,2,7),
(6,2,8),
(6,2,9),
(6,3,1),
(6,3,2),
(6,3,3),
(6,3,4),
(6,3,6),
(6,3,7),
(6,3,8),
(6,3,9);

--Para Enerías renobables
insert into Esp_Niv_Sec values 
(7,1,1),
(7,1,2),
(7,1,3),
(7,1,4),
(7,1,5),
(7,1,6),
(7,1,7),
(7,1,8),
(7,1,9),
(7,2,1),
(7,2,2),
(7,2,3),
(7,2,4),
(7,2,6),
(7,2,7),
(7,2,8),
(7,2,9),
(7,3,1),
(7,3,2),
(7,3,3),
(7,3,4),
(7,3,6),
(7,3,7),
(7,3,8),
(7,3,9);

--Para Automotriz
insert into Esp_Niv_Sec values 
(8,1,1),
(8,1,2),
(8,1,3),
(8,1,4),
(8,1,5),
(8,1,6),
(8,1,7),
(8,1,8),
(8,1,9),
(8,2,1),
(8,2,2),
(8,2,3),
(8,2,4),
(8,2,6),
(8,2,7),
(8,2,8),
(8,2,9),
(8,3,1),
(8,3,2),
(8,3,3),
(8,3,4),
(8,3,6),
(8,3,7),
(8,3,8),
(8,3,9);


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

CREATE PROC AlumnosPorProyecto1
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

SELECT 
    e.idEvento,
    e.nombreEvento        AS Evento,
    e.descripcionEvento   AS [Descripción],
    e.fechaHoraPublicacion AS [Fecha de publicación],
    e.fechaEvento         AS [Fecha del evento],
    u.nombreUsuario       AS [Nombre del usuario]
FROM Evento AS e
INNER JOIN Usuario AS u 
    ON e.idUsuario = u.idUsuario