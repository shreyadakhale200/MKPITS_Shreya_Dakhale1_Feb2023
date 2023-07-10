CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY identity, 
    [BookName] NVARCHAR(50) NULL, 
    [Price] DECIMAL NULL, 
    [Category] NVARCHAR(50) NULL, 
    [AuthorName] NVARCHAR(50) NULL, 
    [Edition] NVARCHAR(50) NULL, 
    [BookCondition] NVARCHAR(50) NULL, 
    [Available] NCHAR(10) NULL,

)
