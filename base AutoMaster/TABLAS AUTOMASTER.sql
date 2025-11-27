-- Base
CREATE DATABASE AUTOMASTER;
GO
USE AUTOMASTER;
GO

-- Estados generales
CREATE TABLE Cls_Estados (
    Id_Estado INT PRIMARY KEY IDENTITY(1,1),
    Estado VARCHAR(80) NOT NULL,
    Fecha_Creacion DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    Fecha_Modificacion DATETIME2 NULL,
    Activo BIT NOT NULL DEFAULT 1
);
GO

-- Tipos de catálogo (grupo de catálogos: GENERO, DOCUMENTO, CONTACTO, CARGO, AREA, USUARIO_TIPO, etc.)
CREATE TABLE Cls_Tipo_Catalogos (
    Id_Tipo_Catalogo INT PRIMARY KEY IDENTITY(1,1),
    Codigo VARCHAR(50) NOT NULL, -- ej: 'GENERO','DOCUMENTO','CONTACTO','CARGO','AREA','USUARIO_TIPO'
    Tipo_Catalogo VARCHAR(80) NOT NULL,
    Fecha_Creacion DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    Fecha_Modificacion DATETIME2 NULL,
    Activo BIT NOT NULL DEFAULT 1
);
GO

-- Catálogos (valores por tipo)
CREATE TABLE Cls_Catalogos (
    Id_Catalogo INT PRIMARY KEY IDENTITY(1,1),
    Id_Tipo_Catalogo INT NOT NULL REFERENCES Cls_Tipo_Catalogos(Id_Tipo_Catalogo),
    Codigo VARCHAR(50) NULL, -- ej: 'M','F','CED','RUC','TEL','EMAIL'
    Catalogo VARCHAR(80) NOT NULL,
    Fecha_Creacion DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    Fecha_Modificacion DATETIME2 NULL,
    Activo BIT NOT NULL DEFAULT 1
);
GO

-- Personas (datos personales)
CREATE TABLE Tbl_Datos_Personales (
    Id_Persona INT PRIMARY KEY IDENTITY(1,1),
    Primer_Nombre VARCHAR(80) NOT NULL,
    Segundo_Nombre VARCHAR(80) NULL,
    Primer_Apellido VARCHAR(80) NOT NULL,
    Segundo_Apellido VARCHAR(80) NULL,
    Id_Genero INT NULL REFERENCES Cls_Catalogos(Id_Catalogo),
    Id_Tipo_DNI INT NULL REFERENCES Cls_Catalogos(Id_Catalogo),
    DNI VARCHAR(50) NOT NULL,
    Fecha_Creacion DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    Fecha_Modificacion DATETIME2 NULL,
    Id_Estado INT NOT NULL REFERENCES Cls_Estados(Id_Estado),
    CONSTRAINT UQ_Tbl_Datos_Personales_DNI UNIQUE (DNI)
);
GO

-- Contactos (muchos contactos por persona: teléfono, email, whatsapp, etc.)
CREATE TABLE Tbl_Contactos (
    Id_Contacto INT PRIMARY KEY IDENTITY(1,1),
    Id_Persona INT NULL REFERENCES Tbl_Datos_Personales(Id_Persona),
    Id_Tipo_Contacto INT NOT NULL REFERENCES Cls_Catalogos(Id_Catalogo),
    Contacto NVARCHAR(150) NOT NULL,
    Principal BIT NOT NULL DEFAULT 0,
    Fecha_Creacion DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    Fecha_Modificacion DATETIME2 NULL,
    Id_Estado INT NOT NULL REFERENCES Cls_Estados(Id_Estado)
);
GO



-- Direcciones (opcional, muchas direcciones por persona/cliente)
CREATE TABLE Tbl_Direcciones (
    Id_Direccion INT PRIMARY KEY IDENTITY(1,1),
    Id_Persona INT NULL REFERENCES Tbl_Datos_Personales(Id_Persona),
    Direccion VARCHAR(300) NOT NULL,
    Ciudad VARCHAR(100) NULL,
    Departamento VARCHAR(100) NULL,
    Principal BIT NOT NULL DEFAULT 0,
    Fecha_Creacion DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    Fecha_Modificacion DATETIME2 NULL,
    Id_Estado INT NOT NULL REFERENCES Cls_Estados(Id_Estado)
);
GO

