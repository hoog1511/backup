﻿CREATE TABLE dbo.Bestellingen
(
Id INT NOT NULL IDENTITY (1, 1),
UserId int NOT NULL,
Product VARCHAR(255) NOT NULL,
Straat VARCHAR(255) NOT NULL,
Huisnummer VARCHAR(255) NOT NULL,
Plaats VARCHAR(255) NOT NULL,
) ON [PRIMARY]
