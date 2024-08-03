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
	ultimaconexion DATE,
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
    
    -- Para ingresar un partido se haria de esta forma
INSERT INTO partido (fechahora, fkequipolocalid, fkequipovisid, estadopartido, empate, fkidcampeonato, fkidfase, fkidarbitro)
VALUES ('2024-07-01', 1, 3, 'En curso', 'V', 3, 1, 1);
SET @ultimo_partido = LAST_INSERT_ID();
CALL actualizar_clasificacion(@ultimo_partido);
SELECT * FROM vista_clasificacion WHERE fkidcampeonato = 1; -- Se manda a llamar la vista de esta forma


