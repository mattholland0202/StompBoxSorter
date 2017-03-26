CREATE TABLE [dbo].[PedalJackType]
(
	[PedalJackTypeID] INT NOT NULL IDENTITY,
	[Name] VARCHAR(MAX) NOT NULL,
	CONSTRAINT [PK_PedalJackType] PRIMARY KEY ([PedalJackTypeID])
)
