﻿CREATE TABLE [dbo].[Area]
(
	[Id] INT NOT NULL Identity(1, 1), 
    [Name] NVARCHAR(20) NULL,

	[RowVersion] ROWVERSION NOT NULL, 
    CONSTRAINT [PK_Area] PRIMARY KEY CLUSTERED (Id)
)
