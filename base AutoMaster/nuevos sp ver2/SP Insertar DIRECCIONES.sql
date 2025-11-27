USE AUTOMASTER
GO 
CREATE OR ALTER PROCEDURE SPinsertarDirecciones
(
	
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
			INSERT INTO Tbl_Direcciones(Id_Persona, Direccion, Ciudad, Departamento, Principal, Id_Estado)
			VALUES(@Id_Persona,@Direccion,  @Ciudad, @Departamento, @Principal,@Id_Estado)
			COMMIT 
				PRINT 'SE HA INSERTADO CORRECTAMENTE '
			END TRY 
			BEGIN CATCH 
			ROLLBACK 
				PRINT ' NO SE HA PODIDO INSERTAR '
			END CATCH
			
END
GO 

EXEC SPinsertarDirecciones 1005, 'lAS COLINAS','MANAGUA','MANAGUA', 1,1
GO

SELECT * FROM Tbl_Direcciones

select * from Tbl_Datos_Personales