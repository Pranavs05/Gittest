CREATE TABLE [dbo].[ListedPropertyType]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [Description] VARCHAR(100) NOT NULL,
    [Abbr] VARCHAR(100) NULL

	CONSTRAINT [PK_ListedPropertyType_Id] PRIMARY KEY(Id)
)
