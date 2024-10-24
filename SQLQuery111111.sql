CREATE TABLE [dbo].[Tovars] (
    [Id_Product]         INT          IDENTITY (1, 1) NOT NULL,
    [Product_name]       VARCHAR (50) NOT NULL,
     product_description TEXT,
    unit_price DECIMAL(10, 2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Product] ASC)
);


CREATE TABLE [dbo].[Vid_tovara] (
    [Id_Vid_tovara] INT IDENTITY (1, 1) NOT NULL,
    [Id_Product]    INT NOT NULL,
    Brand_tivara varchar(50) not null,
    PRIMARY KEY CLUSTERED ([Id_Vid_tovara] ASC),
    FOREIGN KEY ([Id_Product]) REFERENCES [dbo].[Tovars] ([Id_Product])
);

CREATE TABLE [dbo].[Ostatki] (
    [Id_Ostatki] INT        IDENTITY (1, 1) NOT NULL,
    [Datanum]        DATE       DEFAULT (getdate()) NOT NULL,
    [Id_Product]     INT        NOT NULL,
    [Sena_prodaji]  decimal(10,2) NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Ostatki] ASC),
    FOREIGN KEY ([Id_Product]) REFERENCES [dbo].[Tovars] ([Id_Product])
);

CREATE TABLE [dbo].[Vozvrat] (
    [Id_Vozvrat] INT        IDENTITY (1, 1) NOT NULL,
    [Datanum]        DATE       DEFAULT (getdate()) NOT NULL,
    [Id_Product]     INT        NOT NULL,
    [Sena_prodaji]  decimal(10,2) NOT NULL,
    Kolichestvo int not null,
    PRIMARY KEY CLUSTERED ([Id_Vozvrat] ASC),
    FOREIGN KEY ([Id_Product]) REFERENCES [dbo].[Tovars] ([Id_Product])
);
alter table Ostatki
add Kolichestvo int not null

alter table Fakt_ostatki
add Sena_prodaji decimal(10,2)

alter table Vozvrat
add Prichina text not null

CREATE TABLE [dbo].[Prodaji] (
    [Id_Prodaji]     INT           IDENTITY (1, 1) NOT NULL,
    [Data_Prixoda]  DATE          DEFAULT getdate() NOT NULL,
    [Id_Product]    INT           NOT NULL,
    Sotrudnik varchar(50) not null,
    [Sena_prodaji]  Decimal (10,2)    NOT NULL,
    [Kolichestvo]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Prodaji] ASC),
    FOREIGN KEY ([Id_Product]) REFERENCES [dbo].[Tovars] ([Id_Product])
);

CREATE TABLE [dbo].[Real_Prodaji] (
    [Id_Real_Prodaji]     INT           IDENTITY (1, 1) NOT NULL,
    [Data_Prixoda]  DATE          DEFAULT getdate() NOT NULL,
    [Id_Product]    INT           NOT NULL,
    Sotrudnik varchar(50) not null,
    [Sena_prodaji]  Decimal (10,2)    NOT NULL,
    [Kolichestvo]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Real_Prodaji] ASC),
    FOREIGN KEY ([Id_Product]) REFERENCES [dbo].[Tovars] ([Id_Product])
);


CREATE TABLE [dbo].[Prixod] (
    [Id_Prixod]     INT           IDENTITY (1, 1) NOT NULL,
    [Data_Prixoda]  DATE          DEFAULT (getdate()) NOT NULL,
    [Id_Product]    INT           NOT NULL,
    [Postavshik]    VARCHAR (50)  NOT NULL,
    [Sena_zakupki]  FLOAT (53)    NOT NULL,
    [kolichestvo]   INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Prixod] ASC),
    FOREIGN KEY ([Id_Product]) REFERENCES [dbo].[Tovars] ([Id_Product])
);

 CREATE TABLE [dbo].[Proizvoditel] (
    [Id_Proizvoditel] INT          IDENTITY (1, 1) NOT NULL,
    [Proizvoditel]    VARCHAR (50) NOT NULL,
    Id_Product int not null,
    PRIMARY KEY CLUSTERED ([Id_Proizvoditel] ASC)
    );

CREATE TABLE [dbo].[Mesto_xraneniya] (
    [Id_Mesto_xraneniya] INT           IDENTITY (1, 1) NOT NULL,
    [Sklad_name]         VARCHAR (50)  NOT NULL,
    [Id_Product]         INT           NOT NULL,
    [kolichestvo]        INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([Id_Mesto_xraneniya] ASC),
    FOREIGN KEY ([Id_Product]) REFERENCES [dbo].[Tovars] ([Id_Product])
);




ALTER TABLE Ostatki
ADD FOREIGN KEY (Id_Product) REFERENCES Tovars(Id_Product);


ALTER TABLE Fakt_Ostatki
ADD FOREIGN KEY (Id_Product) REFERENCES Tovars(Id_Product);

ALTER TABLE Mesto_xraneniya
ADD FOREIGN KEY (Id_Product) REFERENCES Tovars(Id_Product);

ALTER TABLE Prixod
ADD FOREIGN KEY (Id_Product) REFERENCES Tovars(Id_Product);


