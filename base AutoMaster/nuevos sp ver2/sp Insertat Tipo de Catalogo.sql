USE AUTOMASTER;
GO

CREATE OR ALTER PROCEDURE SP_Cls_Tipo_Catalogos_Insertar
(
   @Codigo VARCHAR(50),
   @Tipo_Catalogo VARCHAR(80),
   @Activo BIT 
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            INSERT INTO Cls_Tipo_Catalogos(
                                    Codigo,
                                    Tipo_Catalogo,
                                    Activo
                                    )
            VALUES (
                    @Codigo,
                    @Tipo_Catalogo,
                    @Activo
                    )
        COMMIT
        PRINT 'SE HA INSERTADO EL TIPO DE CATALOGO'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'no se ha insertado ' + @@error
    END CATCH
END
GO
select * from Cls_Tipo_Catalogos

exec SP_Cls_Tipo_Catalogos_Insertar 'prueb', 'puerab07', 0