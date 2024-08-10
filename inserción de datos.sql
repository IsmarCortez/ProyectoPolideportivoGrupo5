USE PoliDB;

-- Inserciones para la tabla 'deporte'
INSERT INTO deporte (nombre, tipo) VALUES
('Fútbol', 'Equipo'),
('Voleibol', 'Equipo'),
('Béisbol', 'Equipo'),
('Baloncesto', 'Equipo');

-- Inserciones para la tabla 'reglas'
INSERT INTO reglas (especificacion, descripcion) VALUES
('Regla 1', 'Descripción de la regla 1'),
('Regla 2', 'Descripción de la regla 2');

-- Inserciones para la tabla 'reglas_deporte'
INSERT INTO reglas_deporte (fkidregla, fkiddeporte) VALUES
(1, 1),
(2, 2);


-- Inserciones para la tabla 'sexo_deporte'
INSERT INTO sexo_deporte (fkidsexo, fkiddeporte) VALUES
(1, 1),
(2, 2);

-- Inserciones para la tabla 'equipo'
INSERT INTO equipo (nombre, estadio, ciudad) VALUES
('Equipo A', 'Estadio A', 'Ciudad A'),
('Equipo B', 'Estadio B', 'Ciudad B');

-- Inserciones para la tabla 'usuario'
INSERT INTO usuario (usuario, email, contrasenia, fkpermisos, fkprivilegios, ultimaconexion) VALUES
('admin', 'admin@domain.com', 'admin123', 1, 1, '2024-01-01'),
('user', 'user@domain.com', 'user123', 2, 2, '2024-01-01');
select * from usuario;

-- Inserciones para la tabla 'bitacora'
INSERT INTO bitacora (fecha, accion, fkidusuario) VALUES
('2024-01-01', 'Acción 1', 1),
('2024-01-02', 'Acción 2', 2);

-- Inserciones para la tabla 'arbitro'
INSERT INTO arbitro (nombre, apellido, fechanacimiento, nacionalidad) VALUES
('Arbitro1', 'Apellido1', '1980-01-01', 'País1'),
('Arbitro2', 'Apellido2', '1985-01-01', 'País2');

-- Inserciones para la tabla 'deportista'
INSERT INTO deportista (nombre, apellido, fechanacimiento, nacionalidad, sexo, fotografia) VALUES
('Deportista1', 'Apellido1', '1990-01-01', 'País1', 'Masculino', NULL),
('Deportista2', 'Apellido2', '1995-01-01', 'País2', 'Femenino', NULL);

-- Inserciones para la tabla 'entrenador'
INSERT INTO entrenador (nombre, apellido, fechanacimiento, nacionalidad, fkidequipo) VALUES
('Entrenador1', 'Apellido1', '1970-01-01', 'País1', 1),
('Entrenador2', 'Apellido2', '1975-01-01', 'País2', 2);

-- Inserciones para la tabla 'campeonato'
INSERT INTO campeonato (nombre, temporada, fechainicio, fechafin, fkiddeporte) VALUES
('Campeonato1', '2024', '2024-01-01', '2024-12-31', 1),
('Campeonato2', '2024', '2024-01-01', '2024-12-31', 2);

-- Inserciones para la tabla 'torneo'
INSERT INTO torneo (nombre, temporada, fechainicio, fechafin, fkiddeporte) VALUES
('Torneo1', '2024', '2024-01-01', '2024-12-31', 1),
('Torneo2', '2024', '2024-01-01', '2024-12-31', 2);

-- Inserciones para la tabla 'jugador'
INSERT INTO jugador (nombre, apellido, fechanacimiento, posicion, numero, nacionalidad, titular, fotografia, fkidequipo, cantanotaciones) VALUES
('Jugador1', 'Apellido1', '1990-01-01', 'Delantero', 10, 'País1', 'S', NULL, 1, 5),
('Jugador2', 'Apellido2', '1995-01-01', 'Defensa', 5, 'País2', 'N', NULL, 2, 3);

-- Inserciones para la tabla 'partido'
INSERT INTO partido (fechahora, fkequipolocalid, fkequipovisid, estadopartido, ganadorlocal, ganadorvisitante, empate, fkidcampeonato, fkidfase, fkidarbitro) VALUES
('2024-07-01', 1, 2, 'Pendiente', NULL, NULL, NULL, 1, 1, 1),
('2024-07-02', 2, 1, 'Pendiente', NULL, NULL, NULL, 2, 2, 2);
select * FROM partido;

-- Inserciones para la tabla 'futbol'
INSERT INTO futbol (golesequipolocal, golesequipovisitante, tirosequipolocal, tirosequipovisitante, posesionequipolocal, posesionequipovisitante, fkidpartido) VALUES
(3, 2, 10, 8, 60, 40, 2),
(1, 1, 5, 5, 50, 50, 3);

-- Inserciones para la tabla 'volleyball'
INSERT INTO volleyball (setsganadosequipolocal, setsganadosequipovisitante, puntostotalesequipol, puntostotalesequipovi, ataquesequipolocal, ataquesequipovisitante, bloqueosequipolocal, bloqueosequipovisitante, servicioserradoslocal, servicioserradosvis, recepcionesequipolocal, recepcionesequipovisitante, defensasequipolocal, defensasequipovisitante, acesequipolocal, acesequipovisitante, fkidpartido) VALUES
(3, 2, 75, 60, 20, 18, 10, 8, 5, 4, 30, 28, 12, 10, 6, 5, 2),
(2, 3, 60, 75, 18, 20, 8, 10, 4, 5, 28, 30, 10, 12, 5, 6, 3);

