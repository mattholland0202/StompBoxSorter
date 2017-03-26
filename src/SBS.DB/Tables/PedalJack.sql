CREATE TABLE [dbo].[PedalJack]
(
	[PedalJackID] INT NOT NULL IDENTITY,
	[PedalID] INT NOT NULL,
	[PedalJackTypeID] INT NOT NULL,
	[Name] VARCHAR(MAX) NOT NULL,
	CONSTRAINT [PK_PedalJack] PRIMARY KEY ([PedalJackID]),
	CONSTRAINT [FK_Pedal_PedalJack] FOREIGN KEY ([PedalID]) REFERENCES dbo.Pedal([PedalID]),
	CONSTRAINT [FK_PedalJackType_PedalJack] FOREIGN KEY ([PedalJackTypeID]) REFERENCES dbo.PedalJackType([PedalJackTypeID])
)
