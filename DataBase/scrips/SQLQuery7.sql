USE [GestorDePacientes]
GO

INSERT INTO [dbo].[Pacientes]
           ([Nombre]
           ,[Apellido]
           ,[Telefono]
           ,[Direccion]
           ,[Cedula]
           ,[Fecha_Nacimiento]
           ,[Fumador]
           ,[Alergias]
           ,[Foto])
     VALUES
           ('Naruto','Shipuden','343434','AldeaDeLaHoja','32322','alli',2/12/22,
           ,<Apellido, nvarchar(50),>
           ,<Telefono, nvarchar(50),>
           ,<Direccion, nvarchar(50),>
           ,<Cedula, nvarchar(50),>
           ,<Fecha_Nacimiento, datetime,>
           ,<Fumador, bit,>
           ,<Alergias, nvarchar(50),>
           ,<Foto, nvarchar(50),>)
GO


