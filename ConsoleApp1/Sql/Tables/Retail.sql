IF SCHEMA_ID(N'Farm') IS NULL
EXEC(N'CREATE SCHEMA [Farm];');
GO
DROP TABLE IF EXISTS Farm.Retail;
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
Create Table Farm.Retail
(
	RetailID int Not Null Primary Key,
	PhoneNumber VarChar(20) Not Null,
	[Name] VarChar(100) Not Null,
	RetailFee Decimal(5,2) Check (RetailFee >=0) Not null,
	Unique(PhoneNumber, [Name])
);
