CREATE TABLE [dbo].[PedalPowerConnection]
(
	[PedalPowerConnectionID] INT NOT NULL IDENTITY,
	[PedalID] INT NOT NULL,
	[Voltage] INT NOT NULL,
	[IsDcPower] BIT NOT NULL,
	[HasBatteryConnection] BIT NOT NULL,
	[CurrentDraw] INT
)
