/***Migracion tabla cliente***/
insert into LOS_BORBOTONES.Cliente (Cli_Nombre, Cli_Apellido,Cli_Dni, Cli_Direccion, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac, Cli_Ciudad)
select distinct Cli_Nombre, Cli_Apellido, Cli_Dni, Cli_Direccion, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac, Cli_Ciudad
from gd_esquema.Maestra

select * from gd_esquema.Maestra

/***Migracion tabla role***/
insert into LOS_BORBOTONES.Role (Rol_Nombre)
values  ('Administrativo'), ('Cliente'), ('Proveerdor')

select * from LOS_BORBOTONES.Role

/***Migracion tabla funcionalidad***/
insert into LOS_BORBOTONES.Funcionalidad (Func_Nombre)
values ('Login y seguridad'), ('ABM de Rol'), ('Registro de Usuario'), ('ABM de Cliente'), ('ABM de Proveedor'), 
		('Cargar in'), ('Comprar Oferta'), ('Confeccion y publicacion de Ofertas'), ('Facturacion a Proveedor'), ('Listado Estadistico')

select * from LOS_BORBOTONES.Funcionalidad

/***Migracion tabla oferta***/--faltaria joinear con tabla proveedor para asociar la oferta con proveedor
insert into LOS_BORBOTONES.Oferta (Oferta_Codigo, Oferta_Precio, Oferta_Precio_Ficticio, Oferta_Fecha, Oferta_Fecha_Venc, Oferta_Cantidad, Oferta_Descripcion)
select distinct Oferta_Codigo ,Oferta_Precio, Oferta_Precio_Ficticio, Oferta_Fecha, Oferta_Fecha_Venc, Oferta_Cantidad, Oferta_Descripcion from gd_esquema.Maestra
where Oferta_Codigo is not null 

select * from LOS_BORBOTONES.Oferta
select * from gd_esquema.Maestra
where Oferta_Codigo is not null
