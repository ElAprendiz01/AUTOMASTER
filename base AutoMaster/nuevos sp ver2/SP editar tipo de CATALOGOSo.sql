USE AUTOMASTER;
GO

CREATE OR ALTER PROCEDURE SP_Cls_Tipo_Catalogos_Editar
(
    @Id_Tipo_Catalogo INT,
    @Codigo VARCHAR(50),
    @Tipo_Catalogo VARCHAR(80),
    @Activo BIT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            UPDATE Cls_Tipo_Catalogos
            SET Codigo = @Codigo,
                Tipo_Catalogo = @Tipo_Catalogo,
                Activo = @Activo,
                Fecha_Modificacion = SYSDATETIME() 
            WHERE Id_Tipo_Catalogo = @Id_Tipo_Catalogo
        COMMIT
        PRINT 'SE HA MODIFICADO EL TIPO DE CATALOGO'
    END TRY
    BEGIN CATCH
       
        PRINT 'NO SE HA MODIFICADO'+@@ERROR
    END CATCH
END
GO