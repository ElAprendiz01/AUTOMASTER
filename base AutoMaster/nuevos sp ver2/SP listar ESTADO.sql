USE AUTOMASTER;
GO



CREATE PROCEDURE dbo.SP_ListarEstados
AS
BEGIN
    SET NOCOUNT ON;

    BEGIN TRY
        SELECT
            Id_Estado,
            Estado,
            Fecha_Creacion,
            Fecha_Modificacion,
            Activo
        FROM dbo.Cls_Estados
        ORDER BY Id_Estado;
    END TRY
    BEGIN CATCH
      print ' no se ha podido listar ' 
    END CATCH
END;
GO

-- Ejemplo de ejecución
EXEC dbo.SP_ListarEstados;
GO