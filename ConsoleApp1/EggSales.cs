using System;

public class EggSales
{
	public int EggSalesId { get;}
	public decimal UnitPrice { get;}
	public int BatchEggID { get;}
    public int RetailID { get; }
    public EggSales(int eggSalesID, decimal unitPrice, int batchID, int retailID)
	{
		EggSalesId = eggSalesID;
		UnitPrice = unitPrice;
		BatchEggID = batchID;
		RetailID = retailID;
	}
}
