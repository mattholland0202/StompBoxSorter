CREATE TABLE [dbo].[AccessoryDeployment]
(
	[AccessoryDeploymentID] INT NOT NULL IDENTITY,
	[BoardDeploymentID] INT NOT NULL,
	[AccessoryID] INT NOT NULL,
	[PositionX] INT NOT NULL,
	[PositionY] INT NOT NULL,
	[Created] DATETIME NOT NULL,
	CONSTRAINT [PK_AccessoryDeployment] PRIMARY KEY (AccessoryDeploymentID),
	CONSTRAINT [FK_BoardDeployment_AccessoryDeployment] FOREIGN KEY ([BoardDeploymentID]) REFERENCES dbo.BoardDeployment([BoardDeploymentID]),
	CONSTRAINT [FK_Accessory_AccessoryDeployment] FOREIGN KEY ([AccessoryID]) REFERENCES dbo.Accessory([AccessoryID])
)
