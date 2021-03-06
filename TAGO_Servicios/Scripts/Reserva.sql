USE [TAGO]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Reserva_EstadoReserva]') AND parent_object_id = OBJECT_ID(N'[dbo].[Reserva]'))
ALTER TABLE [dbo].[Reserva] DROP CONSTRAINT [FK_Reserva_EstadoReserva]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PagoReserva_Reserva]') AND parent_object_id = OBJECT_ID(N'[dbo].[PagoReserva]'))
ALTER TABLE [dbo].[PagoReserva] DROP CONSTRAINT [FK_PagoReserva_Reserva]
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PagoReserva_MedioPago]') AND parent_object_id = OBJECT_ID(N'[dbo].[PagoReserva]'))
ALTER TABLE [dbo].[PagoReserva] DROP CONSTRAINT [FK_PagoReserva_MedioPago]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 22/04/2018 12:57:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Reserva]') AND type in (N'U'))
DROP TABLE [dbo].[Reserva]
GO
/****** Object:  Table [dbo].[PagoReserva]    Script Date: 22/04/2018 12:57:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PagoReserva]') AND type in (N'U'))
DROP TABLE [dbo].[PagoReserva]
GO
/****** Object:  Table [dbo].[MedioPago]    Script Date: 22/04/2018 12:57:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MedioPago]') AND type in (N'U'))
DROP TABLE [dbo].[MedioPago]
GO
/****** Object:  Table [dbo].[EstadoReserva]    Script Date: 22/04/2018 12:57:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EstadoReserva]') AND type in (N'U'))
DROP TABLE [dbo].[EstadoReserva]
GO
/****** Object:  Table [dbo].[EstadoReserva]    Script Date: 22/04/2018 12:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[EstadoReserva]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[EstadoReserva](
	[IdEstadoReserva] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_EstadoReserva] PRIMARY KEY CLUSTERED 
(
	[IdEstadoReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[MedioPago]    Script Date: 22/04/2018 12:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING OFF
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MedioPago]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MedioPago](
	[IdMedioPago] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [varchar](50) NULL,
 CONSTRAINT [PK_MedioPago] PRIMARY KEY CLUSTERED 
(
	[IdMedioPago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PagoReserva]    Script Date: 22/04/2018 12:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[PagoReserva]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[PagoReserva](
	[IdPagoReserva] [int] IDENTITY(1,1) NOT NULL,
	[IdReserva] [int] NULL,
	[IdMedioPago] [int] NULL,
	[NumeroTarjeta] [varchar](20) NULL,
	[FechaPagoReserva] [datetime] NULL,
 CONSTRAINT [PK_PagoReserva] PRIMARY KEY CLUSTERED 
(
	[IdPagoReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 22/04/2018 12:57:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Reserva]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Reserva](
	[IdReserva] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NULL,
	[FechaRecojoCliente] [datetime] NULL,
	[Origen] [varchar](50) NULL,
	[Destino] [varchar](50) NULL,
	[Importe] [money] NULL,
	[IdEstadoReserva] [int] NULL,
	[FechaRegistroReserva] [datetime] NULL,
	[Placa] [varchar](50) NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[IdReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[EstadoReserva] ON 

INSERT [dbo].[EstadoReserva] ([IdEstadoReserva], [Descripcion]) VALUES (1, N'Reservado')
INSERT [dbo].[EstadoReserva] ([IdEstadoReserva], [Descripcion]) VALUES (2, N'Cancelado')
INSERT [dbo].[EstadoReserva] ([IdEstadoReserva], [Descripcion]) VALUES (3, N'Pagado')
SET IDENTITY_INSERT [dbo].[EstadoReserva] OFF
SET IDENTITY_INSERT [dbo].[Reserva] ON 

INSERT [dbo].[Reserva] ([IdReserva], [IdCliente], [FechaRecojoCliente], [Origen], [Destino], [Importe], [IdEstadoReserva], [FechaRegistroReserva], [Placa]) VALUES (2, 10, CAST(N'2018-04-22 00:00:00.000' AS DateTime), N'Lima', N'UPC, Villa', 10.2000, 1, CAST(N'2018-04-22 00:00:00.000' AS DateTime), N'XQ-8208')
INSERT [dbo].[Reserva] ([IdReserva], [IdCliente], [FechaRecojoCliente], [Origen], [Destino], [Importe], [IdEstadoReserva], [FechaRegistroReserva], [Placa]) VALUES (3, 10, CAST(N'2018-04-22 00:00:00.000' AS DateTime), N'Lima', N'UPC, Villa', 10.2000, 1, CAST(N'2018-04-22 00:00:00.000' AS DateTime), N'XQ-8208')
INSERT [dbo].[Reserva] ([IdReserva], [IdCliente], [FechaRecojoCliente], [Origen], [Destino], [Importe], [IdEstadoReserva], [FechaRegistroReserva], [Placa]) VALUES (4, 10, CAST(N'2018-04-22 00:00:00.000' AS DateTime), N'Lima', N'UPC, Villa', 10.2000, 1, CAST(N'2018-04-22 00:00:00.000' AS DateTime), N'XQ-8208')
SET IDENTITY_INSERT [dbo].[Reserva] OFF
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PagoReserva_MedioPago]') AND parent_object_id = OBJECT_ID(N'[dbo].[PagoReserva]'))
ALTER TABLE [dbo].[PagoReserva]  WITH CHECK ADD  CONSTRAINT [FK_PagoReserva_MedioPago] FOREIGN KEY([IdMedioPago])
REFERENCES [dbo].[MedioPago] ([IdMedioPago])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PagoReserva_MedioPago]') AND parent_object_id = OBJECT_ID(N'[dbo].[PagoReserva]'))
ALTER TABLE [dbo].[PagoReserva] CHECK CONSTRAINT [FK_PagoReserva_MedioPago]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PagoReserva_Reserva]') AND parent_object_id = OBJECT_ID(N'[dbo].[PagoReserva]'))
ALTER TABLE [dbo].[PagoReserva]  WITH CHECK ADD  CONSTRAINT [FK_PagoReserva_Reserva] FOREIGN KEY([IdReserva])
REFERENCES [dbo].[Reserva] ([IdReserva])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_PagoReserva_Reserva]') AND parent_object_id = OBJECT_ID(N'[dbo].[PagoReserva]'))
ALTER TABLE [dbo].[PagoReserva] CHECK CONSTRAINT [FK_PagoReserva_Reserva]
GO
IF NOT EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Reserva_EstadoReserva]') AND parent_object_id = OBJECT_ID(N'[dbo].[Reserva]'))
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_EstadoReserva] FOREIGN KEY([IdEstadoReserva])
REFERENCES [dbo].[EstadoReserva] ([IdEstadoReserva])
GO
IF  EXISTS (SELECT * FROM sys.foreign_keys WHERE object_id = OBJECT_ID(N'[dbo].[FK_Reserva_EstadoReserva]') AND parent_object_id = OBJECT_ID(N'[dbo].[Reserva]'))
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_EstadoReserva]
GO
