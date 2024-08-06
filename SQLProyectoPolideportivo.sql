CREATE DATABASE PoliDB;
USE PoliDB;



CREATE TABLE deporte (
    pkiddeporte INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(50) NOT NULL,
    tipo VARCHAR(50) NOT NULL,
    PRIMARY KEY (pkiddeporte)
);

CREATE TABLE reglas (
    pkidregla INT NOT NULL AUTO_INCREMENT,
    especificacion VARCHAR(150) NOT NULL,
    descripcion VARCHAR(250) NOT NULL,
    PRIMARY KEY (pkidregla)
);

CREATE TABLE reglas_deporte (
    fkidregla INT ,
    fkiddeporte int,

    FOREIGN KEY (fkiddeporte) REFERENCES deporte(pkiddeporte),
	FOREIGN KEY (fkidregla) REFERENCES reglas(pkidregla)
);

select * from reglas;

CREATE TABLE sexo(
    pkidsexo INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(50) NOT NULL,
     PRIMARY KEY (pkidsexo)
);

INSERT INTO sexo (nombre)  -- Inserción datos predeterminados
VALUES ('Masculino'), ('Femenino');

CREATE TABLE sexo_deporte (
    fkidsexo INT NOT NULL,
    fkiddeporte INT NOT NULL,
    FOREIGN KEY (fkidsexo) REFERENCES sexo(pkidsexo),
	FOREIGN KEY (fkiddeporte) REFERENCES deporte(pkiddeporte)
);

CREATE TABLE equipo (
    pkidequipo INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(150),
    estadio VARCHAR(150),
    ciudad VARCHAR(150),
    PRIMARY KEY (pkidequipo)
);

CREATE TABLE fase (
    pkidfase INT NOT NULL AUTO_INCREMENT,
    fase VARCHAR(150),
    PRIMARY KEY (pkidfase)
);

-- Inserción fase
INSERT INTO fase (fase) VALUES
-- Fases de Fútbol
('Fase de Grupos'),
('Octavos de Final'),
('Cuartos de Final'),
('Semifinal'),
('Final'),
-- Fases de Voleibol
('Ronda de 16'),
-- Fases de Béisbol
('Temporada Regular'),
('Serie Divisional'),
('Serie de Campeonato de Liga'),
('Serie Mundial'),
-- Fases de Baloncesto
('Primera Ronda de Playoffs'),
('Semifinal de Conferencia'),
('Final de Conferencia'),
('Final de la NBA');


CREATE TABLE Permisos(
    pkidpermisos INT NOT NULL AUTO_INCREMENT,
    Permisos VARCHAR(50) ,
     PRIMARY KEY (pkidpermisos)
);

CREATE TABLE Privilegios(
    pkidprivi INT NOT NULL AUTO_INCREMENT,
    Privilegios VARCHAR(50) ,
     PRIMARY KEY (pkidprivi)
);

CREATE TABLE usuario (
    pkidusuario INT NOT NULL AUTO_INCREMENT,
    usuario VARCHAR(150),
    email varchar(150),
    contrasenia varchar(150),
    fkpermisos int,
    fkprivilegios int,
	ultimaconexion DATETIME,
    iniciosesion BOOLEAN DEFAULT FALSE,
    PRIMARY KEY (pkidusuario),
  FOREIGN KEY (fkpermisos) REFERENCES Permisos(pkidpermisos),
  FOREIGN KEY (fkprivilegios) REFERENCES Privilegios(pkidprivi)
);

CREATE TABLE bitacora (
    pkidbitacora INT NOT NULL AUTO_INCREMENT,
    fecha DATE,
    accion VARCHAR(150),
    fkidusuario INT NOT NULL,
    PRIMARY KEY (pkidbitacora),
    FOREIGN KEY (fkidusuario) REFERENCES usuario(pkidusuario)
);

CREATE TABLE arbitro (
    pkidarbitro INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(150),
    apellido VARCHAR(150),
    fechanacimiento DATE,
    nacionalidad VARCHAR(150),
    PRIMARY KEY (pkidarbitro)
);

