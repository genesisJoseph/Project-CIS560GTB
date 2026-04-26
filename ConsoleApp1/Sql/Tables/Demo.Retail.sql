if OBJECT_ID(N'Demo.Retail') Is Null
Begin
Create Table Demo.Retail
(
	RetailID int Not Null Primary Key,
	PhoneNumber VarChar(20) Not Null,
	[Name] VarChar(20) Not Null,
	RetailFee Decimal(5,4) Not null,
	Unique(PhoneNumber, [Name])
);
End