CREATE TABLE [dbo].[Product]
(
	[ProductId] NVARCHAR(20) NOT NULL PRIMARY KEY, 
    [ProductName] NCHAR(100) NULL, 
    [StockQty] INT NULL, 
    [UnitPrice] REAL NULL
)