CREATE TABLE deportista (
    pkidjugador INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(50),
    apellido VARCHAR(50),
    fechanacimiento DATE,
    nacionalidad VARCHAR(50),
    sexo varchar(50),
    fotografia longblob,
    PRIMARY KEY (pkidjugador)
);

CREATE TABLE entrenador (
    pkidentrenador INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(150),
    apellido VARCHAR(150),
    fechanacimiento DATE,
    nacionalidad VARCHAR(150),
    fkidequipo INT NOT NULL,
    PRIMARY KEY (pkidentrenador),
    FOREIGN KEY (fkidequipo) REFERENCES equipo(pkidequipo)
);

CREATE TABLE campeonato (
    pkidcampeonato INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(150) NOT NULL,
    temporada VARCHAR(50) NOT NULL,
    fechainicio DATE NOT NULL,
    fechafin DATE NOT NULL,
    fkiddeporte INT NOT NULL,
    PRIMARY KEY (pkidcampeonato),
    FOREIGN KEY (fkiddeporte) REFERENCES deporte(pkiddeporte)
);

CREATE TABLE torneo (
    pkidtorneo INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(50) NOT NULL,
    temporada VARCHAR(50) NOT NULL,
    fechainicio DATE NOT NULL,
    fechafin DATE NOT NULL,
    fkiddeporte INT NOT NULL,
    PRIMARY KEY (pkidtorneo),
    FOREIGN KEY (fkiddeporte) REFERENCES deporte(pkiddeporte)
);

CREATE TABLE jugador (
    pkidjugador INT NOT NULL AUTO_INCREMENT,
    nombre VARCHAR(150),
    apellido VARCHAR(150),
    fechanacimiento DATE,
    posicion VARCHAR(150),
    numero INT,
    nacionalidad VARCHAR(150),
    titular CHAR(1),
    fotografia BLOB,
    fkidequipo INT NOT NULL,
    cantanotaciones INT,
    PRIMARY KEY (pkidjugador),
    FOREIGN KEY (fkidequipo) REFERENCES equipo(pkidequipo)
);

CREATE TABLE partido (
    pkidpartido INT NOT NULL AUTO_INCREMENT,
    fechahora DATE NOT NULL,
    fkequipolocalid INT NOT NULL,
    fkequipovisid INT NOT NULL,
    estadopartido VARCHAR(150) NOT NULL,
    ganadorlocal varchar(150),
    ganadorvisitante varchar(150),
    empate varchar(150),
    fkidcampeonato INT NOT NULL,
    fkidfase INT NOT NULL,
    /*id_equipo INT NOT NULL,*/
    fkidarbitro INT NOT NULL,
    PRIMARY KEY (pkidpartido),
    FOREIGN KEY (fkidcampeonato) REFERENCES campeonato(pkidcampeonato),
    FOREIGN KEY (fkidfase) REFERENCES fase(pkidfase),
    FOREIGN KEY (fkequipolocalid ) REFERENCES equipo(pkidequipo),
    FOREIGN KEY (fkequipovisid ) REFERENCES equipo(pkidequipo),
    FOREIGN KEY (fkidarbitro) REFERENCES arbitro(pkidarbitro)
);

CREATE TABLE futbol(
    pkidfutbol INT NOT NULL AUTO_INCREMENT ,
    golesequipolocal INT,
    golesequipovisitante INT,
    tirosequipolocal INT,
    tirosequipovisitante INT,
    posesionequipolocal INT,
    posesionequipovisitante INT,
    fkidpartido int,
    PRIMARY KEY (pkidfutbol),
    FOREIGN KEY (fkidpartido) REFERENCES partido(pkidpartido)
);

CREATE TABLE volleyball(
	pkidvolleyball INT NOT NULL AUTO_INCREMENT,
    setsganadosequipolocal INT,
    setsganadosequipovisitante INT,
    puntostotalesequipol INT,
    puntostotalesequipovi INT,
    ataquesequipolocal INT,
    ataquesequipovisitante INT,
    bloqueosequipolocal INT,
    bloqueosequipovisitante INT,
    servicioserradoslocal INT,
    servicioserradosvis INT,
    recepcionesequipolocal INT,
    recepcionesequipovisitante INT,
    defensasequipolocal INT,
    defensasequipovisitante INT,
    acesequipolocal INT,
    acesequipovisitante INT,
    fkidpartido int,
    PRIMARY KEY (pkidvolleyball),
    FOREIGN KEY (fkidpartido) REFERENCES partido(pkidpartido)
);

