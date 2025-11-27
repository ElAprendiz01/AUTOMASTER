use AUTOMASTER
go 
CREATE OR ALTER PROCEDURE SPListarOpcionesParaPersonas
AS
BEGIN
    SET NOCOUNT ON;

    -- Primer resultado: Géneros
    SELECT Id_Catalogo AS ID, Catalogo AS Genero
    FROM Cls_Catalogos
    WHERE Id_Tipo_Catalogo = 1;

    -- Segundo resultado: Tipos de DNI
    SELECT Id_Catalogo AS ID, Catalogo AS DNI
    FROM Cls_Catalogos
    WHERE Id_Tipo_Catalogo = 2;

    -- Tercer resultado: Estados
    SELECT Id_Estado as ID, Estado
    FROM Cls_Estados;
END
exec SPListarOpcionesParaPersonas

