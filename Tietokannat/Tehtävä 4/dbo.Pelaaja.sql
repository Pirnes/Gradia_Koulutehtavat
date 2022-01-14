CREATE TABLE [dbo].[Pelaaja] (
    [Pelaaja_Id]  INT           IDENTITY (1, 1) NOT NULL,
    [Nimi]        VARCHAR (150) NULL,
    [Sukupuoli]   TINYINT       NULL,
    [Lähiosoite]  VARCHAR (300) NULL,
    [Postiosoite] INT           NULL,
    [Puhelin]     NUMERIC (10,0)NULL,
    [E-Mail]      VARCHAR (300) NULL,
    PRIMARY KEY CLUSTERED ([Pelaaja_Id] ASC)
);

