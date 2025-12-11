USE AUTOMASTER;
GO

--sala acordate que estas tablas ya las tenes, borralas y volvelas a ejecutar porque hice unos cambios en ellas
--los sp normal, solo ejecutalos




-- Tabla Roles
CREATE TABLE Roles (
    Id_Rol INT PRIMARY KEY IDENTITY(1,1),
    Nombre_Rol VARCHAR(100) NOT NULL
);
GO

-- Tabla Usuarios 
CREATE TABLE Tbl_Usuarios (
    Id_Usuario INT PRIMARY KEY IDENTITY(1,1),
    Id_Tipo_de_Usuario INT NULL, 
    Id_Persona INT NULL,       
    Usuario VARCHAR(100) NOT NULL UNIQUE, 
    Contrasena_Hash VARCHAR(60) NOT NULL, 
    Fecha_Creacion DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    Fecha_Modificacion DATETIME2 NULL,
    Id_Estado INT NOT NULL 
);
GO

--  Tabla Intermedia
CREATE TABLE Usuarios_Roles (
    Id_Usuario INT NOT NULL REFERENCES Tbl_Usuarios(Id_Usuario),
    Id_Rol INT NOT NULL REFERENCES Roles(Id_Rol),
    Fecha_Asignacion DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT PK_Usuarios_Roles PRIMARY KEY (Id_Usuario, Id_Rol)
);
GO

--inserciones
INSERT INTO Roles (Nombre_Rol) VALUES ('Administrador'), ('Mecánico'), ('Ventas');
GO


-- Asignar roles
INSERT INTO Usuarios_Roles (Id_Usuario, Id_Rol) VALUES (1, 1), (2, 2), (3, 3);
GO


--Procedimiento almacenado

CREATE OR ALTER PROCEDURE SP_Logueo
    @Usuario VARCHAR(100)
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        u.Id_Usuario,
        u.Id_Tipo_de_Usuario,
        u.Usuario,
        u.Contrasena_Hash, 
        r.Nombre_Rol
    FROM Tbl_Usuarios u
    LEFT JOIN Usuarios_Roles ur ON u.Id_Usuario = ur.Id_Usuario
    LEFT JOIN Roles r ON ur.Id_Rol = r.Id_Rol
    WHERE u.Usuario = @Usuario 
      AND u.Id_Estado = 1; 
END;
GO


---spRegistrar nuevos usuarios



USE AUTOMASTER;
GO

ALTER PROCEDURE SP_RegistrarUsuario
    @Usuario VARCHAR(100),
    @Contrasena_Hash VARCHAR(60),
    @Id_Rol INT,
    @Id_Persona INT 
AS
BEGIN
    SET NOCOUNT ON;
    
    -- Insertamos incluyendo el Id_Persona
    INSERT INTO Tbl_Usuarios (Usuario, Contrasena_Hash, Id_Estado, Fecha_Creacion, Id_Persona, Id_Tipo_de_Usuario)
    VALUES (@Usuario, @Contrasena_Hash, 1, SYSUTCDATETIME(), @Id_Persona, 1);

    DECLARE @NewId INT = SCOPE_IDENTITY();

    INSERT INTO Usuarios_Roles (Id_Usuario, Id_Rol)
    VALUES (@NewId, @Id_Rol);
END;
GO


CREATE OR ALTER PROCEDURE SP_ListarRoles
AS
BEGIN
    SELECT Id_Rol, Nombre_Rol FROM Roles;
END;
GO

USE AUTOMASTER;
GO


IF OBJECT_ID('Roles', 'U') IS NULL
BEGIN
    CREATE TABLE Roles (
        Id_Rol INT PRIMARY KEY IDENTITY(1,1),
        Nombre_Rol VARCHAR(100) NOT NULL
    );
    PRINT 'Tabla Roles creada exitosamente.';
END
GO


IF NOT EXISTS (SELECT * FROM Roles)
BEGIN
    INSERT INTO Roles (Nombre_Rol) VALUES 
    ('Administrador'), 
    ('Mecánico'), 
    ('Ventas');
    
    PRINT 'Datos insertados en Roles.';
END
GO

--verificacion

SELECT * FROM Tbl_Usuarios;
GO


