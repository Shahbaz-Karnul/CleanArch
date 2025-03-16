CREATE TABLE [dbo].[Salat]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [Din] SMALLDATETIME NULL, 
    [Fajr] NCHAR(10) NULL, 
    [Zohr] NCHAR(10) NULL, 
    [Asr] NCHAR(10) NULL, 
    [Maghreb] NCHAR(10) NULL, 
    [Isha] NCHAR(10) NULL, 
    [Remarks] NVARCHAR(MAX) NULL
)
