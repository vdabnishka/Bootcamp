MERGE Area AS target
USING (VALUES ('Montreal'), ('Chicago')) AS source (Name)
ON target.Name = source.Name
WHEN NOT MATCHED BY target THEN
	INSERT (Name) VALUES (Name);