USE Farm;
GO

CREATE TABLE dbo.EggSales (
    EggSalesID INT PRIMARY KEY,
    UnitPrice DECIMAL(10,2) NOT NULL,
    AvgUnit INT NOT NULL,
    BatchEggID INT,
    RetailID INT,
    CanceledOn DATETIME NULL
    Unique(BatchEggID, RetailID)
);