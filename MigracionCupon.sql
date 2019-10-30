/*
Migración cupones
Version V1.0
fecha: 2019-10-26
*/
use GD2C2019


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

