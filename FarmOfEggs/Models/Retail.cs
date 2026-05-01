using System;

public class Retail
{

	public int RetailID { get; }
	public string PhoneNumber { get; }
	public string Name { get; }
	public decimal RetailFee { get; }
	internal Retail(int retailId, string phoneNumber, string name, decimal retailFee)
	{
		RetailID = retailId;
		PhoneNumber = phoneNumber;
		Name = name;
		RetailFee = retailFee;
	}

}
