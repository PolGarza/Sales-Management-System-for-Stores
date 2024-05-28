
--Procedimiento Listar 
create proc venta_listar
as
select v.Id_Venta as ID, v.Id_Cajero,c.Nombre as Cajero,v.Tipo_Comprobante as TipoComprobante, v.Caja_Num as Numero_caja, v.Fecha as Fecha_venta, v.Descuento as Descuento_venta, 
v.Total as Total, v.Estado as Estado, v.codigo_venta as Codigo
from Venta v inner join Cajero c on v.Id_Cajero=c.Id_Cajero
ORDER BY v.codigo_venta DESC
go

EXEC venta_listar;

--Procedimiento Buscar
create proc venta_buscar
@valor varchar (50)
as
select v.Id_Venta as ID, v.codigo_venta as Codigo, v.Id_Cajero,c.Nombre as Cajero,v.Tipo_Comprobante as TipoComprobante, v.Caja_Num as Numero_caja, v.Fecha as Fecha_venta, v.Descuento as Descuento_venta, 
v.Total as Total, v.Estado as Estado 
from Venta v inner join Cajero c on v.Id_Cajero=c.Id_Cajero
where v.codigo_venta like '%' +@valor + '%' Or v.Fecha like '%' +@valor + '%'
order by v.codigo_venta desc
go


--Procedimiento Anular 

create proc venta_anular
@idventa int
as
update Venta set Estado='Anulado'
where Id_Venta=@idventa;
update Producto
set stock=stock+d.Cantidad
from Productop 
inner join
(select Id_Producto,Cantidad from Detalle_Venta where Id_Venta=@idventa)as d
on p.Id_Producto=d.Id_Producto;
go


--TIPO CREADO PARA PODER ELEGIR PRODUCTOS 
--Se usa para el datatable de c#
CREATE TYPE type_Detalle_Venta3 as table
(
	Id_Producto		Int,
	Producto		Varchar(100),
	Cantidad		Int,
	Precio			Decimal(11,2),
	Descuento		Decimal(11,2),
	Importe			Decimal(11,2), 
	UM	            varchar(20) null,
	Devolucion_p    Bit
);
go

--Procedimiento Insertar

create proc venta_insertar
@idcajero int,
@Caja_Num varchar(20),
@total decimal(11,2),
@detalle type_detalle_venta3 READONLY
as
begin
	insert into Venta(Id_Cajero, Caja_Num, Fecha,  
	Total, Estado)
	values (@idcajero,@Caja_Num  ,getdate(), @total,
	 'Aceptado');

	insert Detalle_Venta (Id_Venta, Id_Producto, Producto1, Cantidad, Precio, Importe, Unidad_Medida, Descuento, Devolucion)
	 select @@IDENTITY, d.Id_Producto, d.Producto, d.Cantidad,  d.Cantidad,d.Importe, d.UM,d.Descuento,d.Devolucion_p
	 from @detalle d;
end

--Procedimiento para buscar articulos

create proc articulo_buscar_venta
@valor varchar(50)
as
select Id_Producto, Nombre_prodcuto, Id_Departamento, 
Descripcion, Unidad_Medida, Precio_producto,
stock,estado, Devolucion,Fecha_Producto
from Producto
WHERE Id_Producto=@valor and stock>0
go

create proc producto_buscar_venta
@valor varchar(50)
as
select a.Id_Producto as ID,a.Id_Departamento,c.nombre as Categoria,a.Nombre_prodcuto as Nombre,a.Precio_producto as Precio_producto,
a.Unidad_Medida as Unidad,a.stock as Stock,a.descripcion as Descripcion,
a.estado as Estado, a.Devolucion as Devoucion
from Producto a inner join Departamento c on a.Id_Departamento=c.Id_Departamento
where (a.Nombre_prodcuto like '%' +@valor + '%' Or a.Id_Producto like '%' +@valor + '%')
and a.stock>0
order by a.Nombre_prodcuto asc
go

select *from Detalle_Venta

create proc producto_buscar_nombre
@valor varchar(50)
as
select Id_Producto,Nombre_prodcuto,Precio_producto,stock
from Producto
where Nombre_prodcuto=@valor
go


--DEVOLUCIONES

 --Listar las ventas que tengan devolucion (Tabla Detalle_Venta) 
CREATE PROCEDURE Devolucion_Ventas_Detalle
AS
BEGIN

SELECT
	IdDetalle_Venta,
	Id_Venta,
	Id_Producto,
	Producto1,
	Cantidad,
	Precio,
	Importe,
	Unidad_Medida,
	Descuento,
	Devolucion
FROM Detalle_Venta
WHERE Devolucion = 1;

END
GO


--Procemiento Devolver y eliminar Ventas 
create proc Devolucion_insertar
@Id_Venta int,
@Id_Producto INT,
@Producto1 varchar(7),
@Cantidad int,
@Precio decimal(4,2),
@Importe decimal(11,2),
@Unidad_Medida varchar(20),
@Tipo_Dev varchar(20)
as
begin
DELETE FROM Detalle_Venta 
WHERE Id_Venta=@Id_Venta;
	insert into Devolucion(Id_Venta, Id_Producto, Producto1, Cantidad, Precio, Importe, Unidad_Medida,Tipo_Dev)
	values (@Id_Venta, @Id_Producto, @Producto1, @Cantidad, @Precio, @Importe, @Unidad_Medida,@Tipo_Dev);
end