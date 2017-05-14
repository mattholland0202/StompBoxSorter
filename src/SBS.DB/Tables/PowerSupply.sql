CREATE TABLE [dbo].[PowerSupply]
(
	[PowerSupplyID] INT NOT NULL IDENTITY,
	[ManufacturerID] INT NOT NULL,
	[CreatorID] INT NOT NULL,
	[Name] VARCHAR(200) NOT NULL,
	[Width] INT NOT NULL,
	[Height] INT NOT NULL,
	[Depth] INT NOT NULL,
	[Weight] INT,
	[TotalCurrentSupply] INT NOT NULL,
	[DateCreated] DATETIME NOT NULL,
	[IsVerified] BIT NOT NULL,
	CONSTRAINT [PK_PowerSupply] PRIMARY KEY (PowerSupplyID),
	CONSTRAINT [FK_Manufacturer_PowerSupply] FOREIGN KEY ([ManufacturerID]) REFERENCES dbo.Manufacturer([ManufacturerID]),
	CONSTRAINT [FK_User_PowerSupply] FOREIGN KEY ([CreatorID]) REFERENCES dbo.Users([UserID])
)
