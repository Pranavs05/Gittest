CREATE TABLE [dbo].[PropertyTypeCode]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [Code] INT NOT NULL, 
    [Description] VARCHAR(100) NOT NULL

    CONSTRAINT [PK_PropertyTypeCode_Id] PRIMARY KEY (Id)
)
