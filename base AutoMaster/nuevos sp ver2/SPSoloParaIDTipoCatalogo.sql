USE AUTOMASTER;
GO

CREATE OR ALTER PROCEDURE SP_idyTipoCat
AS
BEGIN
    BEGIN TRY
        SELECT        
            tipoCat.Tipo_Catalogo, 
			tipoCat.Id_Tipo_Catalogo,
            tipoCat.Activo
        FROM Cls_Tipo_Catalogos AS tipoCat
    END TRY
    BEGIN CATCH
        PRINT 'no se ha podido listar los catalogos '
    END CATCH
END
GO
exec SP_idyTipoCat