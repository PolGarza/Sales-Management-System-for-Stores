--PROCEDIMIENTOS PARA COMPRAS 

--Procedimiento Listar productos
create proc producto_listar
as
select a.Id_Producto as ID,a.Id_Departamento,c.nombre as Nombre_Producto,a.Nombre_prodcuto as Nombre,
a.Precio_producto as Precio_Producto, a.Costo_producto as costo_Producto,
a.stock as Stock,a.descripcion as Descripcion, a.Unidad_Medida as Unidad_M,
a.estado as Estado, a.Devolucion as devolucion, a.Fecha_Producto as fecha_p
from Producto a inner join Departamento c on a.Id_Departamento=c.Id_Departamento

order by a.Id_Departamento desc
go

--Procedimiento Buscar productos 

create proc producto_buscar
@valor varchar(50)
as
select a.Id_Producto as ID,a.Id_Departamento,c.nombre as Nombre_Producto,
a.Nombre_prodcuto as Nombre,a.Precio_producto as Precio_Producto, a.Costo_producto as costo_Producto,
a.stock as Stock,a.descripcion as Descripcion, a.Unidad_Medida as Unidad_M,a.estado as Estado,
a.Devolucion	as devolucion, a.Fecha_Producto as fecha_p
from Producto a inner join Departamento c on a.Id_Departamento=c.Id_Departamento
where a.Nombre_prodcuto like '%' +@valor + '%' Or a.Id_Producto like '%' +@valor + '%'
order by a.Nombre_prodcuto asc
go


--Procedimiento Buscar Insertar

create proc producto_insertar
@id_dep  integer,
@nombre varchar(100),
@precio_venta decimal(11,4),
@Costo_producto	decimal(11,4),
@stock integer,
@descripcion varchar(255),
@Unidad_Medida varchar(20),
@Devolucion	varchar(20) 
 
as
DECLARE @Id_Admin integer  
SET @Id_Admin= (SELECT TOP 1 Id_Admin FROM Administrador )


DECLARE @Return bit;

SET @Return = CASE
WHEN @Devolucion = 'Si' THEN 1
WHEN @Devolucion = 'No' THEN 0
ELSE NULL
END;


insert into Producto(Id_Departamento,Nombre_prodcuto,Precio_producto,
Costo_producto,stock,descripcion, Id_Admin,Unidad_Medida, Fecha_Producto,Devolucion)
values (@id_dep,@nombre,@precio_venta,@Costo_producto,@stock,
@descripcion, @Id_Admin, @Unidad_Medida, CURRENT_TIMESTAMP,@Return )
go



SELECT *FROM Producto

--Procedimiento Actualizar productos
create proc productos_actualizar
@id_product integer,
@id_dep  integer,
@nombre varchar(100),
@precio_venta decimal(11,2),
@Costo_producto	decimal(11,4),
@Restock integer
@stock integer,
@descripcion varchar(255),
@Unidad_Medida varchar(20),
@Devolucion	varchar(20) 
as

DECLARE @Return bit;

SET @Return = CASE
WHEN @Devolucion = 'Si' THEN 1
WHEN @Devolucion = 'No' THEN 0
ELSE NULL
END;

update Producto set Id_Departamento=@id_dep,Nombre_prodcuto= @nombre,
Precio_producto=@precio_venta,Costo_producto=@Costo_producto,stock=@stock,Restock=@Restock,
descripcion=@descripcion, Unidad_Medida=@Unidad_Medida,
Devolucion= @Return

where Id_Producto=@id_product;
go

---ACTUALIZAR PRODUCTOS----------------------------------------------------------
create proc productos_actualizar
@id_product integer,
@id_dep  integer,
@nombre varchar(100),
@precio_venta decimal(11,4),
@Costo_producto	decimal(11,4),
@stock integer,
@descripcion varchar(255),
@Unidad_Medida varchar(20),
@Devolucion	varchar(20) 
 
as
DECLARE @Id_Admin integer  
SET @Id_Admin= (SELECT TOP 1 Id_Admin FROM Administrador )


DECLARE @Return bit;

SET @Return = CASE
WHEN @Devolucion = 'Si' THEN 1
WHEN @Devolucion = 'No' THEN 0
ELSE NULL
END;

update Producto SET Id_Departamento=@id_dep, Nombre_prodcuto=@nombre,Precio_producto=@precio_venta ,
Costo_producto=@Costo_producto,stock=@stock,descripcion=@descripcion, 
Id_Admin=@Id_Admin,Unidad_Medida=Unidad_Medida,Devolucion=@Return

where Id_Producto=@id_product;
go

alter table  Producto add fecha_actualizar DATETIME

-------------------------------------------------------------------------------


SELECT *FROM Administrador

--Procedimiento Eliminar productos
create proc producto_eliminar
@id_product integer
as
delete from Producto
where Id_Producto=@id_product
go

--Procedimiento Desactivar productos
create proc producto_desactivar
@idproducDes integer
as
update Producto set estado=0
where Id_Producto=@idproducDes
go

--Procedimiento Activar
create proc producto_activar
@idproducAct integer
as
update Producto set estado=1
where Id_Producto=@idproducAct
go

-- Procedimiento existe producto
create proc producto_existe
@valor int,
@existe bit output
as
if exists (select Id_Producto from Producto where Id_Producto = (@valor))
	begin
		set @existe=1
	
	end
else
	begin
		set @existe=0
	
	end
go

DROP PROCEDURE producto_existe



EXEC producto_existe 'Tomate',1
EXEC producto_existe 'Cebolla',1

CREATE PROC producto_seleccionar_departamento
as
SELECT Id_Departamento, Nombre from Departamento
where Estado=1
go




