USE [NORTHWND]
GO
/****** Object:  StoredProcedure [dbo].[Agregar_Producto]    Script Date: 21/08/2023 23:25:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Agregar_Producto]
    @OrderID INT,
    @ProductID INT
AS
BEGIN
    DECLARE @UnitPrice MONEY
    DECLARE @Quantity INT
    DECLARE @Discount FLOAT

    SELECT
        @UnitPrice = UnitPrice,
        @Quantity = UnitsInStock,
        @Discount = CASE WHEN Discontinued = 1 THEN 1 ELSE 0 END
    FROM dbo.Products
    WHERE ProductID = @ProductID;

    INSERT INTO dbo.[Order Details] (OrderID, ProductID, UnitPrice, Quantity, Discount)
    VALUES (@OrderID, @ProductID, @UnitPrice, @Quantity, @Discount);
END;
GO
/****** Object:  StoredProcedure [dbo].[Consulta_Orden]    Script Date: 21/08/2023 23:25:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Consulta_Orden]
AS
BEGIN
    SELECT
        OrderID AS Nro,
        CustomerID AS Cliente,
        OrderDate AS FechaOrden,
        ShippedDate AS FechaTransporte,
        Freight AS Carga
    FROM dbo.Orders;
END;
GO
/****** Object:  StoredProcedure [dbo].[Detalle_Orden]    Script Date: 21/08/2023 23:25:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Detalle_Orden]
    @OrderID INT
AS
BEGIN
    SELECT
        od.OrderID AS Nro,
        p.ProductName AS Producto,
        p.ProductID AS IdProducto,
        od.UnitPrice AS Precio,
        od.Quantity AS Cantidad
    FROM dbo.[Order Details] od
    INNER JOIN dbo.Products p ON od.ProductID = p.ProductID
    WHERE od.OrderID = @OrderID AND od.Discount > 0;
END;
GO
/****** Object:  StoredProcedure [dbo].[Lista_Productos]    Script Date: 21/08/2023 23:25:08 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Lista_Productos]
AS
BEGIN
    SELECT DISTINCT
        od.ProductID,
        p.ProductName AS Producto
    FROM dbo.[Order Details] od
    INNER JOIN dbo.Products p ON od.ProductID = p.ProductID
    ORDER BY p.ProductName ASC;
END;
GO
