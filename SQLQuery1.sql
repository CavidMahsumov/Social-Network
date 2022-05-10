create database SocialMediaDB

use SocialMediaDB

CREATE TABLE Users(
Id int primary key identity(1,1) not null,
[FirstName] nvarchar(40) not null,
[LastName] nvarchar(50) not null,
[Email] nvarchar(50) not null,
[Password] nvarchar(40) not null,
[ImagePath] nvarchar(40) not null,
[PhoneNumber] nvarchar(40) not null,
[Country] nvarchar(40) not null,
[Adress] nvarchar(40) not null,
[City] nvarchar(40) not null,
[PostCode] int not null,
[LoginName] nvarchar(40) not null,
[Following] int not null ,
[Follower] int not null,
[Description] nvarchar(50)
)
CREATE TABLE [Chats](
Id int primary key identity(1,1) not null,
[Data] datetime2 not null,
[Message] nvarchar(max),
[SenderId] int not null foreign key references Users(Id) ,
[ReceivingUserId] int not null foreign key references Users(Id) 
)

CREATE TABLE Groups(
Id int primary key identity(1,1) not null,
[Name] nvarchar(40) not null,
[CreaterName] nvarchar(40) not null
)

CREATE TABLE Notfication(
Id int primary key identity(1,1) not null,
[FromUserId] int not null foreign key references Users(Id) ,
[ToUserId] int not null foreign key references Users(Id) ,
[Date] datetime2 not null default(sysdatetime()),
[Message] nvarchar(max) not null
)

CREATE TABLE Posts(
Id int primary key identity(1,1) not null,
[Description] nvarchar(max),
[ImageUrl] nvarchar(max)  ,
[UserId] int not null foreign key references Users(Id) ON DELETE CASCADE ,
[Rating] int not null default(0),
[Date] datetime2 not null default(sysdatetime()),
[VideoUrl] nvarchar(max)

)
CREATE TABLE Stories(	
Id int primary key identity(1,1) not null,
[ImageUrl] nvarchar(max) not null,
[UserId] int foreign key references Users(Id) ON DELETE CASCADE ,
[Date] datetime2  default(sysdatetime())
)


CREATE TABLE Comments(
Id int primary key identity(1,1) not null,
[UserId] int foreign key references Users(Id) ON DELETE CASCADE  ,
[PostId] int foreign key references Posts(Id) ,
[Message] nvarchar(50) not null,
[Rating] int default(0),
[Date] datetime2 default(sysdatetime())
)

select*from Chats

