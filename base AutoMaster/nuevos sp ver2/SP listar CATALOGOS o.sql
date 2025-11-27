USE AUTOMASTER;
GO

CREATE OR ALTER PROCEDURE SP_Cls_Catalogos_Listar
AS
BEGIN
	SET NOCOUNT ON;
    BEGIN TRY
        SELECT 
            cat.Id_Catalogo,          
            tc.Tipo_Catalogo, 
			tc.Id_Tipo_Catalogo,
            cat.Codigo, 
            cat.Catalogo,              
            cat.Fecha_Creacion, 
            cat.Fecha_Modificacion, 
            cat.Activo
        FROM Cls_Catalogos AS cat
        INNER JOIN Cls_Tipo_Catalogos AS tc ON cat.Id_Tipo_Catalogo = tc.Id_Tipo_Catalogo

    END TRY
    BEGIN CATCH
        PRINT 'no se ha podido listar los catalogos '
    END CATCH
END
GO
exec SP_Cls_Catalogos_Listar