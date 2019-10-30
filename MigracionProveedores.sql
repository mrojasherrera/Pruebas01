/*
Migracion proveedores
version: 1.0
fecha 2019-10-26
*/
use GD2C2019


insert into LOS_BORBOTONES.Proveedor
	(Provee_RS, Provee_Dom, Provee_Ciudad, Provee_Telefono, Provee_CUIT,
		Provee_Rubro)
	select distinct Provee_RS, Provee_Dom, Provee_Ciudad, Provee_Telefono, Provee_CUIT,
		Provee_Rubro
		from gd_esquema.Maestra
		where Provee_RS is not null

--
