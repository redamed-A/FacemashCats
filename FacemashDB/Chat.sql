CREATE TABLE [dbo].[Chat]
(
	[Id] INT NOT NULL  PRIMARY KEY IDENTITY, 
    [url] VARCHAR(62) NOT NULL, 
    [id_chat] VARCHAR(50) NOT NULL, 
    [score] INT NULL
)
