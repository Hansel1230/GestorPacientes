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

           ('Naruto','Shipuden','343434','AldeaDeLaHoja','32322',2-12-22,0,
		   'salpullido','fdddd')
GO


