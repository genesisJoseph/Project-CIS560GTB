Create or Alter Procedure Farm.CreateEggSales
	@EggSalesId int output,
	@UnitPrice Decimal(10,2),
	@AvgUnit int, 
    @BatchEggID int,
	@RetailID int 
As 

Insert Farm.EggSales(UnitPrice, AvgUnit, BatchID, RetailID)
Values(@UnitPrice, @AvgUnit, @BatchID, @RetailID);
Set @EggSalesId = Scope_Identity();


SELECT 
    es.EggSalesID,
    es.UnitPrice,
    es.AvgUnit,
    es.CanceledOn,
    r.Name AS RetailName,
    b.BatchEggID
FROM Farm.EggSales es
JOIN Farm.Retail r ON es.RetailID = r.RetailID
JOIN Farm.BatchEgg b ON es.BatchID = b.BatchEggID;

UPDATE Farm.EggSales
SET CancledON = GetDate()
WHERE EggSalesID = @EggSalesID;

UPDATE Farm.EggSales
SET UnitePric = @UnitPrice,
    AvgUnit = @AvgUnit
WHERE EggSalesID = @EggSalesID;

