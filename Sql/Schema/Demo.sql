IF Not exists
(
	Select *
	From sys.schemas s
	Where s.[name] = N'Demo'
)
Begin
	Exec(N'CREATE SCHEMA [Demo] AUTHORIZATION [dbo]')
End;