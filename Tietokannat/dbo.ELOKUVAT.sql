CREATE TABLE [dbo].[ELOKUVAT] (
    [Id]          INT           IDENTITY (1, 1) NOT NULL,
    [Nimi]        VARCHAR (150) NULL,
    [JulkaisuPVM] DATE          NULL,
    [Kesto]       TINYINT       NULL,
    [Arvio]       DECIMAL (2, 1)NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

