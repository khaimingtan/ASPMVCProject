CREATE TABLE [dbo].[Member]
(
	[LoginId] NVARCHAR(16) NOT NULL PRIMARY KEY, 
    [MemberRole] INT NULL, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL, 
    [Email] NVARCHAR(50) NULL, 
    [Password] NVARCHAR(20) NULL
)
