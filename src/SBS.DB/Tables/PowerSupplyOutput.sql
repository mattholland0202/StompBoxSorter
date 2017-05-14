CREATE TABLE [dbo].[PowerSupplyOutput]
(
	[PowerSupplyOutputID] INT NOT NULL IDENTITY,
	[PowerSupplyID] INT NOT NULL,
	[Voltage] INT NOT NULL,
	[IsDcPower] BIT NOT NULL,
	CONSTRAINT [PK_PowerSupplyOutput] PRIMARY KEY (PowerSupplyOutputID),
	CONSTRAINT [FK_PowerSupply_PowerSupplyOutput] FOREIGN KEY ([PowerSupplyID]) REFERENCES dbo.PowerSupply([PowerSupplyID])
)
