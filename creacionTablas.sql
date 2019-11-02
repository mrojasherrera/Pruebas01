/********* ESPECIFICACION DE LA BASE DE DATOS QUE SE VA A USAR *********/
USE GD2C2019

  

--
/********* SE CREA EL ESQUEMA *********/
if(not exists(select * from INFORMATION_SCHEMA.SCHEMATA where SCHEMA_NAME = 'LOS_BORBOTONES'))
  begin
      exec ('CREATE SCHEMA[LOS_BORBOTONES] AUTHORIZATION [gdCupon2019]');
      print 'exquema creado';
    end

/***************************************/
/********* CREACION DE TABLAS *********/
/***************************************/

IF OBJECT_ID ('LOS_BORBOTONES.Cliente', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Cliente;  
GO

create table LOS_BORBOTONES.Cliente
(Cli_Nombre nvarchar(255),
Cli_Apellido nvarchar(255),
Cli_Dni numeric(18, 0),
Cli_Direccion nvarchar(255),
Cli_Telefono numeric(18, 0),
Cli_Mail nvarchar(255),
Cli_Fecha_Nac datetime,
Cli_Ciudad nvarchar(255),
Cli_CodigoPostal nvarchar(10),
User_name nvarchar(50),
Cli_Saldo numeric(18,2),
Habilitado bit DEFAULT(1)
);

---

IF OBJECT_ID ('LOS_BORBOTONES.Proveedor', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Proveedor;  
GO

create table LOS_BORBOTONES.Proveedor
(Provee_RS nvarchar(100),
Provee_Dom nvarchar(100),
Provee_Ciudad nvarchar(255),
Provee_Telefono numeric(18, 0),
Provee_CUIT nvarchar(20),
Provee_Rubro nvarchar(100),
Provee_Mail nvarchar(255),
Provee_Cod_postal nvarchar(10),
Provee_Nombre_Contacto nvarchar(255),
User_name nvarchar(50)
);

---

IF OBJECT_ID ('LOS_BORBOTONES.Usuario', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Usuario;  
GO

create table LOS_BORBOTONES.Usuario
(User_name nvarchar(50),
Password nvarchar(32),
Habilitado bit DEFAULT(1),
Cant_Log_Fallidos tinyint
);

---
IF OBJECT_ID ('LOS_BORBOTONES.Rol_Usuario', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Rol_Usuario;  
GO

create table LOS_BORBOTONES.Rol_Usuario
(User_name nvarchar(50),
Rol_Id INT
);

---

IF OBJECT_ID ('LOS_BORBOTONES.Role', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Role;  
GO

create table LOS_BORBOTONES.Role
(Rol_Id  int IDENTITY,
Rol_Nombre nvarchar(255)
);

---

IF OBJECT_ID ('LOS_BORBOTONES.Func_Rol', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Func_Rol;  
GO

Create table LOS_BORBOTONES.Func_Rol
(Rol_Id int,
Func_Id int
);

---

IF OBJECT_ID ('LOS_BORBOTONES.Funcionalidad', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Funcionalidad;  
GO

Create table LOS_BORBOTONES.Funcionalidad
(Func_Id int IDENTITY,
Func_Nombre nvarchar(255)
);

---

IF OBJECT_ID ('LOS_BORBOTONES.Carga', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Carga;  
GO
create table LOS_BORBOTONES.Carga
(Carga_Id int IDENTITY,
Cli_Dni numeric(18, 0),
Carga_Credito numeric(18, 2),
Carga_Fecha datetime,
Tipo_Pago_Id int, 
Datos_Tarjeta nvarchar(255)
);

---

IF OBJECT_ID ('LOS_BORBOTONES.TipoDePago', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.TipoDePago;  
GO

create table LOS_BORBOTONES.TipoDePago
(Tipo_Pago_Id int IDENTITY,
Tipo_Pago_Desc nvarchar(100)
);

---

IF OBJECT_ID ('LOS_BORBOTONES.Cupon', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Cupon;  
GO

create table LOS_BORBOTONES.Cupon
(Cupon_Id int IDENTITY,
Oferta_Codigo nvarchar(50),
Cli_Dni numeric(18, 0),
Cli_Dest_Nombre nvarchar(255),
Cli_Dest_Apellido nvarchar(255),
Cli_Dest_Dni numeric(18, 0),
Cli_Dest_Direccion nvarchar(255),
Cli_Dest_Telefono numeric(18, 0),
Cli_Dest_Mail nvarchar(255),
Cli_Dest_Fecha_Nac datetime,
Cli_Dest_Ciudad nvarchar(255),
Oferta_Fecha_Compra datetime,
Oferta_Entregado_Fecha datetime,
Oferta_Fecha_Venc datetime,
Factura_Nro numeric(18, 0)
);

---

IF OBJECT_ID ('LOS_BORBOTONES.Factura', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Factura;  
GO

create table LOS_BORBOTONES.Factura
(Factura_Nro numeric(18, 0),
Factura_Fecha datetime,
Factura_Importe numeric(18, 2)
);

---

IF OBJECT_ID ('LOS_BORBOTONES.Oferta', 'U') IS NOT NULL  
   DROP TABLE LOS_BORBOTONES.Oferta;  
GO

create table LOS_BORBOTONES.Oferta
(Oferta_Codigo nvarchar(50),
Oferta_Precio numeric(18, 2),
Oferta_Precio_Ficticio numeric(18, 2),
Oferta_Fecha datetime,
Oferta_Fecha_Venc datetime,
Oferta_Cantidad numeric(18, 0),
Oferta_Descripcion nvarchar(255),
Provee_CUIT nvarchar(20)
)


/* *********** MIGRACIÓN DE DATOS ********* */

/*** Migracion tabla cliente ***/

insert into LOS_BORBOTONES.Cliente (Cli_Nombre, Cli_Apellido,Cli_Dni, Cli_Direccion, 
			Cli_Telefono, Cli_Mail, Cli_Fecha_Nac, Cli_Ciudad)
select distinct Cli_Nombre, Cli_Apellido, Cli_Dni, Cli_Direccion, Cli_Telefono, 
			Cli_Mail, Cli_Fecha_Nac, Cli_Ciudad
from gd_esquema.Maestra

/*** Migracion tabla role ***/

insert into LOS_BORBOTONES.Role (Rol_Nombre)
	values  ('Administrativo'), ('Cliente'), ('Proveerdor')

/*** Migracion tabla funcionalidad ***/

insert into LOS_BORBOTONES.Funcionalidad (Func_Nombre)
values ('Login y seguridad'), ('ABM de Rol'), ('Registro de Usuario'), ('ABM de Cliente'), ('ABM de Proveedor'), 
		('Cargar in'), ('Comprar Oferta'), ('Confeccion y publicacion de Ofertas'), ('Facturacion a Proveedor'), ('Listado Estadistico')

/*** Migracion tabla oferta ***/

insert into LOS_BORBOTONES.Oferta (Oferta_Codigo, Oferta_Precio, Oferta_Precio_Ficticio, 
			Oferta_Fecha, Oferta_Fecha_Venc, Oferta_Cantidad, Oferta_Descripcion, Provee_CUIT)
select distinct Oferta_Codigo ,Oferta_Precio, Oferta_Precio_Ficticio, Oferta_Fecha, 
			Oferta_Fecha_Venc, Oferta_Cantidad, Oferta_Descripcion, Provee_CUIT from gd_esquema.Maestra
			where Oferta_Codigo is not null 

/*** Migracion tipo de pago ***/

insert into LOS_BORBOTONES.TipoDePago (Tipo_Pago_Desc)
	select distinct Tipo_Pago_Desc from gd_esquema.Maestra
	where Tipo_Pago_Desc is not null

/*** Migracion Carga ***/

insert into LOS_BORBOTONES.Carga (Cli_Dni, Carga_Credito, Carga_Fecha, Tipo_Pago_Id)
	select Cli_Dni, Carga_Credito, Carga_Fecha, Tipo_Pago_Id 
		from gd_esquema.Maestra g join LOS_BORBOTONES.TipoDePago t 
		on (g.Tipo_Pago_Desc = t.Tipo_Pago_Desc)

/*** Migracion factura ***/

insert into LOS_BORBOTONES.Factura
	(Factura_Nro, Factura_Fecha, Factura_Importe)
	select Factura_Nro, Factura_Fecha, SUM(Oferta_Cantidad*Oferta_Precio) from gd_esquema.Maestra
	where Oferta_Fecha_Compra is not null AND Factura_Nro is not null
	group by Factura_Nro, Factura_Fecha
	order by Factura_Nro


/*** Migracion proveedores ***/

insert into LOS_BORBOTONES.Proveedor
	(Provee_RS, Provee_Dom, Provee_Ciudad, Provee_Telefono, Provee_CUIT,
		Provee_Rubro)
	select distinct Provee_RS, Provee_Dom, Provee_Ciudad, Provee_Telefono, Provee_CUIT,
		Provee_Rubro
		from gd_esquema.Maestra
		where Provee_RS is not null

/*** Migracion Cupones ***/

insert into LOS_BORBOTONES.Cupon (
	Oferta_Codigo, Cli_Dni, Cli_Dest_Nombre, Cli_Dest_Apellido, Cli_Dest_Dni,
		Cli_Dest_Direccion, Cli_Dest_Telefono, Cli_Dest_Mail, Cli_Dest_Fecha_Nac,
		Cli_Dest_Ciudad, Oferta_Fecha_Compra, Oferta_Entregado_Fecha, Oferta_Fecha_Venc,
		Factura_Nro
		
	)
	Select 
		Oferta_Codigo, Cli_Dni, Cli_Dest_Nombre, Cli_Dest_Apellido, Cli_Dest_Dni,
		Cli_Dest_Direccion, Cli_Dest_Telefono, Cli_Dest_Mail, Cli_Dest_Fecha_Nac,
		Cli_Dest_Ciudad, Oferta_Fecha_Compra, Oferta_Entregado_Fecha, Oferta_Fecha_Venc, 
		Factura_Nro
		from gd_esquema.Maestra
		where Oferta_Codigo is not null;


/*** Creacion de Constrain ***/
/*
Cliente
	Proveedor
	Usuario
	Rol_Usuario
	Role
	Func_Rol
	Funcionalidad
	Carga
	TipoDePago
	Cupon
	Factura
	Oferta


ALTER TABLE LOS_BORBOTONES.
ADD CONSTRAINT PK_
PRIMARY KEY ();

ALTER TABLE LOS_BORBOTONES
ADD CONSTRAINT FK_
FOREIGN KEY (PersonID) REFERENCES Persons(PersonID);

*/

USE GD2C2019
SELECT * FROM LOS_BORBOTONES.Proveedor;

ALTER TABLE LOS_BORBOTONES.Proveedor
	ADD CONSTRAINT PK_Proveedor
	PRIMARY KEY (Provee_CUIT);

ALTER TABLE LOS_BORBOTONES.Usuario
ADD CONSTRAINT PK_Usuario
PRIMARY KEY (User_name);

ALTER TABLE LOS_BORBOTONES.Rol_Usuario
ADD CONSTRAINT PK_Rol_Usuario
PRIMARY KEY (User_name, Rol_Id);

ALTER TABLE LOS_BORBOTONES.
ADD CONSTRAINT PK_
PRIMARY KEY ();
