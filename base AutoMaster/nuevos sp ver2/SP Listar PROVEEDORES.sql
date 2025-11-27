USE AUTOMASTER
GO 
CREATE OR ALTER PROCEDURE SPlistarProveedores
as 
BEGIN 
	SET NOCOUNT ON;
		BEGIN TRY 
			SELECT 
			DTP.Id_Persona AS ID_Representante,
			Dtp.Primer_Nombre,
			DTP.Primer_Apellido,
			PROV.Id_Proveedor,
			PROV.Nombre_Empresa,
			prov.RUC_Empresa,
			PROV.Fecha_Registro,
			prov.Id_Estado,
			EST.Estado

			FROM Tbl_Proveedores PROV
			INNER JOIN Tbl_Datos_Personales DTP ON PROV.Representante = DTP.Id_Persona
			INNER JOIN Cls_Estados EST ON PROV.Id_Estado = EST.Id_Estado
		
		END TRY 
		BEGIN CATCH 
			
			PRINT' NO SE HA PODIDO LISTAR'+ @@ERROR
		END CATCH
END 
GO 

EXEC SPlistarProveedores

