---Vistas 

    --Vista para Ver Ventas 

CREATE VIEW dbo.Ventas_Listado
AS
SELECT
    Id_Venta,
    Id_Cajero,
    Caja_Num,
    Fecha,
    Total,
    codigo_venta
FROM
    Venta;


SELECT * FROM Ventas_Listado;

CREATE VIEW dbo.Ventas_Listado_Merma
AS
SELECT
    Id_Venta,
	Importe,
	Unidad_Medida,
	Tipo_Dev     
FROM
    Devolucion;

SELECT * FROM Ventas_Listado_Merma;


--Vista para Ver Cajeros 
CREATE VIEW Cajero_view
AS
SELECT
	Id_Cajero,
	Nombre,
	CURP,
	Email,
	Clave,
	Fecha_Nam,
	Fecha_Ingreso,
	Estado
FROM Cajero;