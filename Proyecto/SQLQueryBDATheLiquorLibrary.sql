
---------------------CREACIÓN BASE DE DATOS---------------------

CREATE DATABASE licoreria
USE licoreria

---------------------CREACIÓN TABLAS----------------------------

CREATE TABLE licores(
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre NVARCHAR(50),
	pais_origen NVARCHAR(50),
	sabor NVARCHAR(50),
	color NVARCHAR(50),
	porcentaje_alcohol NVARCHAR(5),
	precio MONEY,
	stock INT
)

CREATE TABLE clientes(
	id INT IDENTITY (1,1) PRIMARY KEY,
	nombre NVARCHAR(50),
	apellido NVARCHAR(50),
	rfc NVARCHAR(13),
	direccion NVARCHAR(50),
	email NVARCHAR(50)
)

CREATE TABLE ventas(
	folio INT IDENTITY (1,1) PRIMARY KEY,
	fecha NVARCHAR(50),
	formatoPago NVARCHAR(50),

--REFERENCIAS
	cliente_id INT,

--RELACIONES
	CONSTRAINT RELACION_A_CLIENTE FOREIGN KEY(cliente_id) REFERENCES clientes(id)
)

CREATE TABLE licor_venta(
	cantidad INT,

--REFERENCIAS
	licor_id INT,
	venta_id INT,

--RELACIONES
	CONSTRAINT RELACION_A_LICOR FOREIGN KEY(licor_id) REFERENCES licores(id),
	CONSTRAINT RELACION_A_REPORTE FOREIGN KEY(venta_id) REFERENCES ventas(folio)
)

---------------------INSERCIÓN DE DATOS-------------------------

----------INSERTANDO LICORES

INSERT INTO LICORES(nombre,pais_origen,sabor,color,porcentaje_alcohol,precio,stock)
VALUES ('Galliano','Italia','Naranja','Dorado','40',450,5);

INSERT INTO LICORES(nombre,pais_origen,sabor,color,porcentaje_alcohol,precio,stock)
VALUES ('Cherry Heering','Dinamarca','Cereza','Rojizo','24',780,7);

INSERT INTO LICORES(nombre,pais_origen,sabor,color,porcentaje_alcohol,precio,stock)
VALUES ('Strega','Italia','Pimiento','Dorado Suave','42',590,2);

----------INSERTANDO CLIENTES

INSERT INTO clientes(nombre,apellido,rfc,direccion,email)
VALUES ('Mauricio','Romero','ROTM970823NM6','Emiliano Zapata','Mauri@gmail.com');

---------------------PROCEDIMIENTOS ALMACENADOS-------------------------
----------LISTAR LICORES
CREATE PROC ListarLicores
AS
SELECT * FROM LICORES ORDER BY id ASC
GO
----------INSERTAR LICOR
CREATE PROC InsertarLicor
@nombre NVARCHAR(50),
@pais_origen NVARCHAR(50),
@sabor NVARCHAR(50),
@color NVARCHAR(50),
@porcentaje_alcohol NVARCHAR(5),
@precio MONEY,
@stock INT
AS
INSERT INTO LICORES VALUES (@nombre,@pais_origen,@sabor,@color,@porcentaje_alcohol,@precio,@stock)
GO
----------INSERTAR CLIENTE
CREATE PROC InsertarCliente
@nombre NVARCHAR(50),
@apellido NVARCHAR(50),
@rfc NVARCHAR(13),
@direccion NVARCHAR(50),
@email NVARCHAR(50)
AS
INSERT INTO clientes VALUES (@nombre,@apellido,@rfc,@direccion,@email)
GO
----------INSERTAR VENTA
CREATE PROC InsertarVenta
@formatoPago NVARCHAR(50),
@fecha NVARCHAR(50),
@cliente_id INT
AS
INSERT INTO ventas VALUES (@formatoPago,@fecha,@cliente_id)
GO
----------INSERTAR LICOR VENTA
CREATE PROC InsertarLicorVenta
@cantidad INT,
@licor_id INT,
@venta_id INT
AS
INSERT INTO licor_venta VALUES (@cantidad,@licor_id,@venta_id)
GO
--Extras 
exec ListarLicores
select * from clientes
select * from ventas
SELECT * from licor_venta 