CREATE TABLE baseball(
	pkidbaseball INT NOT NULL AUTO_INCREMENT,
    carrerasequipolocal INT,
    carrerasequipovisitante INT,
    hitsequipolocal INT,
    hitsequipovisitante INT,
    erroresequipolocal INT,
    erroresequipovisitante INT,
    homerunsequipolocal INT,
    homerunsequipovisitante INT,
    ponchesequipolocal INT,
    ponchesequipovisitante INT,
    basesrobadasequipolocal INT,
    basesrobadasequipovi INT,
    lanzamientosstrikelocal INT,
    lanzamientosstrikevis INT,
    entradasjugadas INT,
    fkidpartido int,
    PRIMARY KEY (pkidbaseball),
    FOREIGN KEY (fkidpartido) REFERENCES partido(pkidpartido)
);

    CREATE TABLE basketball(
	pkidbasketball INT NOT NULL AUTO_INCREMENT,
	puntosequipolocal INT,
    puntosequipovisitante INT,
    rebotesequipolocal INT,
    rebotesequipovisitante INT,
    asistenciasequipolocal INT,
    asistenciasequipovisitante INT,
    robosequipolocal INT,
    robosequipovisitante INT,
    bloqueosequipolocal1 INT,
    bloqueosequipovisitante1 INT,
    perdidasequipolocal INT,
    perdidasequipovisitante INT,
    faltasequipolocal1 INT,
    faltasequipovisitante2 INT,
    fkidpartido int,
    PRIMARY KEY (pkidbasketball),
    FOREIGN KEY (fkidpartido) REFERENCES partido(pkidpartido)
);

CREATE TABLE asistencia (
    pkidasistencia INT NOT NULL AUTO_INCREMENT,
    minuto VARCHAR(150),
    fkidjugador INT NOT NULL,
    PRIMARY KEY (pkidasistencia),
    FOREIGN KEY (fkidjugador) REFERENCES jugador(pkidjugador)
);

CREATE TABLE anotaciones (
    pkidanotaciones INT NOT NULL AUTO_INCREMENT,
    minuto VARCHAR(150) NOT NULL,
    tipoanotacion VARCHAR(150),
    fkidpartido INT NOT NULL,
    fkidjugador INT NOT NULL,
    fkidasistencia INT NOT NULL,
    descripcion VARCHAR(150),
    PRIMARY KEY (pkidanotaciones),
    FOREIGN KEY (fkidasistencia) REFERENCES asistencia(pkidasistencia),
    FOREIGN KEY (fkidjugador) REFERENCES jugador(pkidjugador),
    FOREIGN KEY (fkidpartido) REFERENCES partido(pkidpartido)
);

CREATE TABLE partidosindividuales (
    pkidsesion INT NOT NULL AUTO_INCREMENT,
    fkdeportistalocal INT NOT NULL,
    fkdeportistavisitante INT NOT NULL,
    fkidtorneo INT NOT NULL,
    PRIMARY KEY (pkidsesion),
    FOREIGN KEY (fkidtorneo) REFERENCES torneo(pkidtorneo),
    FOREIGN KEY (fkdeportistalocal) REFERENCES deportista(pkidjugador),
    FOREIGN KEY (fkdeportistavisitante) REFERENCES deportista(pkidjugador)
);

CREATE TABLE faltas (
    pkidfaltas INT NOT NULL AUTO_INCREMENT,
    minuto VARCHAR(150),
    tarjeta VARCHAR(10),
    tipofalta VARCHAR(150),
    descripcion VARCHAR(150),
    fecha DATE,
    fkidpartido INT NOT NULL,
    fkidjugador INT NOT NULL,
    fkidarbitro INT NOT NULL,
    PRIMARY KEY (pkidfaltas),
    FOREIGN KEY (fkidarbitro) REFERENCES arbitro(pkidarbitro),
    FOREIGN KEY (fkidjugador) REFERENCES jugador(pkidjugador),
    FOREIGN KEY (fkidpartido) REFERENCES partido(pkidpartido)
);

