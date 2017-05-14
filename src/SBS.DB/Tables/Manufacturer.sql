CREATE TABLE [dbo].[Manufacturer]
(
	[ManufacturerID] INT NOT NULL IDENTITY,
	[CreatorID] INT NOT NULL,
	[Name] VARCHAR(250) NOT NULL,
	[ShortName] VARCHAR(50) NOT NULL,
	[DateCreated] DATETIME NOT NULL,
	[IsVerified] BIT NOT NULL, 
    CONSTRAINT [PK_Manufacturer] PRIMARY KEY ([ManufacturerID]),
	CONSTRAINT [FK_User_Manufacturer] FOREIGN KEY (CreatorID) REFERENCES dbo.Users([UserID])
)
