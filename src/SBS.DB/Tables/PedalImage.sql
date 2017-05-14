CREATE TABLE [dbo].[PedalImage]
(
	[PedalImageID] INT NOT NULL IDENTITY,
	[PedalID] INT NOT NULL,
	[CreatorID] INT NOT NULL,
	[Image] IMAGE NOT NULL,
	[IsMainImage] BIT NOT NULL,
	[IsVerified] BIT NOT NULL,
	CONSTRAINT [PK_PedalImage] PRIMARY KEY ([PedalImageID]),
	CONSTRAINT [FK_Pedal_PedalImage] FOREIGN KEY ([PedalID]) REFERENCES dbo.Pedal([PedalID]),
	CONSTRAINT [FK_User_PedalImage] FOREIGN KEY ([CreatorID]) REFERENCES dbo.Users([UserID])
)
