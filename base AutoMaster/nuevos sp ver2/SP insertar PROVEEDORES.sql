USE AUTOMASTER
GO

CREATE OR ALTER PROCEDURE SPInsertarProveedores
(
   @Representante INT,
   @Nombre_Empresa VARCHAR(150),
   @RUC_Empresa VARCHAR(50),
   @Id_Estado INT
)
AS
BEGIN
    BEGIN TRY
        BEGIN TRAN
            INSERT INTO Tbl_Proveedores(
                Representante,
                Nombre_Empresa,
                RUC_Empresa,
                Id_Estado
            )
            VALUES (
                @Representante,
                @Nombre_Empresa,
                @RUC_Empresa,
                @Id_Estado
            )
        COMMIT
        PRINT 'SE HA INSERTADO EL PROVEEDOR'
    END TRY
    BEGIN CATCH
        ROLLBACK
        PRINT 'NO SE HA INSERTADO ' + @@ERROR
    END CATCH
END
GO