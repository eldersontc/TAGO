USE [master]
GO
CREATE DATABASE [DB_TAXI_EXTERNO] 
GO
USE [DB_TAXI_EXTERNO]
GO
CREATE TABLE [dbo].[UberDriver](
			[Placa] [varchar](7) NOT NULL,
			[Nombres] [varchar](50) NULL,
			[Apellidos] [varchar](50) NULL,
			[Celular] [varchar](50) NULL,
			[ModeloAuto] [varchar](50) NULL,
			[Reputacion] [int] NULL,
			[FechaRegistro] datetime NULL,
 CONSTRAINT [PK_UberDriver] PRIMARY KEY CLUSTERED 
(
	[Placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
CREATE TABLE [dbo].[UberAvailable](
			[Placa] [varchar](7) NOT NULL,
			[MarcaAuto] [varchar](50) NULL,
			[ColorAuto] [varchar](50) NULL,
			[TiempoLlegada] datetime NULL,
			[MontoACobrar] decimal(18,2) NULL,
 CONSTRAINT [PK_UberAvailable] PRIMARY KEY CLUSTERED 
(
	[Placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]