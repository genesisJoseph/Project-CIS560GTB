Create or Alter Procedure Demo.CreateRetail
	@RetailId int output,
	@PhoneNumber NVarChar(20),
	@Name NvarChar(20),
	@RetailFee Decimal(5,4)
As

Insert Demo.Retail(PhoneNumber, [Name], RetailFee)
Values(@PhoneNumber, @Name, @RetailFee);

Set @RetailId = Scope_Identity();
Go;

UPDATE Demo.Retail
SET [Name] = @Name,
    PhoneNumber = @PhoneNumber,
    RetailFee = @RetailFee
WHERE RetailID = @RetailID;

SELECT R.RetailID, R.PhoneNumber, R.[Name], R.RetailFee 
FROM Demo.Retail R 
WHERE RetailID = @RetailID;