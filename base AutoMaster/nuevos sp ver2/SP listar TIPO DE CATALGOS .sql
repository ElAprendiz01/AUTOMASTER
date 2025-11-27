USE AUTOMASTER;
GO

CREATE OR ALTER PROCEDURE SP_Cls_Tipo_Catalogos_Listar
AS
BEGIN
    BEGIN TRY
        SELECT 
            TC.Id_Tipo_Catalogo, 
            TC.Codigo, 
            TC.Tipo_Catalogo, 
            TC.Fecha_Creacion, 
            TC.Fecha_Modificacion, 
            TC.Activo
        FROM Cls_Tipo_Catalogos AS TC
    END TRY
    BEGIN CATCH
        PRINT 'no se ha podido listar los tipos de catalogo '
    END CATCH
END
GO

exec SP_Cls_Tipo_Catalogos_Listar