-- Inserciones para la tabla 'baseball'
INSERT INTO baseball (carrerasequipolocal, carrerasequipovisitante, hitsequipolocal, hitsequipovisitante, erroresequipolocal, erroresequipovisitante, homerunsequipolocal, homerunsequipovisitante, ponchesequipolocal, ponchesequipovisitante, basesrobadasequipolocal, basesrobadasequipovi, lanzamientosstrikelocal, lanzamientosstrikevis, entradasjugadas, fkidpartido) VALUES
(5, 3, 10, 8, 1, 2, 2, 1, 7, 6, 3, 2, 50, 45, 9, 2),
(3, 5, 8, 10, 2, 1, 1, 2, 6, 7, 2, 3, 45, 50, 9, 3);

-- Inserciones para la tabla 'basketball'
INSERT INTO basketball (puntosequipolocal, puntosequipovisitante, rebotesequipolocal, rebotesequipovisitante, asistenciasequipolocal, asistenciasequipovisitante, robosequipolocal, robosequipovisitante, bloqueosequipolocal1, bloqueosequipovisitante1, perdidasequipolocal, perdidasequipovisitante, faltasequipolocal1, faltasequipovisitante2, fkidpartido) VALUES
(100, 98, 45, 40, 25, 20, 15, 10, 5, 4, 10, 8, 20, 18, 2),
(98, 100, 40, 45, 20, 25, 10, 15, 4, 5, 8, 10, 18, 20, 3);


-- Inserciones para la tabla 'asistencia'
INSERT INTO asistencia (minuto, fkidjugador) VALUES
(85, 1),
(90, 2);

select * from asistencia;
-- Inserciones para la tabla 'anotaciones'
INSERT INTO anotaciones (minuto, tipoanotacion, fkidjugador, fkidpartido, fkidasistencia, descripcion) VALUES
('85', 'Gol', 1, 2, 1, 'Descripción de la anotación 1'),
('90', 'Gol', 2, 3, 2, 'Descripción de la anotación 2');
-- Inserciones para la tabla 'partidosindividuales'
INSERT INTO partidosindividuales (fkdeportistalocal, fkdeportistavisitante, fkidtorneo) VALUES
(1, 2, 1),
(2, 1, 2);

-- Inserciones para la tabla 'faltas'
INSERT INTO faltas (minuto, tarjeta, tipofalta, descripcion, fecha, fkidpartido, fkidjugador, fkidarbitro) VALUES
('30', 'Amarilla', 'Falta leve', 'Descripción de la falta 1', '2024-07-01', 2, 1, 1),
('45', 'Roja', 'Falta grave', 'Descripción de la falta 2', '2024-07-02', 3, 2, 2);

-- Inserciones para la tabla 'Empleado'
INSERT INTO Empleado (pkidempleado, nombre, apellido, puesto, fkidusuario) VALUES
(1, 'Empleado1', 'Apellido1', 'Puesto1', 1),
(2, 'Empleado2', 'Apellido2', 'Puesto2', 2);

-- Inserciones para la tabla 'Direccionempleado'
INSERT INTO Direccionempleado (Calle, Avenida, Zona, Departamento, CodigoPostal, NumeroCasa) VALUES
('Calle 1', 'Avenida 1', 'Zona 1', 'Departamento 1', '1001', 'Casa 1'),
('Calle 2', 'Avenida 2', 'Zona 2', 'Departamento 2', '1002', 'Casa 2');

-- Inserciones para la tabla 'Direccion_Empleado'
INSERT INTO Direccion_Empleado (fkiddireccion, fkidempleado) VALUES
(1, 1),
(2, 2);

-- Inserciones para la tabla 'Telefonoempleado'
INSERT INTO Telefonoempleado (telefono) VALUES
('555-1234'),
('555-5678');

-- Inserciones para la tabla 'Telefono_Empleado'
INSERT INTO Telefono_Empleado (fkidtelefono, fkidempleado) VALUES
(1, 1),
(2, 2);

-- Inserciones para la tabla 'clasificacion'
INSERT INTO clasificacion (fkidequipo, fkidcampeonato, puntos, partidos_jugados, victorias, empates, derrotas) VALUES
(1, 1, 10, 5, 3, 1, 1),
(2, 2, 8, 5, 2, 2, 1);

-- inserte el administrador de manera manual
INSERT INTO usuario (usuario, email, contrasenia, fkpermisos, fkprivilegios, ultimaconexion) VALUES 
('Alejandro', 'alejandro@gmail.com', '1234', 3, 3, '2024-08-01');
INSERT INTO Empleado (pkidempleado, nombre, apellido, puesto, fkidusuario) VALUES 
(1, 'Alejandro', 'Boch', 'Administrador', 1);
INSERT INTO Direccionempleado (Calle, Avenida, Zona, Departamento, CodigoPostal, NumeroCasa) VALUES
('5ta', '9na', '1', 'Guatemala', '11001', '13');  
INSERT INTO Direccion_Empleado (fkiddireccion, fkidempleado)  VALUES (1,1);
INSERT INTO Telefonoempleado (telefono) VALUES ('55335918');
INSERT INTO Telefono_Empleado (fkidtelefono, fkidempleado) VALUES (1,1);

INSERT INTO usuario (usuario, email, contrasenia, fkpermisos, fkprivilegios, ultimaconexion) VALUES 
('Katy', 'katy@gmail.com', '4321', 3, 3, '2024-08-01');

select * from usuario;