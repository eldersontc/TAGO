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
			[LatitudOrigen]  [varchar](50) NULL,
			[LongitudOrigen]  [varchar](50) NULL,
			[LatitudDestino]  [varchar](50) NULL,
			[LongitudDestino]  [varchar](50) NULL,
 CONSTRAINT [PK_UberDriver] PRIMARY KEY CLUSTERED 
(
	[Placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

CREATE TABLE [dbo].[UberAvailable](
			[Placa] [varchar](7) NOT NULL,
			[MarcaAuto] [varchar](50) NULL,
			[ColorAuto] [varchar](50) NULL,
			[TiempoLlegada] time not NULL,
			[MontoACobrar] decimal(18,2) NULL,
			[TiempoViaje] time not NULL,
 CONSTRAINT [PK_UberAvailable] PRIMARY KEY CLUSTERED 
(
	[Placa] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

INSERT INTO [UberDriver] VALUES ('ACE-322','Yan','Falcón Anaya','956356142','Mazda MX-5','4','2017/06/04','-12.0927244','-76.972887','-12.118236714228026','-77.02026554003908');
INSERT INTO [UberDriver] VALUES ('BBO-159','Fabricio','Ruiz Avila','978452152','Toyota GT86','3','2017/04/12','-12.091814540508434','-76.97313407481784','-12.091360055131373','-77.02832221984863');
INSERT INTO [UberDriver] VALUES ('LSO-789','Juan','Tenorio Oliva','963258741','Toyota RAV4','5','2017/11/18','-12.089453823602089','-76.97210139878905','-12.091360055131373','-77.02832221984863');
INSERT INTO [UberDriver] VALUES ('PBC-321','Marcelo','Estrada Suarez','912445236','Kia Cerato','5','2017/01/24','-12.084816810113443','-76.97889518560282','-12.07297951590042','-77.0595645904541');
INSERT INTO [UberDriver] VALUES ('QTD-456','Alejandro','Morales Morales','987712456','Kia Optima','3','2017/02/12','-12.07764211971136','-76.92885814644194','-12.084156625458899','-76.96638115200045');
INSERT INTO [UberDriver] VALUES ('MDS-741','Walter','Avalos Carranza','923412574','Toyota TF101','4','2017/05/26','-12.086547177694914','-76.99537400933059','-12.007048986648007','-77.0585391122957');
INSERT INTO [UberDriver] VALUES ('VMB-258','Mauricio','Cahuana Diez','986745214','Kia Sephia','4','2017/03/14','-12.086569843561476','-77.09495215342281','-12.083611828486012','-77.034141181873');
INSERT INTO [UberDriver] VALUES ('CGR-963','Victor','Briceño Zevallos','932567415','Mazda CX-3','5','2017/06/28','-12.069034669514785','-77.07844734191895','-12.091108275451344','-77.05325603485107');
INSERT INTO [UberDriver] VALUES ('XJU-236','Manuel','Cisneros Napravnik','917382468','Toyota Yaris','5','2018/01/10','-12.083775551085374','-76.99249950809565','-12.072937549755197','-76.95167541503906');
INSERT INTO [UberDriver] VALUES ('HER-412','Daniel','Ramos Capcha','987246147','Mazda CX-5','3','2018/03/01','-12.05427720267192','-76.97659088901992','-12.06886680242281','-76.93648338317871');

INSERT INTO [UberAvailable] VALUES ('ACE-322','Mazda MX-5','Negro','00:02:00','10.00','00:02:00');
INSERT INTO [UberAvailable] VALUES ('BBO-159','Toyota GT86','Blanco','00:05:00','23.00','00:40:00');
INSERT INTO [UberAvailable] VALUES ('LSO-789','Toyota RAV4','Rojo','00:16:00','16.00','00:30:00');
INSERT INTO [UberAvailable] VALUES ('PBC-321','Kia Cerato','Rojo','00:04:00','20.00','00:40:00');
INSERT INTO [UberAvailable] VALUES ('QTD-456','Kia Optima','Plomo','00:09:00','20.00','00:35:00');
INSERT INTO [UberAvailable] VALUES ('MDS-741','Toyota TF101','Azul','00:03:00','25.00','00:25:00');
INSERT INTO [UberAvailable] VALUES ('VMB-258','Kia Sephia','Negro','00:01:00','30.00','00:32:00');
INSERT INTO [UberAvailable] VALUES ('CGR-963','Mazda CX-3','Negro','00:10:00','19.00','00:10:00');
INSERT INTO [UberAvailable] VALUES ('XJU-236','Toyota Yaris','Blanco','00:03:00','18.00','00:20:00');
INSERT INTO [UberAvailable] VALUES ('HER-412','Mazda CX-5','Plomo','00:12:00','15.00','00:30:00');



--FERNANDO DB PARA CABIFY
USE [DB_TAXI_EXTERNO];
CREATE TABLE [CabifyDisponible]
(
[AutoPlaca]			varchar(7) PRIMARY KEY NOT NULL,
[TiempoLlegada]		time not null,
[TiempoViaje]		time not null,
[Monto]				nvarchar(8),
[OLatitud]			nvarchar(50),
[OLongitud]			nvarchar(50),
[DLatitud]			nvarchar(50),
[DLongitud]			nvarchar(50)
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

INSERT INTO [CabifyDisponible] VALUES ('BBH-322','00:07:00','00:20:00','S/ 10.00','-12.128926','-76.981296','-12.111555','-77.002496');
INSERT INTO [CabifyDisponible] VALUES ('JDB-159','00:08:00','00:25:00','S/ 17.00','-12.113611','-77.024984','-12.125695','-77.022195');
INSERT INTO [CabifyDisponible] VALUES ('LSO-789','00:09:00','00:35:00','S/ 18.00','-12.124352','-77.031336','-12.118966','-77.040036');
INSERT INTO [CabifyDisponible] VALUES ('PBC-321','00:10:00','01:02:00','S/ 20.00','-12.113343','-77.031453','-12.108098','-77.007420');
INSERT INTO [CabifyDisponible] VALUES ('QTD-456','00:11:00','01:08:00','S/ 20.00','-12.103650','-77.030079','-12.100502','-76.969568');
INSERT INTO [CabifyDisponible] VALUES ('MDS-741','00:12:00','01:15:00','S/ 25.00','-12.084807','-76.971413','-12.066803','-77.033898');
INSERT INTO [CabifyDisponible] VALUES ('WSX-258','00:13:00','01:20:00','S/ 30.00','-12.057738','-77.035400','-12.131984','-77.030711');
INSERT INTO [CabifyDisponible] VALUES ('HRT-963','00:14:00','00:42:00','S/ 19.00','-12.118725','-77.044787','-12.078987','-77.088475');
INSERT INTO [CabifyDisponible] VALUES ('XJU-236','00:15:00','00:35:00','S/ 18.00','-12.064634','-77.127528','-12.059410','-77.147819');
INSERT INTO [CabifyDisponible] VALUES ('VSP-412','00:16:00','00:28:00','S/ 15.00','-12.068474','-77.041901','-12.055506','-77.017525');
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



