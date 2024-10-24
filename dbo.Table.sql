
CREATE TABLE [dbo].[Tovars] (
    [Id]                 INT        NOT NULL Primary key   ,
    [Product_name]       VARCHAR (50)  NOT NULL,
    [Id_Mesto_xraneniya] INT           NOT NULL,
    [id_Model_tovara]    INT           NOT NULL,
    [razmer]             NVARCHAR (50) NOT NULL,
    [id_Proizvoditel]    INT           NOT NULL,
    [id_Prixod]          INT           NOT NULL,
    [id_Rasxod]          INT           NOT NULL,
    [id_Prodaji]         INT           NOT NULL,
    [id_Ostatki]         INT           NOT NULL,
   
);

CREATE TABLE [dbo].[Prodaji]
(
	[Id_Prodaji] INT NOT NULL PRIMARY KEY, 
    Datanum Date Not null,
    [Product_name] VARCHAR(50) NOT NULL, 
    [Sena_zakupki] float NOT NULL, 
    [Sena_prodaji] float NOT NULL, 
    [kolichestvo_prodaj] int NOT NULL, 
    [kolichestvo_vozvrata] INT NOT NULL, 
    [prichina] nvarchar(200) NOT NULL, 
    moddel_tovara nvarchar(50) not null,
)

CREATE TABLE [dbo].[Ostatki_tovara]
(
	[Id_Prodaji] INT NOT NULL PRIMARY KEY, 
    Datanum Date Not null,
    [Product_name] VARCHAR(50) NOT NULL, 
     moddel_tovara nvarchar(50) not null,
     kolichestvo int not null,
)
CREATE TABLE [dbo].[Model_tovara]
(
	[Id_Model_tovara] INT NOT NULL PRIMARY KEY, 
    [Product_name] VARCHAR(50) NOT NULL, 
)
CREATE TABLE [dbo].[Prixod]
(
	[Id_Prixod] INT NOT NULL PRIMARY KEY, 
    Datanum Date Not null,
    [Product_name] VARCHAR(50) NOT NULL, 
    Postavshik varchar(50) not null,
    moddel_tovara nvarchar(50) not null,
    sena_zakupki float not null,
    kolichestvo int not null,
  )

CREATE TABLE [dbo].[Rasxod1]
(
	[Id_Rasxod] INT NOT NULL PRIMARY KEY, 
    Datanum Date Not null,
    [Product_name] VARCHAR(50) NOT NULL, 
    Postavshik varchar(50) not null,
    Moddel_tovara nvarchar(50) not null,
    Sena_prodaji float not null,
    Kolichestvo int not null,
  )

CREATE TABLE [dbo].[Proizvoditel]
(
	[Id_Proizvoditel] INT NOT NULL PRIMARY KEY, 
    [Proizvoditel] VARCHAR(50) NOT NULL, 
)

CREATE TABLE [dbo].[Mesto_xraneniya]
(
	[Id_Mesto_xraneniya] INT NOT NULL PRIMARY KEY, 
    Datanum Date Not null,
    Sklad_name varchar(50) not null,
    [Product_name] VARCHAR(50) NOT NULL, 
     moddel_tovara nvarchar(50) not null,
     kolichestvo int not null,
)

CREATE TABLE [dbo].[Prodaji1] (
    [Id_Prodaji]           INT            NOT NULL PRIMARY KEY,
    [Datanum]              DATE           NOT NULL,
    [Product_name]         VARCHAR (50)   NOT NULL,
    Razmer int not null,
    [Sena_zakupki]         FLOAT (53)     NOT NULL,
    [Sena_prodaji]         FLOAT (53)     NOT NULL,
    [kolichestvo_prodaj]   INT            NOT NULL,
    [kolichestvo_vozvrata] INT            NOT NULL,
    [prichina]             NVARCHAR (200) NOT NULL,
    [id_Model_tovara]        INT  NOT NULL,
  
);

insert into [Tovars]
values
( 1,'Puma',23,1002,43,8003,2001,4005,702,9001),
( 2,'Poco',24,1003,44,8004,2002,4006,703,9002),
( 3,'Peru',25,1004,45,8005,2003,4007,704,9003),
( 4,'Abibas',26,1005,46,8006,2004,4008,705,9004),
( 5,'Panda',27,1006,47,8007,2005,4009,706,9005),
( 6,'Start',28,1007,48,8008,2006,4010,707,9006),
( 7,'Finish',29,1008,49,8009,2007,4011,708,9007)

insert into [Prodaji1]
values

(9002,'12.12.2024','Poco',41,24.401,26.500,3,1,'Razmer',1003),
(9003,'12.12.2024','Adidas',45,23.500,24.500,3,1,'Razmer',1004),
(9004,'12.12.2024','Puma',46,23.400,25.500,3,1,'Razmer',1005),
(9005,'12.12.2024','Kenzo',47,23.400,25.500,3,1,'Vid tovara',1006),
(9006,'12.12.2024','Puma',48,23.400,25.500,3,1,'Razmer',1007),
(9007,'12.12.2024','Puma',49,23.400,25.500,3,1,'Razmer',1008)


insert into [Model_tovara]
values
(1002,'Kedi'),
(1003,'Jordan'),
(1004,'Trainee'),
(1005,'Letniye'),
(1006,'MMM'),
(1007,'Kedi'),
(1008,'Kedi')

insert into Rasxod1
values
(2001,'12.12.2024','Puma','PumaOOO',1002,23.500,34),
(2002,'12.12.2024','Adidas','AdidasOOO',1003,23.500,35),
(2003,'12.12.2024','Puma','AdidasOOO',1004,23.500,36),
(2004,'12.12.2024','Kenzo','AdidasOOO',1005,23.500,37),
(2005,'12.12.2024','Puma','AdidasOOO',1006,23.500,34),
(2006,'12.12.2024','Kenzo','AdidasOOO',1007,23.500,342),
(2007,'12.12.2024','Adidas','AdidasOOO',1008,23.500,3489)

insert into Prixod
values
/*(4005,'2.12.2024','Puma','PumaOOO',1002,23.500,31),*/
(4006,'12.12.2024','Adidas','AdidasOOO',1003,23.500,4),
(4007,'12.12.2024','Puma','AdidasOOO',1004,23.500,36),
(4008,'12.12.2024','Kenzo','AdidasOOO',1005,23.500,7),
(4009,'12.12.2024','Puma','AdidasOOO',1006,23.500,34),
(4010,'12.12.2024','Kenzo','AdidasOOO',1007,23.500,342),
(4011,'12.12.2024','Adidas','AdidasOOO',1008,23.500,3489)

insert into Mesto_xraneniya
values 
(23,'12.12.2024','First','Adidas',1002,56),
(24,'12.12.2024','Second','Adidas',1003,57),
(25,'12.12.2024','First','Puma',1004,6),
(26,'12.12.2024','Third','Kenzo',1005,56),
(27,'12.12.2024','First','Puma',1006,5),
(28,'12.12.2024','Third','Kenzo',1007,13),
(29,'12.12.2024','Second','Adidas',1008,11)

insert into Proizvoditel
values 
(8003,'China'),
(8004,'Germany'),
(8005,'Russia'),
(8006,'Vietnam'),
(8007,'Turkey'),
(8008,'Uzbekkistan'),
(8009,'China')
