USE [master]
GO
CREATE DATABASE [DB_VISA] 
GO
USE [DB_VISA]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Botica_Tb_OperacionesTarjeta_Insert]    Script Date: 05/04/2018 17:25:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usp_Botica_Tb_OperacionesTarjeta_Insert]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Usp_Botica_Tb_OperacionesTarjeta_Insert]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Botica_Tb_Tarjeta_Select]    Script Date: 05/04/2018 17:25:49 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usp_Botica_Tb_Tarjeta_Select]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[Usp_Botica_Tb_Tarjeta_Select]
GO
/****** Object:  Table [dbo].[Tb_OperacionesTarjeta]    Script Date: 05/04/2018 17:25:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tb_OperacionesTarjeta]') AND type in (N'U'))
DROP TABLE [dbo].[Tb_OperacionesTarjeta]
GO
/****** Object:  Table [dbo].[Tb_Tarjeta]    Script Date: 05/04/2018 17:25:48 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tb_Tarjeta]') AND type in (N'U'))
DROP TABLE [dbo].[Tb_Tarjeta]
GO
/****** Object:  Table [dbo].[Tb_Tarjeta]    Script Date: 05/04/2018 17:25:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tb_Tarjeta]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tb_Tarjeta](
	[Numero] [varchar](20) NULL,
	[Vencimiento] [varchar](5) NULL,
	[CodigoVerificacion] [varchar](5) NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[CorreoElectronico] [varchar](50) NULL,
	[ImporteSaldo] [money] NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
INSERT [dbo].[Tb_Tarjeta] ([Numero], [Vencimiento], [CodigoVerificacion], [Nombre], [Apellido], [CorreoElectronico], [ImporteSaldo]) VALUES (N'123456789101112', N'01/19', N'123', N'Juan', N'Perez', N'juan@juancito.com', 10.0000)
/****** Object:  Table [dbo].[Tb_OperacionesTarjeta]    Script Date: 05/04/2018 17:25:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Tb_OperacionesTarjeta]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Tb_OperacionesTarjeta](
	[IdOperacion] [int] IDENTITY(1,1) NOT NULL,
	[Numero] [varchar](20) NULL,
	[ImporteOperacion] [money] NULL,
	[FechaOperacion] [datetime] NULL
) ON [PRIMARY]
END
GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[Tb_OperacionesTarjeta] ON
INSERT [dbo].[Tb_OperacionesTarjeta] ([IdOperacion], [Numero], [ImporteOperacion], [FechaOperacion]) VALUES (1, N'', 0.0000, CAST(0x0000A8D6011B285D AS DateTime))
INSERT [dbo].[Tb_OperacionesTarjeta] ([IdOperacion], [Numero], [ImporteOperacion], [FechaOperacion]) VALUES (2, N'', 0.0000, CAST(0x0000A8D6011B29BD AS DateTime))
INSERT [dbo].[Tb_OperacionesTarjeta] ([IdOperacion], [Numero], [ImporteOperacion], [FechaOperacion]) VALUES (3, N'', 0.0000, CAST(0x0000A8D6011B2A79 AS DateTime))
INSERT [dbo].[Tb_OperacionesTarjeta] ([IdOperacion], [Numero], [ImporteOperacion], [FechaOperacion]) VALUES (4, N'', 0.0000, CAST(0x0000A8D6011B2B1A AS DateTime))
INSERT [dbo].[Tb_OperacionesTarjeta] ([IdOperacion], [Numero], [ImporteOperacion], [FechaOperacion]) VALUES (5, N'123456789101112', 1.0000, CAST(0x0000A8D6011B42FA AS DateTime))
INSERT [dbo].[Tb_OperacionesTarjeta] ([IdOperacion], [Numero], [ImporteOperacion], [FechaOperacion]) VALUES (6, N'123456789101112', 1.0000, CAST(0x0000A8D6011B4483 AS DateTime))
SET IDENTITY_INSERT [dbo].[Tb_OperacionesTarjeta] OFF
/****** Object:  StoredProcedure [dbo].[Usp_Botica_Tb_Tarjeta_Select]    Script Date: 05/04/2018 17:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usp_Botica_Tb_Tarjeta_Select]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[Usp_Botica_Tb_Tarjeta_Select] 
@Numero VARCHAR(20) = '''', 
@Resultado INT = 0 OUTPUT 
AS BEGIN  
	SET NOCOUNT ON
	--
	SELECT     Numero, Vencimiento, CodigoVerificacion, Nombre, Apellido, CorreoElectronico, ISNULL(ImporteSaldo, 0) AS ImporteSaldo
	FROM         Tb_Tarjeta
	WHERE     (Numero = @Numero)
	--
END
' 
END
GO
/****** Object:  StoredProcedure [dbo].[Usp_Botica_Tb_OperacionesTarjeta_Insert]    Script Date: 05/04/2018 17:25:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Usp_Botica_Tb_OperacionesTarjeta_Insert]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'CREATE PROC [dbo].[Usp_Botica_Tb_OperacionesTarjeta_Insert] 
@Numero VARCHAR(20) = '''', 
@ImporteOperacion MONEY, 
@Resultado INT = 0 OUTPUT 
AS BEGIN TRANSACTION 
	SET NOCOUNT ON
	--
	UPDATE    Tb_Tarjeta
	SET              ImporteSaldo -= @ImporteOperacion
	WHERE     (Numero = @Numero)
	--
	IF @@ERROR <> 0 BEGIN
		ROLLBACK TRANSACTION
		RETURN
	END
	--
	INSERT INTO Tb_OperacionesTarjeta
						  (Numero, ImporteOperacion, FechaOperacion)
	VALUES     (@Numero,@ImporteOperacion,GETDATE())
	--
	IF @@ERROR <> 0 BEGIN
		ROLLBACK TRANSACTION
		RETURN
	END
	--
	SET @Resultado = SCOPE_IDENTITY()
	--
COMMIT TRANSACTION
' 
END
GO
