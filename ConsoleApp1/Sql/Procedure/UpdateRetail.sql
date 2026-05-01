Create or Alter Procedure Farm.CreateRetail
	@RetailId int output,
	@PhoneNumber NVarChar(20),
	@Name NvarChar(20),
	@RetailFee Decimal(5,4)
As

Insert Farm.Retail(PhoneNumber, [Name], RetailFee)
Values(@PhoneNumber, @Name, @RetailFee);

Set @RetailId = Scope_Identity();
Go;
