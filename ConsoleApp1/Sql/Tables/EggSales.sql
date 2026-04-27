IF SCHEMA_ID(N'Farm') IS NULL
EXEC(N'CREATE SCHEMA [Farm];');
GO
DROP TABLE IF EXISTS Farm.EggSales;
GO
/******************
* Create Tables
******************/
CREATE TABLE Farm.Farm
(
	FarmId INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	[Name] NVARCHAR(64) NOT NULL UNIQUE,
	Purpose NVARCHAR(1024) NOT NULL,
	CreatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET()),
	UpdatedOn DATETIMEOFFSET NOT NULL DEFAULT(SYSDATETIMEOFFSET())
);
Create Table EggSales
(
	EggSalesID int Not Null Primary Key,
	UnitPrice Decimal(10,2) NOt Null,
	AvgUnit Int CHECK(AvgUnit > 0),
	BatchEggID int not null Foreign key
		References Demo.BatchEgg(BatchEggID),
	RetailID int not null Foreign Key
		References Demo.Retail(RetailID),
	CanceledOn Datetime Null,
	Unique(BatchEggID, RetailID)
);