CREATE TABLE Empleado (
    pkidempleado INT NOT NULL,
    nombre      VARCHAR(150),
    apellido    VARCHAR(150),
    puesto      VARCHAR(150),
    fkidusuario    INT NOT NULL,
	PRIMARY KEY (pkidempleado)
);

CREATE TABLE Direccionempleado(
    pkiddireccion INT NOT NULL AUTO_INCREMENT,
    Calle VARCHAR(50) ,
    Avenida VARCHAR(50) ,
    Zona VARCHAR(50) ,
    Departamento VARCHAR(50) ,
    CodigoPostal VARCHAR(50) ,
	NumeroCasa VARCHAR(50),
	PRIMARY KEY (pkidDireccion)
);

CREATE TABLE Direccion_Empleado (
    fkiddireccion INT NOT NULL,
    fkidempleado INT NOT NULL,
    FOREIGN KEY (fkiddireccion) REFERENCES  Direccionempleado(pkiddireccion),
	FOREIGN KEY (fkidempleado) REFERENCES Empleado(pkidempleado)
);

CREATE TABLE Telefonoempleado(
    pkidtelefono INT NOT NULL AUTO_INCREMENT,
    telefono VARCHAR(50),
	PRIMARY KEY (pkidtelefono)
);

CREATE TABLE Telefono_Empleado (
    fkidtelefono INT NOT NULL,
    fkidempleado INT NOT NULL,
    FOREIGN KEY (fkidtelefono) REFERENCES  Telefonoempleado(pkidtelefono),
	FOREIGN KEY (fkidempleado) REFERENCES Empleado(pkidempleado)
);

-- Agregar la clave foránea
 ALTER TABLE empleado
     ADD CONSTRAINT empleado_administrador_fk FOREIGN KEY (fkidusuario) REFERENCES usuario (pkidusuario);


CREATE TABLE clasificacion (
    pkidclasificacion INT NOT NULL AUTO_INCREMENT,
    fkidequipo INT NOT NULL,
    fkidcampeonato INT NOT NULL,
    puntos INT DEFAULT 0,
    partidos_jugados INT DEFAULT 0,
    victorias INT DEFAULT 0,
    empates INT DEFAULT 0,
    derrotas INT DEFAULT 0,
    PRIMARY KEY (pkidclasificacion),
    FOREIGN KEY (fkidequipo) REFERENCES equipo(pkidequipo),
    FOREIGN KEY (fkidcampeonato) REFERENCES campeonato(pkidcampeonato),
    CONSTRAINT unique_equipo_campeonato UNIQUE (fkidequipo, fkidcampeonato)
);


-- Se creo un procedimiento para la clasificacion
DELIMITER //

