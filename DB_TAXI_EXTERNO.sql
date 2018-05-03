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

--FERNANDO DB PARA CABIFY
USE [DB_TAXI_EXTERNO];
CREATE TABLE [CabifyDisponible]
(
[AutoPlaca]			varchar(7) PRIMARY KEY NOT NULL,
[TiempoLlegada]		time not null,
[TiempoViaje]		time not null,
[Monto]				nvarchar(8)
);
CREATE TABLE [CabifyChofer]
(
[Codigo] varchar(4) PRIMARY KEY NOT NULL,
[Nombres] varchar(50) NULL,
[Apellidos] varchar(50) NULL,
[Celular] varchar(50) NULL,
[Reputacion] int NULL,
[FechaRegistro] datetime NULL,
[AutoPlaca] varchar (7),
[AutoMarca] varchar (50) NULL,
[AutoModelo] varchar (50) NULL,
CONSTRAINT FK_AutoPlaca FOREIGN KEY (AutoPlaca)
REFERENCES [CabifyDisponible](AutoPlaca)
);

INSERT INTO [CabifyDisponible] VALUES ('BBH-322','00:07:00','00:20:00','S/ 10.00');
INSERT INTO [CabifyDisponible] VALUES ('JDB-159','00:08:00','00:25:00','S/ 17.00');
INSERT INTO [CabifyDisponible] VALUES ('LSO-789','00:09:00','00:35:00','S/ 18.00');
INSERT INTO [CabifyDisponible] VALUES ('PBC-321','00:10:00','01:02:00','S/ 20.00');
INSERT INTO [CabifyDisponible] VALUES ('QTD-456','00:11:00','01:08:00','S/ 20.00');
INSERT INTO [CabifyDisponible] VALUES ('MDS-741','00:12:00','01:15:00','S/ 25.00');
INSERT INTO [CabifyDisponible] VALUES ('WSX-258','00:13:00','01:20:00','S/ 30.00');
INSERT INTO [CabifyDisponible] VALUES ('HRT-963','00:14:00','00:42:00','S/ 19.00');
INSERT INTO [CabifyDisponible] VALUES ('XJU-236','00:15:00','00:35:00','S/ 18.00');
INSERT INTO [CabifyDisponible] VALUES ('VSP-412','00:16:00','00:28:00','S/ 15.00');
INSERT INTO [CabifyChofer] VALUES ('C001','Hector','Gimenez Diaz','956356142','4','20/11/2017','BBH-322','Mazda','MX-5');
INSERT INTO [CabifyChofer] VALUES ('C002','Alberto','Chavez Ortiz','978452152','3','12/04/2017','JDB-159','Toyota','GT86');
INSERT INTO [CabifyChofer] VALUES ('C003','Juan','Namuche Tanta','963258741','5','18/10/2017','LSO-789','Toyota','RAV4');
INSERT INTO [CabifyChofer] VALUES ('C004','Carlos','Zapata Del Rio','912445236','5','24/09/2017','PBC-321','Kia','Cerato');
INSERT INTO [CabifyChofer] VALUES ('C005','Omar','Ipanaque Arevalo','987712456','3','12/08/2017','QTD-456','Kia','Optima');
INSERT INTO [CabifyChofer] VALUES ('C006','Edwin','Susanibar Oblitas','923412574','4','26/07/2017','MDS-741','Toyota','TF101');
INSERT INTO [CabifyChofer] VALUES ('C007','Dante','Mamani Quispe','986745214','4','14/06/2017','WSX-258','Kia','Sephia');
INSERT INTO [CabifyChofer] VALUES ('C008','Raul','Franco Navarro','932567415','5','28/05/2017','HRT-963','Mazda','CX-3');
INSERT INTO [CabifyChofer] VALUES ('C009','Julio','Salvador Chuquipul','917382468','5','10/04/2017','XJU-236','Toyota','Yaris');
INSERT INTO [CabifyChofer] VALUES ('C010','Eduardo','Huaman Huaypa','987246147','4','28/03/2017','VSP-412','Mazda','CX-5');


--select  (C.Nombres+' '+C.Apellidos) as 'Chofer', C.AutoMarca, C.AutoModelo, C.AutoPlaca, D.TiempoLlegada, D.TiempoViaje, D.Monto FROM CabifyDisponible D INNER JOIN CabifyChofer C ON D.AutoPlaca = C.AutoPlaca