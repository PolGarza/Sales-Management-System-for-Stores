
--Triggers

--Trigger para reducir el stock 

CREATE TRIGGER venta_actualizarstock
on Detalle_Venta
FOR INSERT
as
UPDATE p set p.stock=p.stock-d.Cantidad
FROM Producto as p INNER JOIN
INSERTED as d on d.Id_Producto=p.Id_Producto
go