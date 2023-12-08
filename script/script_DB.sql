CREATE TABLE IF NOT EXISTS Cuadrillas (
    codigo_cuadrilla SERIAL PRIMARY KEY,
    nombre_cuadrilla VARCHAR(50) NOT NULL,
    localizacion VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS Albaniles (
    numero_seguridad_social SERIAL PRIMARY KEY,
    nombre VARCHAR(50) NOT NULL,
    apellido VARCHAR(50) NOT NULL,
    fecha_nacimiento DATE NOT NULL,
    numero_telefonico VARCHAR(15) NOT NULL,
    categoria_profesional VARCHAR(50) NOT NULL,
    codigo_cuadrilla INT,
    FOREIGN KEY (codigo_cuadrilla) REFERENCES Cuadrillas(codigo_cuadrilla)
);