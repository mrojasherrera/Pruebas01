/***Migracion tabla cliente***/
insert into LOS_BORBOTONES.Cliente (Cli_Nombre, Cli_Apellido,Cli_Dni, Cli_Direccion, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac, Cli_Ciudad)
select distinct Cli_Nombre, Cli_Apellido, Cli_Dni, Cli_Direccion, Cli_Telefono, Cli_Mail, Cli_Fecha_Nac, Cli_Ciudad
from gd_esquema.Maestra

select * from gd_esquema.Maestra

/***Migracion tabla role***/
insert into LOS_BORBOTONES.Role (Rol_Nombre)
values  ('Administrativo'), ('Cliente'), ('Proveerdor')

/***Migracion tabla funcionalidad***/
insert into LOS_BORBOTONES.Funcionalidad (Func_Nombre)
values ('Login y seguridad'), ('ABM de Rol'), ('Registro de Usuario'), ('ABM de Cliente'), ('ABM de Proveedor'), 
		('Cargar in'), ('Comprar Oferta'), ('Confeccion y publicacion de Ofertas'), ('Facturacion a Proveedor'), ('Listado Estadistico')

/***Migracion tabla oferta***/
insert into LOS_BORBOTONES.Oferta (Oferta_Codigo, Oferta_Precio, Oferta_Precio_Ficticio, Oferta_Fecha, Oferta_Fecha_Venc, Oferta_Cantidad, Oferta_Descripcion, Provee_CUIT)
select distinct Oferta_Codigo ,Oferta_Precio, Oferta_Precio_Ficticio, Oferta_Fecha, Oferta_Fecha_Venc, Oferta_Cantidad, Oferta_Descripcion, Provee_CUIT from gd_esquema.Maestra
where Oferta_Codigo is not null 

/***Migracion tipo de pago ***/
insert into LOS_BORBOTONES.TipoDePago (Tipo_Pago_Desc)
select distinct Tipo_Pago_Desc from gd_esquema.Maestra
where Tipo_Pago_Desc is not null

/***Migracion Carga***/

insert into LOS_BORBOTONES.Carga (Cli_Dni, Carga_Credito, Carga_Fecha, Tipo_Pago_Id)
select Cli_Dni, Carga_Credito, Carga_Fecha, Tipo_Pago_Id 
from gd_esquema.Maestra g join LOS_BORBOTONES.TipoDePago t on (g.Tipo_Pago_Desc = t.Tipo_Pago_Desc)

/***Migracion factura***/

insert into LOS_BORBOTONES.Factura
(Factura_Nro, Factura_Fecha, Factura_Importe)
select Factura_Nro, Factura_Fecha, SUM(Oferta_Cantidad*Oferta_Precio) from gd_esquema.Maestra
where Oferta_Fecha_Compra is not null AND Factura_Nro is not null
group by Factura_Nro, Factura_Fecha
order by Factura_Nro