CREATE PROCEDURE actualizar_clasificacion(IN p_idpartido INT)
BEGIN
    DECLARE v_equipo_local INT;
    DECLARE v_equipo_visitante INT;
    DECLARE v_campeonato INT;
    DECLARE v_ganador_local VARCHAR(150);
    DECLARE v_ganador_visitante VARCHAR(150);
    DECLARE v_empate VARCHAR(150);

    -- Obtener información del partido
    SELECT fkequipolocalid, fkequipovisid, fkidcampeonato, ganadorlocal, ganadorvisitante, empate
    INTO v_equipo_local, v_equipo_visitante, v_campeonato, v_ganador_local, v_ganador_visitante, v_empate
    FROM partido
    WHERE pkidpartido = p_idpartido;

    -- Actualizar o insertar clasificación para equipo local
    INSERT INTO clasificacion (fkidequipo, fkidcampeonato, partidos_jugados)
    VALUES (v_equipo_local, v_campeonato, 1)
    ON DUPLICATE KEY UPDATE partidos_jugados = partidos_jugados + 1;

    -- Actualizar o insertar clasificación para equipo visitante
    INSERT INTO clasificacion (fkidequipo, fkidcampeonato, partidos_jugados)
    VALUES (v_equipo_visitante, v_campeonato, 1)
    ON DUPLICATE KEY UPDATE partidos_jugados = partidos_jugados + 1;

    -- Actualizar puntos y estadísticas
    IF v_empate = 'v' THEN
        -- Caso de empate
        UPDATE clasificacion 
        SET puntos = puntos + 1, empates = empates + 1
        WHERE fkidequipo IN (v_equipo_local, v_equipo_visitante) 
        AND fkidcampeonato = v_campeonato;
    ELSEIF v_ganador_local = 'v' THEN
        -- Caso de victoria local
        UPDATE clasificacion 
        SET puntos = puntos + 3, victorias = victorias + 1
        WHERE fkidequipo = v_equipo_local AND fkidcampeonato = v_campeonato;
        
        UPDATE clasificacion 
        SET derrotas = derrotas + 1
        WHERE fkidequipo = v_equipo_visitante AND fkidcampeonato = v_campeonato;
    ELSEIF v_ganador_visitante = 'v' THEN
        -- Caso de victoria visitante
        UPDATE clasificacion 
        SET puntos = puntos + 3, victorias = victorias + 1
        WHERE fkidequipo = v_equipo_visitante AND fkidcampeonato = v_campeonato;
        
        UPDATE clasificacion 
        SET derrotas = derrotas + 1
        WHERE fkidequipo = v_equipo_local AND fkidcampeonato = v_campeonato;
    END IF;
END //

DELIMITER ;

    -- Vista para ver la clasificacion
    CREATE OR REPLACE VIEW vista_clasificacion AS
SELECT 
    c.fkidcampeonato,
    camp.nombre AS nombre_campeonato,
    e.nombre AS nombre_equipo,
    c.puntos,
    c.partidos_jugados,
    c.victorias,
    c.empates,
    c.derrotas
FROM 
    clasificacion c
    JOIN equipo e ON c.fkidequipo = e.pkidequipo
    JOIN campeonato camp ON c.fkidcampeonato = camp.pkidcampeonato
ORDER BY 
    c.fkidcampeonato, c.puntos DESC, c.victorias DESC;
    
DELIMITER //

CREATE TRIGGER actualiza_ultimaconexion
BEFORE UPDATE ON usuario
FOR EACH ROW
BEGIN
    IF NEW.iniciosesion = TRUE AND OLD.iniciosesion = FALSE THEN
        SET NEW.ultimaconexion = NOW();
        SET NEW.iniciosesion = FALSE;  -- Resetea el campo a FALSE
    END IF;
END//
DELIMITER ;

-- ACA ESTA LA VISTA DE EMPLEADO
CREATE OR REPLACE VIEW VistaEmpleado AS
SELECT
    e.pkidempleado,
    e.nombre AS NombreEmpleado,
    e.apellido,
    e.puesto,
    te.telefono,
    de.Calle,
    de.Avenida,
    de.Zona,
    de.Departamento,
    de.CodigoPostal,
    de.NumeroCasa,
    u.usuario AS usuario 
FROM
    Empleado e
    JOIN Direccion_Empleado de_emp ON e.pkidempleado = de_emp.fkidempleado
    JOIN Direccionempleado de ON de_emp.fkiddireccion = de.pkiddireccion
    JOIN Telefono_Empleado te_emp ON e.pkidempleado = te_emp.fkidempleado
    JOIN Telefonoempleado te ON te_emp.fkidtelefono = te.pkidtelefono
    JOIN Usuario u ON e.fkidusuario = u.pkidusuario; 

-- VISTA USUARIOS
CREATE OR REPLACE VIEW VistaUsuarios AS
SELECT
    u.pkidusuario AS IDUsuario,
    u.usuario AS NombreUsuario,
    u.email AS Email,
    p.Permisos AS Permiso,
    pr.Privilegios AS Privilegio,
    u.ultimaconexion AS UltimaConexion
