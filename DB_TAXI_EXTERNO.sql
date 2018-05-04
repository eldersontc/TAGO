﻿USE [master]
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