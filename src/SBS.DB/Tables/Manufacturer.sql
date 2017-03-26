CREATE TABLE [dbo].[Manufacturer]
(
	[ManufacturerID] INT NOT NULL IDENTITY,
	[Name] VARCHAR(250) NOT NULL,
	[ShortName] VARCHAR(50) NOT NULL,
	[DateCreated] DATETIME NOT NULL,
	[IsVerified] BIT NOT NULL, 
    CONSTRAINT [PK_Manufacturer] PRIMARY KEY ([ManufacturerID])
)
