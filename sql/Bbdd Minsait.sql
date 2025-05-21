##David Serrano Tarazona
CREATE DATABASE IF NOT EXISTS minsait CHARACTER SET UTF8;
USE minsait;

CREATE TABLE IF NOT EXISTS categoria(
id INT AUTO_INCREMENT PRIMARY KEY,
nombre VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS ubicacion(
id INT AUTO_INCREMENT PRIMARY KEY, 
tipo ENUM('Online','Presencial') NOT NULL,
direccion VARCHAR(200) 
);

CREATE TABLE IF NOT EXISTS organizadores(
id INT AUTO_INCREMENT PRIMARY KEY,
nombre VARCHAR(50) NOT NULL,
email VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS usuario(
id INT AUTO_INCREMENT PRIMARY KEY,
nombre VARCHAR(50) NOT NULL,
email VARCHAR(50) NOT NULL
);

CREATE TABLE IF NOT EXISTS evento(
id INT AUTO_INCREMENT PRIMARY KEY,
nombre VARCHAR(50) NOT NULL,
fecha DATE NOT NULL,
duracion FLOAT NOT NULL,
descp VARCHAR(200) NOT NULL,
organizador_id INT,
categoria_id INT,
ubicacion_id INT,
estado ENUM('Activo','Cancelado'),
FOREIGN KEY (organizador_id) REFERENCES organizadores(id),
FOREIGN KEY (categoria_id) REFERENCES categoria(id),
FOREIGN KEY (ubicacion_id) REFERENCES ubicacion(id)
);

CREATE TABLE IF NOT EXISTS inscripcion(
id INT AUTO_INCREMENT PRIMARY KEY,
usuario_id INT,
evento_id INT,
fecha_inscripcion DATE NOT NULL,
FOREIGN KEY (usuario_id) REFERENCES usuario(id),
FOREIGN KEY (evento_id) REFERENCES evento(id)
);