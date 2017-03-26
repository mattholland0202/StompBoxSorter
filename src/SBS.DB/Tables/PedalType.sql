CREATE TABLE [dbo].[PedalType]
(
	[PedalTypeID] INT NOT NULL IDENTITY,
	[Name] VARCHAR(100) NOT NULL, 
    CONSTRAINT [PK_PedalType] PRIMARY KEY ([PedalTypeID])
)
