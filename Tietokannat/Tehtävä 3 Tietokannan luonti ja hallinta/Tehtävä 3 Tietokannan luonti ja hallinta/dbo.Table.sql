﻿CREATE TABLE [dbo].[ELOKUVAT]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Nimi] VARCHAR (150) NULL,
	[JulkaisuPVM] DATE NULL,
	[Kesto] TINYINT NULL,
	[Arvio (IMDB)] DECIMAL (2,1) NULL,
)
