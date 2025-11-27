USE AUTOMASTER;
GO

CREATE OR ALTER PROCEDURE SP_Cls_Catalogos_Insertar
(
   @Id_Tipo_Catalogo INT,
   @Codigo VARCHAR(50),
   @Catalogo VARCHAR(80),
   @Activo BIT
)
AS
BEGIN
   SET NOCOUNT ON;
    BEGIN TRY
        BEGIN TRAN
            INSERT INTO Cls_Catalogos(
                                    Id_Tipo_Catalogo,
                                    Codigo,
                                    Catalogo,
                                    Activo
                                    )
            VALUES (
                    @Id_Tipo_Catalogo,
                    @Codigo,
                    @Catalogo,
                    @Activo
                    )
        COMMIT
        PRINT 'SE HA INSERTADO EL CATALOGO'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'no se ha insertado ' + @@error
    END CATCH
END
GO


EXEC SP_Cls_Catalogos_Insertar 
    @Id_Tipo_Catalogo = 1,
    @Codigo = 'TE01', 
    @Catalogo = ' de Prueba', 
    @Activo = 1;
