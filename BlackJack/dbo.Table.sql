﻿CREATE TABLE [dbo].[Table]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [ExceptionType] NVARCHAR(50) NULL, 
    [ExceptionMessage] NCHAR(200) NULL, 
    [TimeStamp] DATETIME NULL
)