-- Proveedores
CREATE TABLE Tbl_Proveedores (
    Id_Proveedor INT PRIMARY KEY IDENTITY(1,1),
    Representante INT NULL REFERENCES Tbl_Datos_Personales(Id_Persona),
    Nombre_Empresa VARCHAR(150) NOT NULL,
    RUC_Empresa VARCHAR(50) NOT NULL,
    Fecha_Registro DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    Id_Estado INT NOT NULL REFERENCES Cls_Estados(Id_Estado),
    CONSTRAINT UQ_Tbl_Proveedores_RUC UNIQUE (RUC_Empresa)
);
GO

-- Relación Proveedor - Contactos (un proveedor puede tener varios contactos)
CREATE TABLE Proveedor_Contactos (
    Id_Proveedor INT NOT NULL REFERENCES Tbl_Proveedores(Id_Proveedor),
    Id_Contacto INT NOT NULL REFERENCES Tbl_Contactos(Id_Contacto),
    Principal BIT NOT NULL DEFAULT 0,
    Fecha_Registro DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT PK_Proveedor_Contactos PRIMARY KEY (Id_Proveedor, Id_Contacto)
);
GO

-- Empleados (vinculados a persona, cargo y área mediante catálogos)
CREATE TABLE Empleados (
    Id_Empleado INT PRIMARY KEY IDENTITY(1,1),
    Id_Persona INT NOT NULL REFERENCES Tbl_Datos_Personales(Id_Persona),
    Id_Cargo INT NULL REFERENCES Cls_Catalogos(Id_Catalogo),
    Id_Area INT NULL REFERENCES Cls_Catalogos(Id_Catalogo),
    Fecha_Registro DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    Activo BIT NOT NULL DEFAULT 1
);
GO

-- Clientes (separado de datos personales; un cliente referencia persona y puede tener múltiples direcciones/contactos)
CREATE TABLE Clientes (
    Id_Cliente INT PRIMARY KEY IDENTITY(1,1),
    Id_Persona INT NOT NULL REFERENCES Tbl_Datos_Personales(Id_Persona),
    Fecha_Registro DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    Activo BIT NOT NULL DEFAULT 1
);
GO

-- Vehículos (unicidad en chasis/motor)
CREATE TABLE Vehiculos (
    Id_Vehiculo INT PRIMARY KEY IDENTITY(1,1),
    Id_Proveedor INT NULL REFERENCES Tbl_Proveedores(Id_Proveedor),
    Marca VARCHAR(80) NOT NULL,
    Modelo VARCHAR(80) NOT NULL,
    Anio INT NOT NULL,
    Serie_Chasis VARCHAR(100) NOT NULL,
    Serie_Motor VARCHAR(100) NOT NULL,
    Precio DECIMAL(18,2) NOT NULL,
    Id_Estado INT NOT NULL REFERENCES Cls_Estados(Id_Estado),
    Fecha_Ingreso_Pais DATE NULL,
    Fecha_Registro DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT UQ_Vehiculos_Chasis UNIQUE (Serie_Chasis),
    CONSTRAINT UQ_Vehiculos_Motor UNIQUE (Serie_Motor)
);
GO

CREATE TABLE Ventas (
    Id_Venta INT PRIMARY KEY IDENTITY(1,1),
    Id_Vehiculo INT NOT NULL REFERENCES Vehiculos(Id_Vehiculo),
    Id_Cliente INT NOT NULL REFERENCES Clientes(Id_Cliente),
    Id_Empleado INT NOT NULL REFERENCES Empleados(Id_Empleado),
    Fecha_Venta DATE NOT NULL,
    Precio_Venta DECIMAL(18,2) NOT NULL,
    Observaciones VARCHAR(500) NULL,
    Fecha_Registro DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
);
GO


CREATE TABLE Financiamiento (
    Id_Financiamiento INT PRIMARY KEY IDENTITY(1,1),
    Id_Venta INT NOT NULL REFERENCES Ventas(Id_Venta),
    Id_Cliente INT NOT NULL REFERENCES Clientes(Id_Cliente),
    Monto DECIMAL(18,2) NOT NULL,
    Plazo_Meses INT NOT NULL,
    Tasa_Interes DECIMAL(9,4) NULL,
    Fecha_Inicio DATE NOT NULL,
    Fecha_Cancelacion DATE NULL,
    Fecha_Registro DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
);
GO

