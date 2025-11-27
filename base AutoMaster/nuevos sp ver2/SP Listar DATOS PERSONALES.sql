USE AUTOMASTER
GO 

CREATE OR ALTER PROCEDURE SPListarDatosPersonales
AS 
BEGIN 
  SET NOCOUNT ON;
	BEGIN TRY 
		SELECT 
		dtp.Id_Persona,
		DTP.Primer_Nombre,
		DTP.Segundo_Nombre,
		DTP.Primer_Apellido,
		DTP.Segundo_Apellido,
		DTP.Id_Genero,
		IDGEN.Catalogo AS Genero,
		DTP.Id_Tipo_DNI,
		TIPDNI.Catalogo AS TipoDNI,
		DTP.DNI,
		DTP.Fecha_Creacion,
		DTP.Fecha_Modificacion,
		DTP.Id_Estado,
		IDEST.Estado

		FROM Tbl_Datos_Personales AS DTP
		INNER JOIN Cls_Catalogos IDGEN ON DTP.Id_Genero  = IDGEN.Id_Catalogo
		INNER JOIN Cls_Catalogos TIPDNI ON DTP.Id_Tipo_DNI = TIPDNI.Id_Catalogo
		INNER JOIN Cls_Estados  IDEST ON DTP.Id_Estado = IDEST.Id_Estado
	END TRY
	BEGIN CATCH 
		PRINT 'NO SE HA PODIDO LISTAR '+ @@ERROR
	END CATCH 
END 
GO 
EXEC SPListarDatosPersonales
	 