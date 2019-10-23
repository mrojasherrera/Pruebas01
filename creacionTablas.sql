select * from gd_esquema.Maestra

if exist(Clinte)
drop cliente



create table Cliente
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

create table Proveedor
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

create table Usuario
(User_name nvarchar(50),
Password nvarchar(32),
Habilitado bit DEFAULT(1),
Cant_Log_Fallidos tinyint
);

create table Rol_Usuario
(User_name nvarchar(50),
Rol_Id INT
);

create table Role
(Rol_Id  int IDENTITY,
Rol_Nombre nvarchar(255)
);

Create table Func_Rol
(Rol_Id int,
Func_Id int
);

Create table Funcionalidad
(Func_Id int IDENTITY,
Func_Nombre nvarchar(255)
);

create table Carga
(Carga_Id int IDENTITY,
Cli_Dni numeric(18, 0),
Carga_Credito numeric(18, 2),
Carga_Fecha datetime,
Tipo_Pago_Id int, 
Datos_Tarjeta nvarchar(255)
);

create table TipoDePago
(Tipo_Pago_Id int IDENTITY,
Tipo_Pago_Desc nvarchar(100)
);

create table Cupon
(Cupo_Id int IDENTITY,
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
Cupon_Fecha_Vto datetime,
Factura_Nro numeric(18, 0)
);

create table Factura
(Factura_Nro numeric(18, 0),
Factura_Fecha datetime,
Factura_Importe numeric(18, 2)
);

create table Oferta
(Oferta_Codigo nvarchar(50),
Oferta_Precio numeric(18, 2),
Oferta_PrecioFicticio numeric(18, 2),
Oferta_Fecha datetime,
Oferta_Fecha_Venc datetime,
Oferta_Cantidad numeric(18, 0),
Oferta_Descripcion nvarchar(255),
Provee_CUIT nvarchar(20)
)
