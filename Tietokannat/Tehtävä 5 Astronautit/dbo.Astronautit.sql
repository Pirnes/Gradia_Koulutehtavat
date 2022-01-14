CREATE TABLE [dbo].[Astronautit] (
    [Astronautti_Id]                        INT          IDENTITY (1, 1) NOT NULL,
    [Etunimi]                               VARCHAR (50) NULL,
    [Sukunimi]                              VARCHAR (50) NULL,
    [Syntymä-aika]                          DATE         NULL,
    [Avaruudessa vietetty aika (Minuuttia)] INT          NULL,
    [Sukupuoli]                             TINYINT      NULL,
    [Kansalaisuus]                          VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Astronautti_Id] ASC)
);

