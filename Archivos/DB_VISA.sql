USE [master]
GO
CREATE DATABASE [DB_VISA] 
GO
USE [DB_VISA]
GO
CREATE TABLE [dbo].[Tb_OperacionesTarjeta](
	[IdOperacion] [int] IDENTITY(1,1) NOT NULL,
	[FechaOperacion] [datetime] NULL,
	[Numero] [varchar](20) NULL,
	[Vencimiento] [varchar](5) NULL,
	[CodigoVerificacion] [varchar](5) NULL,
	[Nombre] [varchar](50) NULL,
	[Apellido] [varchar](50) NULL,
	[CorreoElectronico] [varchar](50) NULL,
	[ImporteOperacion] [money] NULL
) ON [PRIMARY]
GO
CREATE PROC [dbo].[Usp_Botica_Tb_OperacionesTarjeta_Insert] 
@Numero VARCHAR(20) = '', 
@Vencimiento VARCHAR(5) = '', 
@CodigoVerificacion VARCHAR(5) = '', 
@Nombre VARCHAR(50) = '', 
@Apellido VARCHAR(50) = '', 
@CorreoElectronico VARCHAR(50) = '', 
@ImporteOperacion MONEY, 
@Resultado INT = 0 OUTPUT 
AS BEGIN TRANSACTION 
	SET NOCOUNT ON
	--
	INSERT INTO Tb_OperacionesTarjeta
						  (FechaOperacion, Numero, Vencimiento, CodigoVerificacion, Nombre, Apellido, CorreoElectronico, ImporteOperacion)
	VALUES     (GETDATE(),@Numero,@Vencimiento,@CodigoVerificacion,@Nombre,@Apellido,@CorreoElectronico,@ImporteOperacion)
	--
	IF @@ERROR <> 0 BEGIN
		ROLLBACK TRANSACTION
		RETURN
	END
	--
	SET @Resultado = SCOPE_IDENTITY()
	--
COMMIT TRANSACTION
GO