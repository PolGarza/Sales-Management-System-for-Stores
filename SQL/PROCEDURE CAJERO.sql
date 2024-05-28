--Procedimiento Listar
create proc cajero_listar
as
select Id_Cajero as ID, Nombre as NombreCajero, CURP as CURP, Email as EmailCajero, Fecha_Nam as FechaNam, 
Fecha_Ingreso as FechaIngr, Estado as EstadoCajero
from Cajero
order by Id_Cajero desc
go

--Procedimiento Buscar
create proc cajero_buscar
@fecha_inicial datetime, 
@fecha_final datetime,
@valor		varchar
as
select Id_Cajero as ID, Nombre as NombreCajero, CURP as CURP, Email as EmailCajero, Fecha_Nam as FechaNam, 
Fecha_Ingreso as FechaIngr, Estado as EstadoCajero
from Cajero
where Fecha_Ingreso >= @fecha_inicial and Fecha_Ingreso <= @fecha_final Or Nombre like '%'+ @valor + '%' Or Id_Cajero like '%'+ @valor + '%'
order by Nombre asc
go

exec cajero_buscar '2023-04-01', '2023-04-28' , 'j'

--Procedimiento Insertar
create proc cajero_insertar
@Nombre varchar(30),
@CURP varchar(18),
@Email varchar(50),
@Clave varchar(50),
@FechaNam date
as
insert into Cajero (Nombre, CURP, Email, Clave, Fecha_Nam, Fecha_Ingreso) 
values(@Nombre, @CURP, @Email, HASHBYTES('SHA2_256',@Clave), @FechaNam, CURRENT_TIMESTAMP)
go

--Procedimiento Actualizar
create proc cajero_actualizar
@Id_Cajero int = 0, 
@Nombre varchar(30),
@CURP varchar(18),
@Email varchar(50),
@Clave varchar(50),
@FechaNam date
as 
if @Clave<>''
update Cajero set Nombre=@Nombre, CURP=@CURP, Email=@Email, Clave=HASHBYTES('SHA2_256',@Clave), Fecha_Nam=@FechaNam
where Id_Cajero=@Id_Cajero;
else
update Cajero set Nombre=@Nombre, CURP=@CURP, Email=@Email, Fecha_Nam=@FechaNam
where Id_Cajero=@Id_Cajero;
go

--Procedimiento Eliminar
create proc cajero_eliminar
@Id_Cajero int
as
delete from Cajero
where Id_Cajero= @Id_Cajero
go

--Procedimiento Desactivar 
create proc cajero_desactivar
@Id_Cajero int
as
update Cajero set Estado=0
where Id_Cajero=@Id_Cajero
go

--Procedimiento Activar 
create proc cajero_activar
@Id_Cajero int
as
update Cajero set Estado=1
where Id_Cajero=@Id_Cajero
go

--Procedimiento Login Cajero
create proc cajero_login
@email varchar(50),
@clave varchar(50)
as
select Id_Cajero, Nombre, Estado
from Cajero
where Email=@email and Clave=HASHBYTES('SHA2_256',@clave)
go