--Procedimiento Venta_Toal (Usar este)
CREATE PROCEDURE reporte_venta_total_imprimir
AS
BEGIN
SELECT 
	
	v.Id_Cajero,
	c.Nombre AS Cajero,
	v.Caja_Num AS Caja,
	e.Producto1 AS Nombre,
	SUM(e.Cantidad) AS UnidadesVendidas,
	SUM(e.Precio) AS SumaVenta,
	e.Producto1 AS Producto,
	e.Unidad_Medida AS UnidadMedida,
	e.Devolucion AS Devolucion
FROM Venta v 
INNER JOIN Detalle_Venta e ON v.Id_Venta = e.Id_Venta
INNER JOIN Cajero c ON v.Id_Cajero = c.Id_Cajero
GROUP BY	v.Caja_Num,e.Producto1 , v.Id_Cajero, c.Nombre, e.Producto1, e.Unidad_Medida, 
e.Devolucion
END;

--Procedimiento Venta_Fecha
CREATE PROCEDURE reporte_venta_fecha_imprimir
AS
BEGIN
SELECT 
	v.Id_Cajero,
	c.Nombre AS Cajero,
	v.Caja_Num AS Caja,
	e.Producto1 AS Nombre,
	SUM(e.Cantidad) AS UnidadesVendidas,
	SUM(e.Precio) AS SumaVenta,
	v.Fecha, 
	e.Producto1 AS Producto,
	e.Unidad_Medida AS UnidadMedida,
	e.Devolucion AS Devolucion

FROM Venta v INNER JOIN Detalle_Venta e ON v.Id_Venta = e.Id_Venta
INNER JOIN Cajero c ON v.Id_Cajero = c.Id_Cajero
GROUP BY   e.Producto1 , v.Id_Cajero, v.Fecha, v.Caja_Num,  c.Nombre, e.Producto1, 
e.Unidad_Medida, e.Devolucion
END;

--Procedimiento Producto_Total (usar este)
CREATE PROCEDURE reporte_producto_total_imprimir
AS
BEGIN
SELECT 
	p.Id_Producto,
	p.Nombre_prodcuto AS Nombre,
	d.Nombre AS Departamento,
	SUM(p.stock) AS Unidades,
	SUM(p.Precio_producto) AS Precio_Total,
	d.Id_Departamento,
	p.Devolucion AS Devolucion,
	p.estado AS Estado,
	p.Unidad_Medida
FROM Producto p 
INNER JOIN Departamento d ON p.Id_Departamento = d.Id_Departamento
GROUP BY  p.Id_Producto, p.Nombre_prodcuto, p.stock, p.Precio_producto, d.Id_Departamento, p.estado, 
p.Unidad_Medida, p.Devolucion, d.Nombre 
END;

--Procedimiento Cajero_Total (usar este)
CREATE PROCEDURE reporte_cajero_imprimir
AS
BEGIN
SELECT 
     Id_Cajero,
	 Nombre,
	 CURP,		
	 Email AS Usuario,
	 Fecha_Nam,	 
	 Fecha_Ingreso,
	 Estado		
FROM Cajero 
GROUP BY Id_Cajero, Nombre, CURP, Email, Fecha_Nam, Fecha_Ingreso, Estado
END;

--Procedimiento Venta_Fecha (Usar este)
CREATE PROCEDURE Reporte_Venta_Fechas
AS
BEGIN
SELECT 
 
     E.Producto1 AS Nombre,
	 E.IdDetalle_Venta	AS ID
	,SUM(E.Cantidad) AS UnidadesVendidas
	,SUM(E.Precio) AS SumaVenta,
	A.Id_Venta,
	A.Fecha

FROM Venta A INNER JOIN Detalle_Venta E ON A.Id_Venta = E.Id_Venta
GROUP BY   E.Producto1 ,E.IdDetalle_Venta,	A.Id_Venta,	A.Fecha
END;

--Procedimiento Venta_Toal (Usar este)
CREATE PROCEDURE Reporte_Venta_Total
AS
BEGIN
SELECT 
 
     E.Producto1 AS Nombre

	,SUM(E.Cantidad) AS UnidadesVendidas
	,SUM(E.Precio) AS SumaVenta,
	A.Id_Cajero


FROM Venta A INNER JOIN Detalle_Venta E ON A.Id_Venta = E.Id_Venta
GROUP BY   E.Producto1 , A.Id_Cajero
END;