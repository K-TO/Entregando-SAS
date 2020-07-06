USE [EntregandoDB]
GO
/* Agrega un nuevo viaje */
/****** Object:  StoredProcedure [dbo].[spAgregarViaje] ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[spAgregarViaje]

@EmpleadoId INT,
@VehiculoId INT,
@CiudadSalida VARCHAR(50),
@CiudadDestino VARCHAR(50),
@NombrePasajero VARCHAR(50),
@FechaSalida DATETIME,
@FechaLlegada DATETIME = null,
@ArticuloEntregado BIT,
@ViajeCancelado BIT

AS
BEGIN

SET NOCOUNT ON;
SET DATEFORMAT ymd;
	BEGIN TRY
		INSERT INTO Viaje (CiudadSalida, CiudadDestino, FechaSalida, FechaLlegada, ArticuloEntregado, NombrePasajero, VehiculoId, ViajeCancelado)
		Values(
			@CiudadSalida,
			@CiudadDestino,
			@FechaSalida,
			@FechaLlegada,
			@ArticuloEntregado,
			@NombrePasajero,
			@VehiculoId,
			@ViajeCancelado
		);
		SELECT 1
	END TRY
	BEGIN CATCH
		SELECT 0
	END CATCH
	SET NOCOUNT OFF;
END
GO
/* Obtiene los viajes realizados por un empleado. */
/****** Object:  StoredProcedure [dbo].[spObtenerViajesEmpleado]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[spObtenerViajesEmpleado]

@EmpleadoId INT

AS
BEGIN

SET NOCOUNT ON;
SET DATEFORMAT ymd;
	BEGIN
		SELECT
			Vi.CiudadSalida,
			Vi.CiudadDestino,
			Vi.NombrePasajero,
			Ve.Placa,
			COUNT(Vi.Id) AS ViajesRealizados,
			Vi.FechaSalida,
			Vi.FechaLlegada,
			CASE
				WHEN Vi.ArticuloEntregado = 1 THEN 'Si' ELSE 'No'
			END AS ArticuloEntregado,
			CASE
				WHEN Vi.ViajeCancelado = 1 THEN 'Si' ELSE 'No'
			END AS ViajeCancelado,
			DATEDIFF(DAY, Vi.FechaSalida, Vi.FechaLlegada) AS DiasDeViaje
		FROM Empleado Em
			INNER JOIN Empleado_Viaje Ev ON Em.Id = Ev.EmpleadoId
			INNER JOIN Viaje Vi ON Ev.ViajeId = Vi.Id
			INNER JOIN Vehiculo Ve ON Vi.VehiculoId = Ve.Id
		WHERE Em.Id = @EmpleadoId
		GROUP BY
			Vi.CiudadSalida,
			Vi.CiudadDestino,
			Vi.Id,
			Vi.FechaSalida,
			Vi.FechaLlegada,
			Vi.NombrePasajero,
			Ve.Placa,
			Vi.FechaSalida,
			Vi.FechaLlegada,
			Vi.ArticuloEntregado,
			vi.ViajeCancelado
		ORDER BY 
			Vi.FechaSalida ASC
	END
SET NOCOUNT OFF;
END
GO
/* Obtiene los viajes realizados por un empleado usando datos para filtrar como fecha, placa. */
/****** Object:  StoredProcedure [dbo].[spObtenerViajesEmpleadoFilter]  ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[spObtenerViajesEmpleadoFilter]
@Fecha DATETIME,
@EmpleadoId INT,
@PlacaVehiculo VARCHAR(30)
AS
BEGIN

SET NOCOUNT ON;
SET DATEFORMAT ymd;
	BEGIN
		SELECT
			Vi.CiudadSalida,
			Vi.CiudadDestino,
			Vi.NombrePasajero,
			Ve.Placa,
			COUNT(Vi.Id) AS ViajesRealizados,
			Vi.FechaSalida,
			Vi.FechaLlegada,
			CASE
				WHEN Vi.ArticuloEntregado = 1 THEN 'Si' ELSE 'No'
			END AS ArticuloEntregado,
			CASE
				WHEN Vi.ViajeCancelado = 1 THEN 'Si' ELSE 'No'
			END AS ViajeCancelado,
			DATEDIFF(DAY, Vi.FechaSalida, Vi.FechaLlegada) AS DiasDeViaje
		FROM Empleado Em
			INNER JOIN Empleado_Viaje Ev ON Em.Id = Ev.EmpleadoId
			INNER JOIN Viaje Vi ON Ev.ViajeId = Vi.Id
			INNER JOIN Vehiculo Ve ON Vi.VehiculoId = Ve.Id
		WHERE 
			Em.Id = (CASE WHEN @EmpleadoId > 0 THEN @EmpleadoId ELSE Em.Id END)
			AND Ve.Placa LIKE (CASE WHEN @PlacaVehiculo != '' THEN '%'+@PlacaVehiculo+'%' ELSE '%'+Ve.Placa+'%' END)
			AND CONVERT(DATE, @Fecha) BETWEEN CONVERT(DATE, Vi.FechaSalida) AND CONVERT(DATE, Vi.FechaLlegada)
		GROUP BY
			Vi.CiudadSalida,
			Vi.CiudadDestino,
			Vi.Id,
			Vi.FechaSalida,
			Vi.FechaLlegada,
			Vi.NombrePasajero,
			Ve.Placa,
			Vi.FechaSalida,
			Vi.FechaLlegada,
			Vi.ArticuloEntregado,
			vi.ViajeCancelado
		ORDER BY 
			Vi.FechaSalida ASC
	END
SET NOCOUNT OFF;
END
GO