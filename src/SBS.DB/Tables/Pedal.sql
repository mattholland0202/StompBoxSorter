CREATE TABLE [dbo].[Pedal]
(
	[PedalID] INT NOT NULL IDENTITY,
	[ManufacturerID] INT NOT NULL,
	[CreatorID] INT NOT NULL,
	[Name] VARCHAR(250) NOT NULL,
	[ShortName] VARCHAR(25) NOT NULL,
	[AlternateName] VARCHAR(250),
	[TrueBypass] BIT NOT NULL,
	[Width] INT NOT NULL,
	[Height] INT NOT NULL,
	[Depth] INT NOT NULL,
	[Weight] INT,
	CONSTRAINT [PK_Pedal] PRIMARY KEY ([PedalID]),
	CONSTRAINT [FK_Manufacturer_Pedal] FOREIGN KEY ([ManufacturerID]) REFERENCES dbo.Manufacturer([ManufacturerID]),
	CONSTRAINT [FK_User_Pedal] FOREIGN KEY ([CreatorID]) REFERENCES dbo.Users([UserID])
)
