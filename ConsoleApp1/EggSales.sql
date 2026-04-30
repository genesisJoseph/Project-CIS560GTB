Use Farm;
GO
Create Table EggSales
(
	EggSalesID INT IDENTITY(1,1) PRIMARY KEY,
	UnitPrice Decimal(10,2) NOt Null,
	AvgUnit Int CHECK(AvgUnit > 0),
	BatchEggID int not null Foreign key
		References Demo.BatchEgg(BatchEggID),
	RetailID int not null Foreign Key
		References Demo.Retail(RetailID),
	CanceledOn Datetime Null,
	Unique(BatchEggID, RetailID)
);
INSERT INTO EggSales (UnitPrice, AvgUnit, BatchEggID, RetailID)
VALUES 
    (5.50, 12, 1, 1),
    (6.25, 18, 2, 1),
    (4.80, 6, 3, 2),
    (7.10, 24, 4, 2),
    (5.95, 12, 5, 3);

