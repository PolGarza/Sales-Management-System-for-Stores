
--Procedimiento Listar
create proc departamento_listar
as
select Id_Departamento	 as ID, Nombre as nombre_Departamento, Estado as estado
from Departamento
order by Id_Departamento desc
go

--Procedimiento Buscar
create proc departamento_buscar
@valor  varchar(50)
as
select Id_Departamento as ID, Nombre as nombre_Departamento, Estado as estado
from Departamento
where nombre like '%'+ @valor + '%'
order by Nombre asc
go
--Procedimiento Insertar
create proc departamento_insertar
@Nombre varchar(30)
as
insert into Departamento (Nombre) values(@Nombre)
go
--Procedimiento Actualizar
create proc departamento_actualizar
@Id_Departamento int, 
@Nombre varchar(30)
as 
update Departamento set Nombre=@Nombre
where Id_Departamento=@Id_Departamento
go

--Procedimiento Eliminar
create proc departamento_eliminar
@Id_Departamento int
as
delete from Departamento
where Id_Departamento= @Id_Departamento
go

--Procedimiento Desactivar 
create proc departamento_desactivar
@Id_Departamento int
as
update Departamento set Estado=0
where Id_Departamento=@Id_Departamento
go

--Procedimiento Activar
create proc departamento_activar
@Id_Departamento int
as
update Departamento set Estado=1
where Id_Departamento=@Id_Departamento
go

--Procedimiento Seleccionar
create proc departamento_seleccionar
as
select Id_Departamento, Nombre from Departamento
where Estado=1
go

--Procedimiento Existe
create proc departamento_existe
@valor varchar(100),
@existe bit output
as
	if exists (select Nombre from Departamento where Nombre = ltrim(rtrim(@valor)))
		begin
		 set @existe=1
		end
	else
		begin
		 set @existe=0
		end