CREATE TABLE [dbo].[AssetCategory]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [Description] VARCHAR(100) NOT NULL

	CONSTRAINT [PK_AssetCategory_Id] PRIMARY KEY(Id)
)
