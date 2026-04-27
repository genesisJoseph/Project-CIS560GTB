IF Not exists
(
	Select *
	From sys.schemas s
	Where s.[name] = N'Farm'
)
Begin
	Exec(N'CREATE SCHEMA [Farm] AUTHORIZATION [dbo]')
End;