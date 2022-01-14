CREATE TABLE [dbo].[Pelaaja]
(
	[Pelaaja_Id] INT NOT NULL PRIMARY KEY IDENTITY,
	[Nimi] VARCHAR (150) NULL,
	[Sukupuoli] TINYINT NULL,
	[Lähiosoite] VARCHAR (300) NULL,
	[Postiosoite] INT NULL,
	[Puhelin]	INT NULL,
	[E-Mail]	VARCHAR (300) NULL,
)
