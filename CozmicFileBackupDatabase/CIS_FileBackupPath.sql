CREATE TABLE [dbo].[CIS_FileBackupPath]
(
    [FBPathID] UNIQUEIDENTIFIER NOT NULL PRIMARY KEY DEFAULT newid(), 
    [SourcePath] NVARCHAR(255) NULL ,
    [DestinationPath] NVARCHAR(255) NULL ,
    [ArchivePath] NVARCHAR(255) NULL ,
    [IsFolder] BIT NOT NULL DEFAULT(1),
    [Status] INT NOT NULL DEFAULT(0),
)