CREATE TABLE Pagos (
    Id_Pago INT PRIMARY KEY IDENTITY(1,1),
    Id_Venta INT NULL REFERENCES Ventas(Id_Venta),
    Id_Financiamiento INT NULL REFERENCES Financiamiento(Id_Financiamiento),
    Fecha_Pago DATETIME2 NOT NULL,
    Monto DECIMAL(18,2) NOT NULL,
    Metodo_Pago VARCHAR(20) NOT NULL,
    Observaciones VARCHAR(500) NULL,
    Fecha_Registro DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
  
);
GO


CREATE TABLE Facturas (
    Id_Factura INT PRIMARY KEY IDENTITY(1,1),
    Id_Venta INT NOT NULL REFERENCES Ventas(Id_Venta),
    Id_Pago INT NULL REFERENCES Pagos(Id_Pago),
    Id_Financiamiento INT NULL REFERENCES Financiamiento(Id_Financiamiento),
    Numero_Factura VARCHAR(100) NOT NULL,
    Fecha_Emision DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    Subtotal DECIMAL(18,2) NULL,
    IVA DECIMAL(18,2) NULL,
    Total DECIMAL(18,2) NULL
);
GO

CREATE UNIQUE INDEX UQ_Facturas_Numero ON Facturas(Numero_Factura);




-- Servicios a vehículos
CREATE TABLE Servicios_Vehiculos (
    Id_Servicio INT PRIMARY KEY IDENTITY(1,1),
    Id_Vehiculo INT NOT NULL REFERENCES Vehiculos(Id_Vehiculo),
    Id_Tipo_Servicio INT NULL REFERENCES Cls_Catalogos(Id_Catalogo),
    Fecha_Servicio DATE NOT NULL,
    Costo DECIMAL(18,2) NULL,
    Realizado_por INT NULL REFERENCES Empleados(Id_Empleado),
    Observaciones VARCHAR(500) NULL,
    Fecha_Registro DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
);
GO

-- Taller / órdenes de trabajo
CREATE TABLE Taller (
    Id_Taller INT PRIMARY KEY IDENTITY(1,1),
    Id_Vehiculo INT NOT NULL REFERENCES Vehiculos(Id_Vehiculo),
    Descripcion_Trabajo VARCHAR(500) NOT NULL,
    Fecha_Ingreso DATE NOT NULL,
    Fecha_Salida DATE NULL,
    Costo DECIMAL(18,2) NULL,
    Responsable INT NULL REFERENCES Empleados(Id_Empleado),
    Fecha_Registro DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME()
);
GO

-- Roles y asignación de roles a usuarios
CREATE TABLE Roles (
    Id_Rol INT PRIMARY KEY IDENTITY(1,1),
    Nombre_Rol VARCHAR(100) NOT NULL
);
GO

-- Usuarios (hash + salt para contraseñas)
CREATE TABLE Tbl_Usuarios (
    Id_Usuario INT PRIMARY KEY IDENTITY(1,1),
    Id_Tipo_de_Usuario INT NULL REFERENCES Cls_Catalogos(Id_Catalogo),
    Id_Persona INT NULL REFERENCES Tbl_Datos_Personales(Id_Persona),
    Usuario VARCHAR(100) NOT NULL UNIQUE,
    Contrasena_Hash VARBINARY(512) NOT NULL,
    Contrasena_Salt VARBINARY(128) NOT NULL,
    Fecha_Creacion DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    Fecha_Modificacion DATETIME2 NULL,
    Id_Estado INT NOT NULL REFERENCES Cls_Estados(Id_Estado)
);
GO

CREATE TABLE Usuarios_Roles (
    Id_Usuario INT NOT NULL REFERENCES Tbl_Usuarios(Id_Usuario),
    Id_Rol INT NOT NULL REFERENCES Roles(Id_Rol),
    Fecha_Asignacion DATETIME2 NOT NULL DEFAULT SYSUTCDATETIME(),
    CONSTRAINT PK_Usuarios_Roles PRIMARY KEY (Id_Usuario, Id_Rol)
);
GO

