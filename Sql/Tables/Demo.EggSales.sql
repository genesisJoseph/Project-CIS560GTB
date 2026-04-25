if OBJECT_ID(N'Demo.EggSales') Is Null
Begin
Create Table Demo.EggSales
(
	EggSalesID int Not Null Primary Key,
	UnitPrice Decimal(10,2) NOt Null,
	BatchEggID int not null Foreign key
		References Demo.BatchEgg(BatchEggID),
	RetailID int not null Foreign Key
		References Demo.Retail(RetailID),
	CanceledOn Datetime Null,
	Unique(BatchEggID, RetailID)
);
End