ALTER TABLE Rasxod1
ADD FOREIGN KEY (Id_Product) REFERENCES Tovars(Id_Product);


ALTER TABLE Vid_tovara
ADD FOREIGN KEY (Id_Product) REFERENCES Tovars(Id_Product);
ALTER TABLE Proizvoditel
ADD FOREIGN KEY (Id_Product) REFERENCES Tovars(Id_Product);

/*ALTER TABLE Tovars DROP CONSTRAINT Id_Mesto_xraneniya;

ALTER TABLE Tovars
DROP COLUMN [Id_Vid_tovara], [Id_Mesto_xraneniya],[Id_Tek_ostatki],[Id_Fakt_ostatki],[Id_Proizvoditel],[Id_Prixod],[Id_Rasxod]*/
Alter table Tovars
add Razmer int not null
insert into [Tovars]
values
( 'Kenzo','Jordan',23.10,34),
( 'Adidas','HAdidas',24.10,43),
( 'Puma','Puma',25.10,44),
( 'Abibas','Abibas',26.10,45),
( 'Kenzo','Kenzo',17.10,46),
( 'Puma','Puma',68.10,32),
( 'Abibas','Abibas',34.10,42)
SET IDENTITY_INSERT Prodaji Off;

insert into Prodaji
values
(GETDATE(),1,'Rick',23.500,23),
(GETDATE(),3,'Rick',23.509,34),
(GETDATE(),4,'Rick',23.56,35),
(GETDATE(),5,'Rick',56.502,45),
(GETDATE(),6,'Rick',23.505,32),
(GETDATE(),7,'Rick',67.504,11)

insert into Prixod
values
(GETDATE(),1,'Kenzo',23.500,22),
(GETDATE(),3,'Puma',23.509,32),
(GETDATE(),4,'Abibas',23.56,33),
(GETDATE(),5,'Adidas',56.502,44),
(GETDATE(),6,'Puma',23.505,31),
(GETDATE(),7,'Kenzo',67.504,11)

SET IDENTITY_INSERT Mesto_xraneniya On;
insert into Mesto_xraneniya
values
/*(GETDATE(),1,'Puma',3,23.500),*/
('First',1,5),
('First',2,6),
('First',3,7),
('First',4,8),
('First',5,9)

insert into Vid_tovara
values
(1,'Adidas'),
(3,'Adidas'),
(4,'Puma'),
(5,'Kenzo'),
(6,'Adidas'),
(7,'Abilas')

insert into Proizvoditel
values
('Adidas',1),
('Abilas',3),
('Kenzo',4),
('Puma',5),
('Kenzo',6),
('Abilas',7)


insert into Vozvrat
values
(GETDATE(),1,32.56,5,'Razmer'),
(GETDATE(),2,34.98,6,'Dostavka'),
(GETDATE(),3,43.65,7,'Vid'),
(GETDATE(),4,23.45,8,'Razmer'),
(GETDATE(),5,12.45,9,'Razmer'),
(GETDATE(),6,45.65,10,'Dostavka'),
(GETDATE(),7,98.56,11,'Vid')


/*CREATE TRIGGER trgAfterInsertRasxod ON dbo.Rasxod1
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Update the Tek_Ostatki table by subtracting the quantity from Rasxod1
    UPDATE Tek_Ostatki
    SET kolichestvo = kolichestvo - i.Kolichestvo
    FROM Tek_Ostatki tk
    INNER JOIN inserted i ON tk.Id_Product = i.Id_Product
    WHERE tk.Id_Product = i.Id_Product;
END;*/
/*

CREATE TRIGGER trgAfterInsertRasxod ON dbo.Rasxod1
AFTER INSERT
AS
BEGIN
    SET NOCOUNT ON;

    -- Update the Tek_Ostatki table by subtracting the quantity from Rasxod1
    UPDATE Tek_Ostatki
    SET kolichestvo = Tek_Ostatki.kolichestvo - i.Kolichestvo
    FROM Tek_Ostatki
    INNER JOIN inserted i ON Tek_Ostatki.Id_Product = i.Id_Product;
END;

*/


UPDATE Tek_Ostatki
SET kolichestvo = kolichestvo - i.Kolichestvo
FROM Tek_Ostatki tk
INNER JOIN inserted i ON tk.Id_Product = i.Id_Product
WHERE tk.Id_Product = i.Id_Product;




-- Вставить данные из таблиц Rasxod1 и Tek_Ostatki в таблицу Fakt_Ostatki
INSERT INTO Fakt_Ostatki (
    Id_Product,
    kolichestvo,
    Sena_prodaji
)
SELECT
    r.Id_Product,
    r.Sena_prodaji,
    t.kolichestvo - r.Kolichestvo
FROM
    Rasxod1 AS r
INNER JOIN
    Tek_Ostatki AS t
ON
    r.Id_Product = t.Id_Product;



   




INSERT INTO Fakt_Ostatki (
    Id_Product,
    kolichestvo,
    Sena_prodaji
)
SELECT
    r.Id_Product,
    CASE
        WHEN t.kolichestvo - r.Kolichestvo >= 0
        THEN t.kolichestvo - r.Kolichestvo
        ELSE 0
    END AS kolichestvo,
    r.Sena_prodaji
