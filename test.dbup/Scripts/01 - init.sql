CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

/*
DROP table cch.TransactionEntry;
DROP schema cch
*/

CREATE schema cch;

CREATE table cch.TransactionEntry(
    Id UUID NOT NULL DEFAULT uuid_generate_v1() , 
    CONSTRAINT pkey_tbl PRIMARY KEY (Id),
    OrderNumber VARCHAR(50) NOT NULL,
    CreationDateUtc TIMESTAMP NOT NULL,
    ProductId UUID NOT NULL
);

INSERT INTO cch.TransactionEntry(OrderNumber, CreationDateUtc, ProductId)
VALUES('hello','1-5-2020',uuid_generate_v4());


SELECT * FROM cch.TransactionEntry;

SELECT 1;