USE AUTOMASTER
GO 
CREATE OR ALTER PROCEDURE SPActualizarProveedores
(	@Id_Proveedor INT,
	 @Representante INT ,
	 @Nombre_Empresa VARCHAR(150),
	 @RUC_Empresa VARCHAR(50),
	 @Id_Estado INT 

)
AS 
BEGIN 
	SET NOCOUNT ON;
		BEGIN TRY 
			BEGIN TRAN
				UPDATE Tbl_Proveedores 
				SET Representante= @Representante,
				Nombre_Empresa= @Nombre_Empresa,
				RUC_Empresa = @RUC_Empresa,
				Id_Estado= @Id_Estado 
				WHERE Id_Proveedor = @Id_Proveedor
			commit 
				PRINT' SE HA ACTUALIZAR CORRECTAMENTE '
		END TRY 
		BEGIN CATCH 
			ROLLBACK
			PRINT ' NO SE HA PODIDO ACTUALIZAR' + @@ERROR 
		END CATCH
END 
GO 

EXEC  SPActualizarProveedores 1, 1002, 'AUTOS MAGICOS  SA', '0226558D', 1 

SELECT * FROM Tbl_Proveedores