FROM
    Rasxod1 AS r
INNER JOIN
    Tek_Ostatki AS t
ON
    r.Id_Product = t.Id_Product;


SELECT *
from Rasxod1

SELECT * FROM Elmarket33 WHERE name = 'Rasxod1';
-- First, we'll create a temporary table to store the net sales after accounting for returns
SELECT
    p.Id_Product,
    p.Sotrudnik,
    p.Sena_prodaji,
    p.Kolichestvo - ISNULL(v.Kolichestvo, 0) AS NetKolichestvo

INTO #NetSales
FROM Prodaji as p
LEFT JOIN (
    SELECT
        Id_Product,
        SUM(Kolichestvo) AS Kolichestvo
    FROM Vozvrat
    GROUP BY Id_Product
) v ON p.Id_Product = v.Id_Product;

-- Now, we insert the net sales into the Real_Prodaji table
INSERT INTO Real_Prodaji (Data_Prixoda, Id_Product, Sotrudnik, Sena_prodaji, Kolichestvo)
SELECT
    GETDATE(), -- Assuming we want to use the current date for all entries
    Id_Product,
    Sotrudnik,
    Sena_prodaji,
    NetKolichestvo
FROM #NetSales
WHERE NetKolichestvo > 0; -- We only want to insert records where there are actual sales after returns

-- Clean up the temporary table
DROP TABLE #NetSales;
use [D:\C#\SLIPPERS\SLIPPRSAPP\BIN\DEBUG\SLIPPERS11.MDF]
go

SELECT
    p.Id_Product,
    p.Sotrudnik,
    p.Sena_prodaji,
    p.Kolichestvo - ISNULL(v.Kolichestvo, 0) AS NetKolichestvo
INTO #NetSales
FROM Prodaji as p
LEFT JOIN (
    SELECT
        Id_Product,
        SUM(Kolichestvo) AS Kolichestvo
    FROM Vozvrat
    GROUP BY Id_Product
) v ON p.Id_Product = v.Id_Product;

-- Now, we insert the net sales into the Real_Prodaji table
-- This will include records with negative NetKolichestvo as well
INSERT INTO Real_Prodaji (Data_Prixoda, Id_Product, Sotrudnik, Sena_prodaji, Kolichestvo)
SELECT
    GETDATE(), -- Using the current date for all entries
    Id_Product,
    Sotrudnik,
    Sena_prodaji,
    NetKolichestvo
FROM #NetSales;

-- Clean up the temporary table
DROP TABLE #NetSales;

-- Insert the net sales into the Real_Prodaji table
INSERT INTO Real_Prodaji (Data_Prixoda, Id_Product, Sotrudnik, Sena_prodaji, Kolichestvo)
SELECT
    GETDATE(), -- Using the current date for all entries
    p.Id_Product,
    p.Sotrudnik,
    p.Sena_prodaji,
    p.Kolichestvo - ISNULL(v.Kolichestvo, 0) AS NetKolichestvo
FROM Prodaji as p
LEFT JOIN (
    SELECT
        Id_Product,
        SUM(Kolichestvo) AS Kolichestvo
    FROM Vozvrat
    GROUP BY Id_Product
) v ON p.Id_Product = v.Id_Product;
alter table Real_Prodaji

drop column Sotrudnik


INSERT INTO Real_Prodaji (
    Id_Product,
    Data_Prixoda,
    Sena_prodaji,
    Kolichestvo
)
SELECT
    p.Id_Product,
    p.Data_Prixoda,
    p.Sena_prodaji,
    p.Kolichestvo - v.Kolichestvo
FROM
    Prodaji AS p
LEFT JOIN
    [Vozvrat] as v
ON
    p.Id_Product = v.Id_Product;

SELECT @@TRANCOUNT;

INSERT INTO Real_prodaji (
    Id_Product,
    Sotrudnik,
    Sena_prodaji,
    Kolichestvo
    
)
SELECT
    v.Id_Product,
    r.Id_Product,
    r.Sena_prodaji,
    r.Sotrudnik,
     r.Kolichestvo - v.Kolichestvo AS kolichestvo
FROM
    Prodaji AS r
INNER JOIN
    VOzvrat AS v
ON
    r.Id_Product = t.Id_Product;

alter table Real_prodaji
add Sotrudnik varchar(50)  null
alter table Real_prodaji
drop column Sotrudnik


INSERT INTO Real_prodaji (
    Id_Product,
    Sotrudnik,
    Sena_prodaji,
    Kolichestvo
)
SELECT
    r.Id_Product,
    r.Sotrudnik,
    r.Sena_prodaji,
    r.Kolichestvo - ISNULL(v.Kolichestvo, 0) AS Kolichestvo
FROM
    [Prodaji] AS r
LEFT JOIN (
    SELECT
        Id_Product,
        SUM(Kolichestvo) AS Kolichestvo
    FROM
        Vozvrat
    GROUP BY
        Id_Product
) AS v
ON
    r.Id_Product = v.Id_Product;