FROM
    usuario u
    JOIN Permisos p ON u.fkpermisos = p.pkidpermisos
    JOIN Privilegios pr ON u.fkprivilegios = pr.pkidprivi
ORDER BY
    u.ultimaconexion DESC; 
  
 -- VISTA DE EQUIPOS POR CAMPEONATO
 CREATE OR REPLACE VIEW VistaEquiposPorCampeonato AS
SELECT 
    c.fkidcampeonato AS IdCampeonato,
    camp.nombre AS NombreCampeonato,
    e.pkidequipo AS IdEquipo,
    e.nombre AS NombreEquipo
FROM 
    clasificacion c
    JOIN equipo e ON c.fkidequipo = e.pkidequipo
    JOIN campeonato camp ON c.fkidcampeonato = camp.pkidcampeonato
ORDER BY 
    camp.nombre, e.nombre;
 
-- VISTA DE JUGADORES POR EQUIPO
CREATE OR REPLACE VIEW VistaJugadoresPorEquipo AS
SELECT
    e.nombre AS NombreEquipo,
    j.nombre AS NombreJugador,
    j.apellido AS ApellidoJugador,
    j.numero AS NumeroJugador,
    j.posicion AS PosicionJugador,
    j.nacionalidad AS NacionalidadJugador
FROM
    jugador j
    JOIN equipo e ON j.fkidequipo = e.pkidequipo
ORDER BY
    e.nombre, j.apellido, j.nombre;

-- VISTA DE LOS PARTIDOS FUT
CREATE OR REPLACE VIEW VistaResultadosPartidosFutbol AS
SELECT
    p.pkidpartido AS IDPartido,
    camp.nombre AS NombreCampeonato,
    el.nombre AS NombreEquipoLocal,
    ev.nombre AS NombreEquipoVisitante,
    p.fechahora AS FechaHora,
    fut.golesequipolocal AS GolesEquipoLocal,
    fut.golesequipovisitante AS GolesEquipoVisitante
FROM
    partido p
    JOIN campeonato camp ON p.fkidcampeonato = camp.pkidcampeonato
    JOIN equipo el ON p.fkequipolocalid = el.pkidequipo
    JOIN equipo ev ON p.fkequipovisid = ev.pkidequipo
    JOIN futbol fut ON p.pkidpartido = fut.fkidpartido
ORDER BY
    p.fechahora DESC;
    
    
-- VISTA PARTIDOS BASKET
CREATE OR REPLACE VIEW VistaResultadosPartidosBasketball AS
SELECT
    p.pkidpartido AS IDPartido,
    camp.nombre AS NombreCampeonato,
    el.nombre AS NombreEquipoLocal,
    ev.nombre AS NombreEquipoVisitante,
    p.fechahora AS FechaHora,
    b.puntosequipolocal AS PuntosEquipoLocal,
    b.puntosequipovisitante AS PuntosEquipoVisitante
FROM
    partido p
    JOIN campeonato camp ON p.fkidcampeonato = camp.pkidcampeonato
    JOIN equipo el ON p.fkequipolocalid = el.pkidequipo
    JOIN equipo ev ON p.fkequipovisid = ev.pkidequipo
    JOIN basketball b ON p.pkidpartido = b.fkidpartido
ORDER BY
    p.fechahora DESC;
    
-- VISTA PARTIDOS DE BASEBALL
CREATE OR REPLACE VIEW VistaResultadosPartidosBaseball AS
SELECT
    p.pkidpartido AS IDPartido,
    camp.nombre AS NombreCampeonato,
    el.nombre AS NombreEquipoLocal,
    ev.nombre AS NombreEquipoVisitante,
    p.fechahora AS FechaHora,
    b.carrerasequipolocal AS CarrerasEquipoLocal,
    b.carrerasequipovisitante AS CarrerasEquipoVisitante
FROM
    partido p
    JOIN campeonato camp ON p.fkidcampeonato = camp.pkidcampeonato
    JOIN equipo el ON p.fkequipolocalid = el.pkidequipo
    JOIN equipo ev ON p.fkequipovisid = ev.pkidequipo
    JOIN baseball b ON p.pkidpartido = b.fkidpartido
    ORDER BY
    p.fechahora DESC;

