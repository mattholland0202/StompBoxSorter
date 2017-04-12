CREATE TABLE [dbo].[Accessory]
(
	[AccessoryID] INT NOT NULL IDENTITY,
	[Name] VARCHAR(250) NOT NULL,
	[Width] INT NOT NULL,
	[Height] INT NOT NULL,
	[Depth] INT NOT NULL,
	[Weight] INT,
	[DateCreated] DATETIME NOT NULL,
	[IsVerified] BIT NOT NULL,
	CONSTRAINT [PK_Accessory] PRIMARY KEY ([AccessoryID])
)
