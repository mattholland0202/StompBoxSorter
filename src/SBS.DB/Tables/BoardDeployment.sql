CREATE TABLE [dbo].[BoardDeployment]
(
	[BoardDeploymentID] INT NOT NULL IDENTITY,
	[BoardID] INT NOT NULL,
	[AuthorID] INT NOT NULL,
	[Name] VARCHAR(250) NOT NULL,
	[Description] VARCHAR(MAX),
	[Created] DATETIME NOT NULL,
	[LastUpdated] DATETIME NOT NULL
	CONSTRAINT [PK_BoardDeployment] PRIMARY KEY (BoardDeploymentID),
	CONSTRAINT [FK_Board_BoardDeployment] FOREIGN KEY ([BoardID]) REFERENCES dbo.Board([BoardID]),
	CONSTRAINT [FK_User_BoardDeployment] FOREIGN KEY ([AuthorID]) REFERENCES dbo.Users([UserID])
)
