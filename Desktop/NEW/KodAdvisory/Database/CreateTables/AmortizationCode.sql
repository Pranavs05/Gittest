CREATE TABLE [dbo].[AmortizationCode]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [Code] INT NOT NULL, 
    [Description] VARCHAR(100) NOT NULL

    CONSTRAINT [PK_AmortizationCode_Id] PRIMARY KEY (Id)
)
