USE [SBS.DB]

MERGE INTO PedalType AS TARGET
USING (VALUES 
('Distortion'),
('Overdrive'),
('Delay'),
('Reverb'),
('Pitch'),
('Modulation'),
('Filter'),
('Equalisation'),
('Tuning'),
('Volume'),
('Looping'),
('Switching'),
('Bass')
)
AS SOURCE(Name)
ON TARGET.Name = SOURCE.Name
WHEN NOT MATCHED BY TARGET THEN 
	INSERT (Name)
	VALUES (Name)
WHEN NOT MATCHED BY SOURCE THEN
	DELETE;