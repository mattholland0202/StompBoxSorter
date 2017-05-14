CREATE TABLE [dbo].[PedalDeploymentJack]
(
	[PedalDeploymentJackID] INT NOT NULL IDENTITY,
	[PedalDeploymentID] INT NOT NULL,
	[PedalJackID] INT NOT NULL,
	[ConnectedJackID] INT,
	[IsInput] BIT NOT NULL,
	[IsOutput] BIT NOT NULL,
	CONSTRAINT [PK_PedalDeploymentJack] PRIMARY KEY (PedalDeploymentJackID),
	CONSTRAINT [FK_PedalDeployment_PedalDeploymentJack] FOREIGN KEY (PedalDeploymentID) REFERENCES dbo.PedalDeployment([PedalDeploymentID]),
	CONSTRAINT [FK_PedalJack_PedalDeploymentJack] FOREIGN KEY (PedalJackID) REFERENCES dbo.PedalJack([PedalJackID]),
	CONSTRAINT [FK_PedalDeploymentJack_PedalDeploymentJack] FOREIGN KEY (ConnectedJackID) REFERENCES dbo.PedalDeploymentJack([PedalDeploymentJackID])
)
