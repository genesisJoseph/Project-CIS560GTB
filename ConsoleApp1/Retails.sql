Use Farm;
Go
Create Table dbo.Retail
(
	RetailID INT IDENTITY(1,1) PRIMARY KEY,
	PhoneNumber VarChar(20) Not Null,
	[Name] VarChar(100) Not Null,
	RetailFee Decimal(5,2) Check (RetailFee >=0) Not null,
	Unique(PhoneNumber, [Name])
);

INSERT INTO Retail (PhoneNumber, Name, RetailFee)
VALUES 
    (N'555-101-1001', N'Sunrise Egg Market', 0.10),
    (N'555-202-2002', N'Golden Farm Retail', 0.15),
    (N'555-303-3003', N'FreshNest Store', 0.08),
    (N'555-404-4004', N'Happy Hen Supplies', 0.12),
    (N'555-505-5005', N'CountrySide Eggs', 0.09);