-- VISTA PARTIDOS VOLEYBOL
CREATE OR REPLACE VIEW VistaResultadosPartidosVolleyball AS
SELECT
    p.pkidpartido AS IDPartido,
    camp.nombre AS NombreCampeonato,
    el.nombre AS NombreEquipoLocal,
    ev.nombre AS NombreEquipoVisitante,
    p.fechahora AS FechaHora,
    v.setsganadosequipolocal AS SetsGanadosEquipoLocal,
    v.setsganadosequipovisitante AS SetsGanadosEquipoVisitante
FROM
    partido p
    JOIN campeonato camp ON p.fkidcampeonato = camp.pkidcampeonato
    JOIN equipo el ON p.fkequipolocalid = el.pkidequipo
    JOIN equipo ev ON p.fkequipovisid = ev.pkidequipo
    JOIN volleyball v ON p.pkidpartido = v.fkidpartido
ORDER BY
    p.fechahora DESC;

-- VISTAS DE LOS JUGADORES SUSPENDIDOS
CREATE OR REPLACE VIEW VistaJugadoresSuspendidos AS
SELECT
    j.pkidjugador AS IDJugador,
    j.nombre AS NombreJugador,
    j.apellido AS ApellidoJugador,
    j.nacionalidad AS Nacionalidad,
    j.fkidequipo AS IDEquipo,
    e.nombre AS NombreEquipo,
    f.tarjeta AS Tarjeta,
    f.tipofalta AS TipoFalta,
    f.descripcion AS DescripcionFalta,
    f.fecha AS FechaFalta,
    f.fkidjugador AS IDArbitro
FROM
    faltas f
    JOIN jugador j ON f.fkidjugador = j.pkidjugador
    JOIN equipo e ON j.fkidequipo = e.pkidequipo
WHERE
    f.tarjeta = 'Roja'
ORDER BY
    f.fecha DESC;
    
-- VISTA DE LOS DATOS PERSONALES DEL JUGADOR
CREATE OR REPLACE VIEW VistaDatosPersonalesJugadores AS
SELECT
    pkidjugador AS IDJugador,
    nombre AS Nombre,
    apellido AS Apellido,
    fechanacimiento AS FechaNacimiento,
    nacionalidad AS Nacionalidad,
    sexo AS Sexo
FROM
    deportista;
 
-- DE ACA PARA ABAJO COMO TAL SOLO HAY INGRESO DE DATOS PREDETERMINADOS 
-- cree los privilegios     
INSERT INTO Privilegios (Privilegios) VALUES ('Ver');
INSERT INTO Privilegios (Privilegios) VALUES ('Ver y Generar Reportes');
INSERT INTO Privilegios (Privilegios) VALUES ('Ver, Editar y Eliminar');

-- cree los permisos
INSERT INTO Permisos (Permisos) VALUES ('Usuario Estándar');
INSERT INTO Permisos (Permisos) VALUES ('Gerente');
INSERT INTO Permisos (Permisos) VALUES ('Administrador');

-- DE ACA PARA ABAJO SOLO HAY SELECTS E INGRESO DE DATOS DE PRUEBA 
    

   
    -- Para ingresar un partido se haria de esta forma
/*INSERT INTO partido (fechahora, fkequipolocalid, fkequipovisid, estadopartido, empate, fkidcampeonato, fkidfase, fkidarbitro)
VALUES ('2024-07-01', 1, 3, 'En curso', 'V', 3, 1, 1);
SET @ultimo_partido = LAST_INSERT_ID();
CALL actualizar_clasificacion(@ultimo_partido);
SELECT * FROM vista_clasificacion WHERE fkidcampeonato = 1; -- Se manda a llamar la vista de esta forma*/















use polidb;

SELECT * FROM usuario;
SELECT * FROM permisos;
SELECT * FROM privilegios;
select * from sexo;

SELECT * FROM Empleado;
SELECT * FROM Telefonoempleado;
SELECT * FROM Direccionempleado;
SELECT * FROM Direccion_Empleado;
SELECT * FROM Telefono_Empleado;

