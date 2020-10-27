use master
GO

use XXX
GO

exec sp_grantdbaccess 'ticom'
GO
 
exec sp_addrolemember 'db_owner','ticom'
GO

-- **************************************
-- CREACION DE TABLAS
-- **************************************

-- ------------------------------------------------

CREATE TABLE usuarios
    (
     id int identity NOT NULL , 
     usuario VARCHAR (50) , 
     clave VARCHAR (50)
    )
GO 

-- ------------------------------------------------

CREATE TABLE empresas
    (
     id int identity NOT NULL , 
     nombre VARCHAR (50)
    )
GO 

-- ------------------------------------------------

CREATE TABLE usuarios_empresas
    (
     id_empresa int NOT NULL, 
     id_usuario int NOT NULL 
    )
GO 

-- ------------------------------------------------

-- INSERTAR USUARIOS

INSERT INTO usuarios (usuario, clave) VALUES ('ticom','123456')

-- ------------------------------------------------

-- INSERTAR EMPRESAS

INSERT INTO empresas (nombre) VALUES ('demo')

-- ------------------------------------------------

-- INSERTAR USUARIOS-EMPRESAS

INSERT INTO usuarios_empresas (id_empresa,id_usuario) VALUES (1,1)
