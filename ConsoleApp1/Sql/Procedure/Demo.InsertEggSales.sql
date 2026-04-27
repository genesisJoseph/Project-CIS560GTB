Create or Alter Procedure Demo.CreateEggSales
	@EggSalesId int output,
	@UnitPrice Decimal(10,2),
	@CanceledOn Datetime Null
As 

Insert Demo.EggSales(UnitPrice, CanceledOn)
Values(@UnitPrice, @CanceledOn);

Set @EggSalesId = Scope_Identity();
Go;

SELECT 
    es.EggSalesID,
    es.UnitPrice,
    es.AvgUnit,
    es.CanceledOn,
    r.Name AS RetailName,
    b.BatchEggID
FROM Demo.EggSales es
JOIN Demo.Retail r ON es.RetailID = r.RetailID
JOIN Demo.BatchEgg b ON es.BatchID = b.BatchEggID;

UPDATE Demo.EggSales
SET UnitPrice = @UnitPrice,
    CanceledOn = @CanceledOn
WHERE EggSalesID = @EggSalesID;


SELECT * 
FROM EggSales
WHERE CanceledOn IS NULL;