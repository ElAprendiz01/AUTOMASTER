USE AUTOMASTER;
GO



CREATE OR ALTER PROCEDURE SP_Cls_Estados_Insertar
(
    @Estado VARCHAR(80),
    @Activo BIT = 1 
)
AS
BEGIN
    SET NOCOUNT ON; -- Evita mensajes de "1 fila afectada" para mejorar rendimiento de red

    BEGIN TRY
        BEGIN TRAN
            
            
            INSERT INTO Cls_Estados (Estado, Activo)
            VALUES (@Estado, @Activo);

        COMMIT TRAN;
       
    END TRY
    BEGIN CATCH
        ROLLBACK TRAN;
        PRINT('Error al insertar Estado' + @@error);
    END CATCH
END;
GO

EXEC SP_Cls_Estados_Insertar 
    @Estado = 'En Subasta', 
    @Activo = 1;

