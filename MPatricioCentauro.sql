CREATE DATABASE MPatricioCentauro
USE MPatricioCentauro
GO

CREATE TABLE GPS_DATA
(
Id int IDENTITY(1,1) NOT NULL,
DateSystem datetime NOT NULL,
DateEvent datetime NULL,
Latitude float NULL,
Longitude float NULL,
Battery int NULL,
Source int NULL,
Tipo int NULL
)
GO

INSERT INTO GPS_DATA (DateSystem, DateEvent, Latitude,Longitude, Battery, Source, Tipo) VALUES
('2022-01-01 01:10:00', '2022-01-05 02:10:00', 103.50, 75.10, 50, 1, 1)
INSERT INTO GPS_DATA (DateSystem, DateEvent, Latitude,Longitude, Battery, Source, Tipo) VALUES
('2022-02-02 02:20:00', '2022-02-10 04:20:00', 451.82, 115.14, 100, 2, 2)
INSERT INTO GPS_DATA (DateSystem, DateEvent, Latitude,Longitude, Battery, Source, Tipo) VALUES
('2022-03-03 03:30:00', '2022-03-15 06:30:00', 741.85, 842.41, 75, 3, 3)
GO
SELECT * FROM GPS_DATA
GO

CREATE PROCEDURE GpsGetAll
AS
SELECT Id,
		DateSystem,
		DateEvent,
		Latitude,
		Longitude,
		Battery,Source, 
		Tipo
FROM GPS_DATA
GO


ALTER PROCEDURE GpsGetById 
@Id INT
AS
SELECT Id,
		DateSystem,
		DateEvent,
		Latitude,
		Longitude,
		Battery,Source, 
		Tipo
FROM GPS_DATA
WHERE Id = @Id

GO

ALTER PROCEDURE GpsAdd
@DateSystem datetime,
@DateEvent datetime,
@Latitude float,
@Longitude float,
@Battery int,
@Source int,
@Tipo int
AS
INSERT INTO GPS_DATA (DateSystem, DateEvent, Latitude, Longitude, Battery, Source, Tipo) VALUES
(@DateSystem, @DateEvent, @Latitude, @Longitude, @Battery, @Source, @Tipo)
GO



ALTER PROCEDURE GpsUpdate
@Id INT,
@DateSystem datetime,
@DateEvent datetime,
@Latitude float,
@Longitude float,
@Battery int,
@Source int,
@Tipo int
AS
UPDATE GPS_DATA SET DateSystem = @DateSystem, DateEvent = @DateEvent, Latitude = @Latitude, Longitude = @Longitude, Battery = @Battery, Source = @Source, Tipo = @Tipo
WHERE Id = @Id
GO


CREATE PROCEDURE GpsDelete 
@Id INT
AS
DELETE GPS_DATA WHERE Id = @Id
GO





CREATE TABLE CTL_USERS
(
Id int PRIMARY KEY IDENTITY(1,1) NOT NULL,
IdRole int NULL
FOREIGN KEY (IdRole) REFERENCES CTL_ROLES (IdRole),
Name varchar(20) NULL,
LastName varchar(25) NULL,
SurName varchar(25) NULL,
Email varchar(80) NOT NULL,
UserName varchar(15) NOT NULL,
contrasena varbinary(8000) NOT NULL,
Parent int NULL,
Estatus int NOT NULL
)
ALTER TABLE CTL_USERS ALTER COLUMN contrasena VARCHAR(50) NOT NULL
INSERT INTO CTL_USERS (IdRole, Name, LastName,SurName, Email, UserName, contrasena,Parent, Estatus) VALUES
(1, 'Angel', 'Patricio', 'Sanchez', 'angel@gmail.com', 'angel01', 1234, 2, 1)
INSERT INTO CTL_USERS (IdRole, Name, LastName,SurName, Email, UserName, contrasena,Parent, Estatus) VALUES
(2, 'Luisa', 'Perez', 'Lopez', 'luisa@gmail.com', 'luisa01', 1234567, 2, 2)
SELECT * FROM CTL_USERS
GO


CREATE TABLE CTL_ROLES
(
IdRole Int PRIMARY KEY IDENTITY(1,1) NOT NULL,
RoleName varchar(20) NULL)
GO

INSERT INTO CTL_ROLES (RoleName) VALUES ('Aministrador')
INSERT INTO CTL_ROLES (RoleName) VALUES ('Usuario')
GO
SELECT * FROM CTL_USERS

ALTER PROCEDURE UserGetAll --'', '', 'Lopez', ''
@Name varchar(20),
@LastName varchar(25) ,
@SurName varchar(25),
@Email varchar(80)
AS
SELECT 
	CTL_USERS.Id,
	CTL_ROLES.IdRole,
	CTL_ROLES.RoleName,
	CTL_USERS.Name,
	CTL_USERS.LastName,
	CTL_USERS.SurName,
	CTL_USERS.Email,
	CTL_USERS.UserName,
	CTL_USERS.contrasena,
	CTL_USERS.Parent,
	CTL_USERS.Estatus
FROM CTL_USERS 
	INNER JOIN 
	CTL_ROLES ON CTL_USERS.IdRole = CTL_ROLES.IdRole
WHERE CTL_USERS.Name LIKE '%'+@Name+'%' AND CTL_USERS.LastName LIKE '%'+@LastName+'%' AND CTL_USERS.SurName LIKE '%'+@SurName+'%'
AND CTL_USERS.Email LIKE '%'+@Email+'%'
GO

ALTER PROCEDURE UserGetById
@Id INT
AS
SELECT
	CTL_USERS.Id,
	CTL_ROLES.IdRole,
	CTL_ROLES.RoleName,
	CTL_USERS.Name,
	CTL_USERS.LastName,
	CTL_USERS.SurName,
	CTL_USERS.Email,
	CTL_USERS.contrasena,
	CTL_USERS.Parent,
	CTL_USERS.Estatus
FROM CTL_USERS 
	INNER JOIN 
	CTL_ROLES ON CTL_USERS.IdRole = CTL_ROLES.IdRole
WHERE Id = @Id
GO

CREATE PROCEDURE UserAdd
@IdRole int,
@Name varchar(20),
@LastName varchar(25),
@SurName varchar(25),
@Email varchar(80),
@UserName varchar(15),
@contrasena VARCHAR(50),
@Parent int,
@Estatus int
AS
INSERT INTO CTL_USERS (IdRole, Name, LastName, SurName, Email, UserName, contrasena, Parent,Estatus) VALUES
(@IdRole, @Name,@LastName, @SurName, @Email, @UserName, @contrasena, @Parent, @Estatus)
GO



CREATE PROCEDURE UserUpdate
@Id INT,
@IdRole int,
@Name varchar(20),
@LastName varchar(25),
@SurName varchar(25),
@Email varchar(80),
@UserName varchar(15),
@contrasena VARCHAR(50),
@Parent int,
@Estatus int
AS
UPDATE CTL_USERS SET Name = @Name, LastName = @LastName, SurName = @SurName, Email = @Email, UserName = @UserName, contrasena = @contrasena, Parent = @Parent, Estatus = @Estatus
WHERE Id = @Id
GO

CREATE PROCEDURE UserDelete 
@Id INT
AS
DELETE CTL_USERS WHERE Id = @Id
GO