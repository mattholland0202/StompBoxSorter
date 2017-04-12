CREATE TABLE [dbo].[Board]
(
	[BoardID] INT NOT NULL IDENTITY,
	[ManufacturerID] INT NOT NULL,
	[Name] VARCHAR(250) NOT NULL,
	[ShortName] VARCHAR(25) NOT NULL,
	[Width] INT NOT NULL,
	[Height] INT NOT NULL,
	[Weight] INT,
	[DateCreated] DATETIME NOT NULL,
	[IsVerified] BIT NOT NULL,
	CONSTRAINT [PK_Board] PRIMARY KEY (BoardID),
	CONSTRAINT [FK_Manufacturer_Board] FOREIGN KEY ([ManufacturerID]) REFERENCES dbo.Manufacturer([ManufacturerID])
)
