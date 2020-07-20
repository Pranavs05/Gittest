CREATE TABLE [dbo].[AssetMethodCategory]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [Description] VARCHAR(100) NOT NULL,
    [Abbr] VARCHAR(100) NULL

	CONSTRAINT [PK_AssetMethodCategory_Id] PRIMARY KEY(Id)
)
