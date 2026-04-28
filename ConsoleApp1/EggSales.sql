Use Farm;
GO
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