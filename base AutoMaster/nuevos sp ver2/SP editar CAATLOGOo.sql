use AUTOMASTER
go


CREATE OR ALTER PROCEDURE SP_Cls_Catalogos_Editar
(
    @Id_Catalogo INT,
    @Id_Tipo_Catalogo INT,
    @Codigo VARCHAR(50),
    @Catalogo VARCHAR(80),
    @Activo BIT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            UPDATE Cls_Catalogos
            SET Id_Tipo_Catalogo = @Id_Tipo_Catalogo,
                Codigo = @Codigo,
                Catalogo = @Catalogo,
                Activo = @Activo,
                Fecha_Modificacion = SYSDATETIME()
            WHERE Id_Catalogo = @Id_Catalogo
        COMMIT
        print ' se ha actaulizado '
    END TRY
    BEGIN CATCH
        
        PRINT 'NO SE HA MODIFICADO'+@@ERROR
    END CATCH
END
GO

EXEC SP_Cls_Catalogos_Editar 
    @Id_Catalogo = 29,
    @Id_Tipo_Catalogo = 1,
    @Codigo = 'TEST01',
    @Catalogo = '  Prueba hola',
    @Activo = 0;

	select * from Cls_Catalogos
	EXEC SP_Cls_Catalogos_Listar