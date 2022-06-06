USE [master]
GO

/****** Object:  Database [YamilaDionicio]    Script Date: 6/6/2022 9:18:08 AM ******/
CREATE DATABASE [YamilaDionicio]

GO

USE [YamilaDionicio]
GO

/****** Object:  Table [dbo].[clientes]    Script Date: 6/6/2022 9:19:02 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[clientes](
	[nombre] [nvarchar](50) NOT NULL,
	[apellido] [nvarchar](50) NOT NULL,
	[dni] [int] NOT NULL
) ON [PRIMARY]
GO

INSERT INTO [dbo].[clientes]
           ([nombre]
           ,[apellido]
           ,[dni])
     VALUES
			('Jorge', 'Robles', 38569235),
			('Romina', 'Tin', 28659432),
			('Pedro', 'Gomez', 37569423),
			('Lucas', 'Roco', 30235481)
GO