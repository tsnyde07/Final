CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Sender] NVARCHAR(50) NOT NULL, 
    [Receiver] NVARCHAR(50) NOT NULL, 
    [Timestamp] TIMESTAMP NOT NULL, 
    [Contents] NVARCHAR(MAX) NOT NULL, 
    [Received] BIT NOT NULL
)
