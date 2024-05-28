--Insertar
insert into Administrador (Nombre, Usuario, Clave, Estado) 
values('Abraham', 'sa', HASHBYTES('SHA2_256','strangerspeed.'), '1')
go

--Procedimiento Login Administrador
create proc administrador_login
@usuario varchar(50),
@clave varchar(50)
as
select Id_Admin, Nombre, Estado
from Administrador
where Usuario=@usuario and Clave=HASHBYTES('SHA2_256',@clave)
go

SELECT*FROM Administrador
