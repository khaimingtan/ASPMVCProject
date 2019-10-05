CREATE TABLE [dbo].[ShoppingCart]
(
	[ShopCartId] NVARCHAR(10) NOT NULL PRIMARY KEY,
	[LoginId] NVARCHAR(16) NOT NULL, 
    [ProductId] NVARCHAR(20) NOT NULL, 
    [Quantity] INT NOT NULL 
)
