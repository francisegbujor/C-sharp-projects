CREATE TABLE [Contact]
(
    [First] VARCHAR(50) NULL,
	[Last] VARCHAR(50) NULL,
	[Mobile] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NULL, 
    [Category] VARCHAR(50) NULL, 
    CONSTRAINT [PK_Contact] PRIMARY KEY ([Mobile])
	
)
