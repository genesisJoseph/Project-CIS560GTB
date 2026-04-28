Use Farm;
Go
Create Table dbo.Retail
(
	RetailID int Not Null Primary Key,
	PhoneNumber VarChar(20) Not Null,
	[Name] VarChar(100) Not Null,
	RetailFee Decimal(5,2) Check (RetailFee >=0) Not null,
	Unique(PhoneNumber, [Name])
);