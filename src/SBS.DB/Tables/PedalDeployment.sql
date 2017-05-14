CREATE TABLE [dbo].[PedalDeployment]
(
	[PedalDeploymentID] INT NOT NULL IDENTITY,
	[PedalID] INT NOT NULL,
	[BoardDeploymentID] INT NOT NULL,
	[PositionX] INT NOT NULL,
	[PositionY] INT NOT NULL,
	[Created] DATETIME NOT NULL,
	CONSTRAINT [PK_PedalDeployment] PRIMARY KEY (PedalDeploymentID),
	CONSTRAINT [FK_Pedal_PedalDeployment] FOREIGN KEY (PedalID) REFERENCES dbo.Pedal([PedalID]),
	CONSTRAINT [FK_BoardDeployment_PedalDeployment] FOREIGN KEY (BoardDeploymentID) REFERENCES dbo.BoardDeployment([BoardDeploymentID])
)
