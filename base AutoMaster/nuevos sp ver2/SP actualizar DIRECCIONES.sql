USE AUTOMASTER
GO 
CREATE OR ALTER PROCEDURE SPactualizarDirecciones
(
	@Id_Direccion INT,
	 @Id_Persona INT,
	 @Direccion VARCHAR(300),
	 @Ciudad VARCHAR(100),
	 @Departamento VARCHAR(100),
	 @Principal BIT ,
	 @Id_Estado INT
)
as 
BEGIN
	SET NOCOUNT ON ;
	BEGIN TRY 
		BEGIN TRAN
				UPDATE Tbl_Direcciones
				SET Id_Persona =@Id_Persona,
				Direccion=@Direccion,
				Ciudad=@Ciudad,
				Departamento=@Departamento,
				Principal=@Principal, 
				Fecha_Modificacion = SYSUTCDATETIME(),
			    Id_Estado= @Id_Estado
				WHERE Id_Direccion= @Id_Direccion
			COMMIT 
				PRINT 'SE HA ACTUALIZADO CORRECTAMENTE '
			END TRY 
			BEGIN CATCH 
			ROLLBACK 
				PRINT ' NO SE HA PODIDO ACTUALIZAR'
			END CATCH
			
END
GO 

EXEC SPactualizarDirecciones 1, 1003, 'lAS JAGUAI','MANAGUA','MANAGU', 0,1

SELECT * FROM Tbl_Direcciones