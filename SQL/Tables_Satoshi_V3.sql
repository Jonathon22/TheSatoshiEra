DROP TABLE IF EXISTS dbo.UserTypes

CREATE TABLE dbo.UserTypes 
(
 Id uniqueidentifier NOT NULL Primary Key default(newid()),
 UserTypeName varchar(250) NOT NULL
)

DROP TABLE IF EXISTS dbo.Users

CREATE TABLE dbo.Users 
(
Id uniqueidentifier NOT NULL Primary Key default(newid()),
UserTypeId uniqueidentifier NOT NULL,
FirstName varchar(250) NOT NULL,
LastName varchar(250) NOT NULL,
Email varchar(100) NOT NULL,
ProfilePic varchar(500) NULL,
 CONSTRAINT FK_Users_UserTypeId FOREIGN KEY (UserTypeId)
 REFERENCES dbo.UserTypes(Id)
)

DROP TABLE IF EXISTS dbo.Comics

CREATE TABLE dbo.Comics 
(
Id uniqueidentifier NOT NULL Primary Key default(newid()),
image varchar(5000) NOT NULL,
ComicNumber int NOT NULL
)

DROP TABLE IF EXISTS dbo.VideoViewed

CREATE TABLE dbo.VideoViewed 
(
Id uniqueidentifier NOT NULL Primary Key default(newid()),
UserId uniqueidentifier NOT NULL,
VideName varchar(500) NOT NULL
CONSTRAINT FK_VideoViewed_UserId Foreign Key (UserId)
REFERENCES dbo.Users (Id)
)

CREATE TABLE dbo.LibraryCategories 
(
Id uniqueIdentifier NOT NULL Primary Key default(newid()),
CategoryName varchar(500) NOT NULL
)

DROP TABLE IF EXISTS dbo.LogOpened

CREATE TABLE dbo.LogOpened 
(
Id uniqueidentifier NOT NULL Primary Key default(newid()), 
UserId uniqueidentifier NOT NULL,
NameOfLog varchar(150) NOT NULL,
CONSTRAINT FK_LogOpened_UserId FOREIGN KEY (UserId)
REFERENCES dbo.Users (Id),
CONSTRAINT FK_LogOpened_NameOfLog FOREIGN KEY (NameOfLog)
REFERENCES dbo.LibraryCategories (CategoryName)
)

DROP TABLE IF EXISTS dbo.Library

CREATE TABLE dbo.Library 
(
Id uniqueidentifier NOT NULL Primary Key default(newid()),
UserId uniqueidentifier NOT NULL,
OpenedId uniqueidentifier NOT NULL,
Link varchar(500) NOT NULL,
Description varchar(500) NOT NULL,
CategoryId uniqueidentifier NOT NULL,
CONSTRAINT FK_Library_UserId Foreign Key (UserId)
REFERENCES dbo.Users (Id),
CONSTRAINT FK_Library_CategoryId Foreign Key (CategoryId)
REFERENCES dbo.LibraryCategories (Id),
CONSTRAINT FK_Library_OpenedId Foreign Key (OpenedId)
REFERENCES dbo.LogOpened (Id)
)

DROP TABLE IF EXISTS dbo.TutorialVideos

CREATE TABLE dbo.TutorialVideos 
(
Id uniqueidentifier NOT NULL Primary Key default(newid()),
UserId uniqueidentifier NOT NULL,
LibraryId uniqueidentifier NOT NULL,
ViewingId uniqueidentifier NOT NULL,
VideoUrl varchar(5000) NOT NULL,
Description varchar(5000) NOT NULL,
CONSTRAINT FK_TutorialVideos_UserId Foreign Key (UserId)
REFERENCES dbo.Users (Id),
CONSTRAINT FK_TutorialVideos_LibraryId Foreign Key (LibraryId)
REFERENCES dbo.Library (Id),
CONSTRAINT FK_TutorialVideos_ViewingId Foreign Key (ViewingId)
REFERENCES dbo.VideoViewed (Id)
)

DROP TABLE IF EXISTS dbo.About 

CREATE TABLE dbo.About 
(
Id uniqueidentifier NOT NULL Primary Key default(newid()),
About varchar(8000) NOT NULL,
Github varchar(500) NOT NULL,
Twitter varchar(500) NOT NULL,
LinkedIn varchar(500) NOT NULL
)