# Liga Betplay ⚽

Sistema de gestión de torneos de fútbol usando C# y arquitectura hexagonal (Ports & Adapters).

## 📐 Arquitectura

El proyecto está dividido en:

- **Dominio**: Entidades y contratos (interfaces).
- **Aplicación**: Lógica.
- **Infraestructura**: Acceso a datos (MySQL).
- **UI**: Menu y SubMenus.

## 🧰 Tecnologías

- Lenguaje: C#
- Base de datos: MySQL
- Arquitectura: Hexagonal

## 🚀 ¿Cómo ejecutar?

1. Clona el repo. 
```
https://github.com/LeidyJohanaVillegas/ligaBetplay.git
```
2. Crea la base de datos.
```
-- Crear base de datos
CREATE DATABASE ligaBetplay;
USE ligaBetplay;

-- Tabla: Torneos.
CREATE TABLE torneos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(100),
    fecha_inicio DATE,
    fecha_fin DATE,
    ubicacion VARCHAR(100),
    estado ENUM('activo', 'finalizado', 'cancelado') -- Estado del torneo
);

-- Tabla: Equipos.
CREATE TABLE equipos (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(100),
    pais VARCHAR(50),
    fundacion YEAR
);

-- Tabla: Inscripciones.
CREATE TABLE inscripciones (
    id INT PRIMARY KEY AUTO_INCREMENT,
    equipo_id INT,
    torneo_id INT,
    fecha_inscripcion DATE,
    estado ENUM('inscrito', 'retirado'),
    FOREIGN KEY (equipo_id) REFERENCES equipos(id) ON DELETE CASCADE,
    FOREIGN KEY (torneo_id) REFERENCES torneos(id) ON DELETE CASCADE
);

-- Tabla: Jugadores.
CREATE TABLE jugadores (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(100),
    edad INT,
    fecha_nacimiento DATE,
    nacionalidad VARCHAR(50),
    posicion VARCHAR(50),
    dorsal INT,
    valor_mercado DECIMAL(10,2),
    disponibilidad BOOLEAN DEFAULT TRUE, -- TRUE = disponible para transferencia
    equipo_id INT,
    FOREIGN KEY (equipo_id) REFERENCES equipos(id) ON DELETE SET NULL
);

-- Tabla: Transferencias.
CREATE TABLE transferencias (
    id INT PRIMARY KEY AUTO_INCREMENT,
    jugador_id INT,
    equipo_origen_id INT,
    equipo_destino_id INT,
    tipo ENUM('compra', 'prestamo'),
    fecha_transferencia DATE,
    monto DECIMAL(10,2),
    FOREIGN KEY (jugador_id) REFERENCES jugadores(id) ON DELETE CASCADE,
    FOREIGN KEY (equipo_origen_id) REFERENCES equipos(id) ON DELETE SET NULL,
    FOREIGN KEY (equipo_destino_id) REFERENCES equipos(id) ON DELETE SET NULL
);

-- Tabla: Cuerpo Técnico.
CREATE TABLE cuerpo_tecnico (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(100),
    rol VARCHAR(50), -- ej: 'DT', 'Asistente'
    equipo_id INT,
    FOREIGN KEY (equipo_id) REFERENCES equipos(id) ON DELETE CASCADE
);

-- Tabla: Cuerpo Médico.
CREATE TABLE cuerpo_medico (
    id INT PRIMARY KEY AUTO_INCREMENT,
    nombre VARCHAR(100),
    especialidad VARCHAR(50),
    equipo_id INT,
    FOREIGN KEY (equipo_id) REFERENCES equipos(id) ON DELETE CASCADE
);

-- Tabla: Estadísticas por jugador y torneo.
CREATE TABLE estadisticas_jugador (
    id INT PRIMARY KEY AUTO_INCREMENT,
    jugador_id INT,
    torneo_id INT,
    goles INT DEFAULT 0,
    asistencias INT DEFAULT 0,
    partidos_jugados INT DEFAULT 0,
    FOREIGN KEY (jugador_id) REFERENCES jugadores(id) ON DELETE CASCADE,
    FOREIGN KEY (torneo_id) REFERENCES torneos(id) ON DELETE CASCADE
);
```
3. Ejecuta desde consola.

## 📦 Entidades principales

- Torneos.
- Equipos.
- Jugadores.
- Transferencias.
- Estadísticas.
- Cuerpo técnico / médico.

## ✍️ Autor.

> Proyecto realizado por Leidy Johana Niño Villegas.
