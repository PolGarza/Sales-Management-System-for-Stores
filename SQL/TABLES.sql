CREATE DATABASE DB_MAD_4;
USE  DB_MAD_4;

--Tabla Administrador
CREATE TABLE Administrador (

	Id_Admin			INT IDENTITY(1000000, 1) NOT NULL,
	Nombre				VARCHAR(30) NOT NULL,
	Usuario				VARCHAR(30) NOT NULL,
	Clave				VARCHAR(50),
	Estado				bit default(1)

		CONSTRAINT PK_Administrador
			PRIMARY KEY(Id_Admin)

);

--Tabla Cajero 
CREATE TABLE Cajero  (

		Id_Cajero		  INT IDENTITY(1000000, 1) NOT NULL,
		Nombre		      VARCHAR(30),
		CURP		      CHAR(18),
		Email		      VARCHAR(50),
		Clave		      VARCHAR(50),
		Fecha_Nam	      DATE,
		Fecha_Ingreso     DATETIME,
		Estado			  bit default(1)
		
		CONSTRAINT PK_Cajero
			PRIMARY KEY(Id_Cajero),


);

--Tabla Departamento
CREATE TABLE Departamento (

	Id_Departamento		 INT IDENTITY(1000000, 1) NOT NULL,
	Nombre				VARCHAR(30),
	Estado				bit default(1)

		CONSTRAINT PK_Departamento
			PRIMARY KEY(Id_Departamento)


);

ALTER TABLE Departamento
ADD Fecha_Ingre DATETIME;

--Tabla Producto
CREATE TABLE Producto (

	Id_Producto				integer primary key identity,
	Nombre_prodcuto			varchar(100) not null unique,
	Id_Departamento			INT NOT NULL,
	Id_Admin				INT NOT NULL,
	Descripcion				varchar(255) null,
	Unidad_Medida			varchar(20) null,
    Precio_producto			decimal(11,4) not null,
	Costo_producto		    decimal(11,4) not null,
	Existencia				CHAR,
	stock					integer not null,
	Restock                 integer,
	estado					bit default(1),
	Devolucion			   bit default(1),
	Fecha_Producto			DATETIME,

	FOREIGN KEY (Id_Departamento) REFERENCES Departamento(Id_Departamento),
	FOREIGN KEY (Id_Admin) REFERENCES Administrador(Id_Admin)
);

--Tabla Venta 

CREATE TABLE Venta (

	Id_Venta			INT IDENTITY(1000000, 1) NOT NULL,
	Id_Cajero			INT,
	Tipo_Comprobante	Varchar(20),
	Caja_Num 			Varchar(40) null,
	Fecha				DATETIME,
	Total				Decimal(11,2),
	Descuento			Decimal(4,2),
	Estado				Varchar(20), 
	codigo_venta        INT,
	
		CONSTRAINT PK_Venta
			PRIMARY KEY(Id_Venta),

			FOREIGN KEY (Id_Cajero) 
			REFERENCES Cajero(Id_Cajero)

);

--Tabla Detalle_Venta
CREATE TABLE Detalle_Venta (

	IdDetalle_Venta		INT IDENTITY(1000000, 1) NOT NULL,
	Id_Venta			INT,
	Id_Producto			INT,
	Producto1		    Varchar(100),
	Cantidad			INT,
	Precio				Decimal(11,4),
	Importe				Decimal(11,4),
	Unidad_Medida		varchar(20) null,
	Descuento			Decimal(11,2), 
	Devolucion			   bit default(1),
	
		CONSTRAINT PK_Detalle_Venta
			PRIMARY KEY(IdDetalle_Venta),

			FOREIGN KEY (Id_Venta) 
			REFERENCES Venta(Id_Venta),

			FOREIGN KEY (Id_Producto) 
			REFERENCES Producto(Id_Producto)

);
--Tabla Devolucion 
CREATE TABLE Devolucion(
IdDev	INT IDENTITY(1000000, 1) NOT NULL,
	Id_Venta			INT,
	Id_Producto			INT,
	Producto1		    Varchar(100),
	Cantidad			INT,
	Precio				Decimal(11,4),
	Importe				Decimal(11,4),
	Unidad_Medida		varchar(20) null,
	Tipo_Dev            varchar(20) null,

CONSTRAINT IdDev
PRIMARY KEY(IdDev),

);

SELECT * FROM Devolucion
