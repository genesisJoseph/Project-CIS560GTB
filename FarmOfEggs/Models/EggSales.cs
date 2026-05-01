using System;
public class EggSales
{
	public int EggSalesId { get;}
	public decimal UnitPrice { get;}
	public int BatchEggID { get;}
    public int RetailID { get; }

	public DateTime CancledON { get;} 
    public EggSales(int eggSalesID, decimal unitPrice, int batchID, int retailID, DateTime cancled)
	{
		EggSalesId = eggSalesID;
		UnitPrice = unitPrice;
		BatchEggID = batchID;
		RetailID = retailID;
		CancledON = cancled;
	}
}
