CREATE TABLE [dbo].[Asset]
(
	[Id] INT NOT NULL IDENTITY(1,1), 
    [AssetNumber] INT NOT NULL, 
    [ActivityCategory] VARCHAR(100) NULL, 
    [AssetCategoryId] INT NOT NULL, 
    [Description] VARCHAR(100) NOT NULL, 
    [DateInService] DATETIME2 NOT NULL, 
    [Cost] MONEY NOT NULL , 
    [BusinessPercentage] FLOAT NOT NULL , 
    [ListedPropertyTypeId] INT NULL, 
    [MethodId] INT NOT NULL, 
    [Life] FLOAT NOT NULL, 
    [PriorRegDepreciation] MONEY NULL, 
    [PriorBonusDepriciation] MONEY NULL, 
    [PriorExpSec179] MONEY NULL, 
    [PropertyTypeCodeId] INT NOT NULL, 
    [AmortizationCodeId] INT NULL, 
    [ConventionId] INT NOT NULL, 
    [CurrentDepriciation] MONEY NULL, 
    [CurrentYearExpSec179] MONEY NULL, 
    [BonusDepriciation] MONEY NULL

    CONSTRAINT [PK_Asset_Id] PRIMARY KEY (Id), 
    CONSTRAINT [FK_Asset_AssetCategory] FOREIGN KEY ([AssetCategoryId]) REFERENCES [AssetCategory]([Id]), 
    CONSTRAINT [FK_Asset_ListedPropertyType] FOREIGN KEY ([ListedPropertyTypeId]) REFERENCES [ListedPropertyType]([Id]), 
    CONSTRAINT [FK_Asset_AssetMethodCategory] FOREIGN KEY ([MethodId]) REFERENCES [AssetMethodCategory]([Id]), 
    CONSTRAINT [FK_Asset_PropertyTypeCode] FOREIGN KEY ([PropertyTypeCodeId]) REFERENCES [PropertyTypeCode]([Id]), 
    CONSTRAINT [FK_Asset_AmortizationCode] FOREIGN KEY ([AmortizationCodeId]) REFERENCES [AmortizationCode]([Id]), 
    CONSTRAINT [FK_Asset_AssetConvention] FOREIGN KEY ([ConventionId]) REFERENCES [AssetConvention]([Id])

	
)
