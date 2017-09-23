CREATE TABLE [dbo].[CarOwner]
(
	[Id] INT NOT NULL PRIMARY KEY,
	OwnerName nvarchar(30) not null,
	--Foreign key till car
)
