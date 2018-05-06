USE [master]
GO
/****** Object:  Database [DB_TAXI_EXTERNO]    Script Date: 06/05/2018 10:08:04 ******/
CREATE DATABASE [DB_TAXI_EXTERNO]
GO

USE [DB_TAXI_EXTERNO]
GO
/****** Object:  Table [dbo].[CabifyChofer]    Script Date: 06/05/2018 10:08:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CabifyChofer](
	[Codigo] [varchar](4) NOT NULL,
	[Nombres] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[Celular] [varchar](50) NULL,
	[Reputacion] [int] NULL,
	[FechaRegistro] [datetime] NULL,
	[AutoPlaca] [varchar](7) NULL,
	[AutoMarca] [varchar](50) NULL,
	[AutoModelo] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Codigo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[CabifyDisponible]    Script Date: 06/05/2018 10:08:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[CabifyDisponible](
	[AutoPlaca] [varchar](7) NOT NULL,
	[TiempoLlegada] [int] NOT NULL,
	[TiempoViaje] [int] NOT NULL,
	[Monto] [decimal](18, 2) NULL,
	[OLatitud] [nvarchar](50) NULL,
	[OLongitud] [nvarchar](50) NULL,
	[DLatitud] [nvarchar](50) NULL,
	[DLongitud] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[AutoPlaca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UberAvailable]    Script Date: 06/05/2018 10:08:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UberAvailable](
	[Placa] [varchar](7) NOT NULL,
	[MarcaAuto] [varchar](50) NULL,
	[ColorAuto] [varchar](50) NULL,
	[TiempoLlegada] [int] NOT NULL,
	[MontoACobrar] [decimal](18, 2) NULL,
	[TiempoViaje] [int] NOT NULL,
	[LatitudOrigen] [varchar](50) NULL,
	[LongitudOrigen] [varchar](50) NULL,
	[LatitudDestino] [varchar](50) NULL,
	[LongitudDestino] [varchar](50) NULL,
 CONSTRAINT [PK_UberAvailable] PRIMARY KEY CLUSTERED 
(
	[Placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[UberDriver]    Script Date: 06/05/2018 10:08:05 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[UberDriver](
	[Placa] [varchar](7) NOT NULL,
	[Nombres] [varchar](50) NULL,
	[Apellidos] [varchar](50) NULL,
	[Celular] [varchar](50) NULL,
	[ModeloAuto] [varchar](50) NULL,
	[Reputacion] [int] NULL,
	[FechaRegistro] [datetime] NULL,
 CONSTRAINT [PK_UberDriver] PRIMARY KEY CLUSTERED 
(
	[Placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[CabifyChofer] ([Codigo], [Nombres], [Apellidos], [Celular], [Reputacion], [FechaRegistro], [AutoPlaca], [AutoMarca], [AutoModelo]) VALUES (N'C001', N'Hector', N'Gimenez Diaz', N'956356142', 4, CAST(0x0000A83100000000 AS DateTime), N'BBH-322', N'Mazda', N'MX-5')
INSERT [dbo].[CabifyChofer] ([Codigo], [Nombres], [Apellidos], [Celular], [Reputacion], [FechaRegistro], [AutoPlaca], [AutoMarca], [AutoModelo]) VALUES (N'C002', N'Alberto', N'Chavez Ortiz', N'978452152', 3, CAST(0x0000A75300000000 AS DateTime), N'JDB-159', N'Toyota', N'GT86')
INSERT [dbo].[CabifyChofer] ([Codigo], [Nombres], [Apellidos], [Celular], [Reputacion], [FechaRegistro], [AutoPlaca], [AutoMarca], [AutoModelo]) VALUES (N'C003', N'Juan', N'Namuche Tanta', N'963258741', 5, CAST(0x0000A81000000000 AS DateTime), N'LSO-789', N'Toyota', N'RAV4')
INSERT [dbo].[CabifyChofer] ([Codigo], [Nombres], [Apellidos], [Celular], [Reputacion], [FechaRegistro], [AutoPlaca], [AutoMarca], [AutoModelo]) VALUES (N'C004', N'Carlos', N'Zapata Del Rio', N'912445236', 5, CAST(0x0000A7F800000000 AS DateTime), N'PBC-321', N'Kia', N'Cerato')
INSERT [dbo].[CabifyChofer] ([Codigo], [Nombres], [Apellidos], [Celular], [Reputacion], [FechaRegistro], [AutoPlaca], [AutoMarca], [AutoModelo]) VALUES (N'C005', N'Omar', N'Ipanaque Arevalo', N'987712456', 3, CAST(0x0000A7CD00000000 AS DateTime), N'QTD-456', N'Kia', N'Optima')
INSERT [dbo].[CabifyChofer] ([Codigo], [Nombres], [Apellidos], [Celular], [Reputacion], [FechaRegistro], [AutoPlaca], [AutoMarca], [AutoModelo]) VALUES (N'C006', N'Edwin', N'Susanibar Oblitas', N'923412574', 4, CAST(0x0000A7BC00000000 AS DateTime), N'MDS-741', N'Toyota', N'TF101')
INSERT [dbo].[CabifyChofer] ([Codigo], [Nombres], [Apellidos], [Celular], [Reputacion], [FechaRegistro], [AutoPlaca], [AutoMarca], [AutoModelo]) VALUES (N'C007', N'Dante', N'Mamani Quispe', N'986745214', 4, CAST(0x0000A79200000000 AS DateTime), N'WSX-258', N'Kia', N'Sephia')
INSERT [dbo].[CabifyChofer] ([Codigo], [Nombres], [Apellidos], [Celular], [Reputacion], [FechaRegistro], [AutoPlaca], [AutoMarca], [AutoModelo]) VALUES (N'C008', N'Raul', N'Franco Navarro', N'932567415', 5, CAST(0x0000A78100000000 AS DateTime), N'HRT-963', N'Mazda', N'CX-3')
INSERT [dbo].[CabifyChofer] ([Codigo], [Nombres], [Apellidos], [Celular], [Reputacion], [FechaRegistro], [AutoPlaca], [AutoMarca], [AutoModelo]) VALUES (N'C009', N'Julio', N'Salvador Chuquipul', N'917382468', 5, CAST(0x0000A75100000000 AS DateTime), N'XJU-236', N'Toyota', N'Yaris')
INSERT [dbo].[CabifyChofer] ([Codigo], [Nombres], [Apellidos], [Celular], [Reputacion], [FechaRegistro], [AutoPlaca], [AutoMarca], [AutoModelo]) VALUES (N'C010', N'Eduardo', N'Huaman Huaypa', N'987246147', 4, CAST(0x0000A74400000000 AS DateTime), N'VSP-412', N'Mazda', N'CX-5')
INSERT [dbo].[CabifyDisponible] ([AutoPlaca], [TiempoLlegada], [TiempoViaje], [Monto], [OLatitud], [OLongitud], [DLatitud], [DLongitud]) VALUES (N'BBH-322', 7, 20, CAST(10.00 AS Decimal(18, 2)), N'-12.1047528', N'-76.9634465', N'-12.0876296', N'-77.0501054')
INSERT [dbo].[CabifyDisponible] ([AutoPlaca], [TiempoLlegada], [TiempoViaje], [Monto], [OLatitud], [OLongitud], [DLatitud], [DLongitud]) VALUES (N'HRT-963', 14, 67, CAST(19.00 AS Decimal(18, 2)), N'-12.1047528', N'-76.9634465', N'-12.0876296', N'-77.0501054')
INSERT [dbo].[CabifyDisponible] ([AutoPlaca], [TiempoLlegada], [TiempoViaje], [Monto], [OLatitud], [OLongitud], [DLatitud], [DLongitud]) VALUES (N'JDB-159', 8, 25, CAST(17.00 AS Decimal(18, 2)), N'-12.113611', N'-77.024984', N'-12.125695', N'-77.022195')
INSERT [dbo].[CabifyDisponible] ([AutoPlaca], [TiempoLlegada], [TiempoViaje], [Monto], [OLatitud], [OLongitud], [DLatitud], [DLongitud]) VALUES (N'LSO-789', 9, 35, CAST(18.00 AS Decimal(18, 2)), N'-12.124352', N'-77.031336', N'-12.118966', N'-77.040036')
INSERT [dbo].[CabifyDisponible] ([AutoPlaca], [TiempoLlegada], [TiempoViaje], [Monto], [OLatitud], [OLongitud], [DLatitud], [DLongitud]) VALUES (N'MDS-741', 12, 30, CAST(25.00 AS Decimal(18, 2)), N'-12.084807', N'-76.971413', N'-12.066803', N'-77.033898')
INSERT [dbo].[CabifyDisponible] ([AutoPlaca], [TiempoLlegada], [TiempoViaje], [Monto], [OLatitud], [OLongitud], [DLatitud], [DLongitud]) VALUES (N'PBC-321', 10, 2, CAST(20.00 AS Decimal(18, 2)), N'-12.113343', N'-77.031453', N'-12.108098', N'-77.007420')
INSERT [dbo].[CabifyDisponible] ([AutoPlaca], [TiempoLlegada], [TiempoViaje], [Monto], [OLatitud], [OLongitud], [DLatitud], [DLongitud]) VALUES (N'QTD-456', 11, 12, CAST(20.00 AS Decimal(18, 2)), N'-12.103650', N'-77.030079', N'-12.100502', N'-76.969568')
INSERT [dbo].[CabifyDisponible] ([AutoPlaca], [TiempoLlegada], [TiempoViaje], [Monto], [OLatitud], [OLongitud], [DLatitud], [DLongitud]) VALUES (N'VSP-412', 16, 40, CAST(15.00 AS Decimal(18, 2)), N'-12.068474', N'-77.041901', N'-12.055506', N'-77.017525')
INSERT [dbo].[CabifyDisponible] ([AutoPlaca], [TiempoLlegada], [TiempoViaje], [Monto], [OLatitud], [OLongitud], [DLatitud], [DLongitud]) VALUES (N'WSX-258', 13, 45, CAST(30.00 AS Decimal(18, 2)), N'-12.057738', N'-77.035400', N'-12.131984', N'-77.030711')
INSERT [dbo].[CabifyDisponible] ([AutoPlaca], [TiempoLlegada], [TiempoViaje], [Monto], [OLatitud], [OLongitud], [DLatitud], [DLongitud]) VALUES (N'XJU-236', 15, 12, CAST(18.00 AS Decimal(18, 2)), N'-12.064634', N'-77.127528', N'-12.059410', N'-77.147819')
INSERT [dbo].[UberAvailable] ([Placa], [MarcaAuto], [ColorAuto], [TiempoLlegada], [MontoACobrar], [TiempoViaje], [LatitudOrigen], [LongitudOrigen], [LatitudDestino], [LongitudDestino]) VALUES (N'ACE-322', N'Mazda MX-5', N'Negro', 20, CAST(10.00 AS Decimal(18, 2)), 2, N'-12.1047528', N'-76.9634465', N'-12.0876296', N'-77.0501054')
INSERT [dbo].[UberAvailable] ([Placa], [MarcaAuto], [ColorAuto], [TiempoLlegada], [MontoACobrar], [TiempoViaje], [LatitudOrigen], [LongitudOrigen], [LatitudDestino], [LongitudDestino]) VALUES (N'BBO-159', N'Toyota GT86', N'Blanco', 5, CAST(23.00 AS Decimal(18, 2)), 40, N'-12.1047528', N'-76.9634465', N'-12.0876296', N'-77.0501054')
INSERT [dbo].[UberAvailable] ([Placa], [MarcaAuto], [ColorAuto], [TiempoLlegada], [MontoACobrar], [TiempoViaje], [LatitudOrigen], [LongitudOrigen], [LatitudDestino], [LongitudDestino]) VALUES (N'CGR-963', N'Mazda CX-3', N'Negro', 10, CAST(19.00 AS Decimal(18, 2)), 10, N'-12.069034669514785', N'-77.07844734191895', N'-12.091108275451344', N'-77.05325603485107')
INSERT [dbo].[UberAvailable] ([Placa], [MarcaAuto], [ColorAuto], [TiempoLlegada], [MontoACobrar], [TiempoViaje], [LatitudOrigen], [LongitudOrigen], [LatitudDestino], [LongitudDestino]) VALUES (N'LSO-789', N'Toyota RAV4', N'Rojo', 16, CAST(16.00 AS Decimal(18, 2)), 30, N'-12.089453823602089', N'-76.97210139878905', N'-12.091360055131373', N'-77.02832221984863')
INSERT [dbo].[UberAvailable] ([Placa], [MarcaAuto], [ColorAuto], [TiempoLlegada], [MontoACobrar], [TiempoViaje], [LatitudOrigen], [LongitudOrigen], [LatitudDestino], [LongitudDestino]) VALUES (N'MDS-741', N'Toyota TF101', N'Azul', 3, CAST(25.00 AS Decimal(18, 2)), 25, N'-12.086547177694914', N'-76.99537400933059', N'-12.007048986648007', N'-77.0585391122957')
INSERT [dbo].[UberAvailable] ([Placa], [MarcaAuto], [ColorAuto], [TiempoLlegada], [MontoACobrar], [TiempoViaje], [LatitudOrigen], [LongitudOrigen], [LatitudDestino], [LongitudDestino]) VALUES (N'PBC-321', N'Kia Cerato', N'Rojo', 4, CAST(20.00 AS Decimal(18, 2)), 40, N'-12.084816810113443', N'-76.97889518560282', N'-12.07297951590042', N'-77.0595645904541')
INSERT [dbo].[UberAvailable] ([Placa], [MarcaAuto], [ColorAuto], [TiempoLlegada], [MontoACobrar], [TiempoViaje], [LatitudOrigen], [LongitudOrigen], [LatitudDestino], [LongitudDestino]) VALUES (N'QTD-456', N'Kia Optima', N'Plomo', 9, CAST(20.00 AS Decimal(18, 2)), 35, N'-12.07764211971136', N'-76.92885814644194', N'-12.084156625458899', N'-76.96638115200045')
INSERT [dbo].[UberAvailable] ([Placa], [MarcaAuto], [ColorAuto], [TiempoLlegada], [MontoACobrar], [TiempoViaje], [LatitudOrigen], [LongitudOrigen], [LatitudDestino], [LongitudDestino]) VALUES (N'VMB-258', N'Kia Sephia', N'Negro', 1, CAST(30.00 AS Decimal(18, 2)), 32, N'-12.086569843561476', N'-77.09495215342281', N'-12.083611828486012', N'-77.034141181873')
INSERT [dbo].[UberDriver] ([Placa], [Nombres], [Apellidos], [Celular], [ModeloAuto], [Reputacion], [FechaRegistro]) VALUES (N'ACE-322', N'Yan', N'Falcón Anaya', N'956356142', N'Mazda MX-5', 4, CAST(0x0000A74D00000000 AS DateTime))
INSERT [dbo].[UberDriver] ([Placa], [Nombres], [Apellidos], [Celular], [ModeloAuto], [Reputacion], [FechaRegistro]) VALUES (N'BBO-159', N'Fabricio', N'Ruiz Avila', N'978452152', N'Toyota GT86', 3, CAST(0x0000A83F00000000 AS DateTime))
INSERT [dbo].[UberDriver] ([Placa], [Nombres], [Apellidos], [Celular], [ModeloAuto], [Reputacion], [FechaRegistro]) VALUES (N'HER-412', N'Daniel', N'Ramos Capcha', N'987246147', N'Mazda CX-5', 3, CAST(0x0000A85D00000000 AS DateTime))
INSERT [dbo].[UberDriver] ([Placa], [Nombres], [Apellidos], [Celular], [ModeloAuto], [Reputacion], [FechaRegistro]) VALUES (N'QTD-456', N'Alejandro', N'Morales Morales', N'987712456', N'Kia Optima', 3, CAST(0x0000A83D00000000 AS DateTime))
INSERT [dbo].[UberDriver] ([Placa], [Nombres], [Apellidos], [Celular], [ModeloAuto], [Reputacion], [FechaRegistro]) VALUES (N'XJU-236', N'Manuel', N'Cisneros Napravnik', N'917382468', N'Toyota Yaris', 5, CAST(0x0000A96C00000000 AS DateTime))
ALTER TABLE [dbo].[CabifyChofer]  WITH CHECK ADD  CONSTRAINT [FK_AutoPlaca] FOREIGN KEY([AutoPlaca])
REFERENCES [dbo].[CabifyDisponible] ([AutoPlaca])
GO
ALTER TABLE [dbo].[CabifyChofer] CHECK CONSTRAINT [FK_AutoPlaca]
GO
USE [master]
GO
ALTER DATABASE [DB_TAXI_EXTERNO] SET  READ_WRITE 
GO
