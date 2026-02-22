//CustomerSaleSys
DROP TABLE Customers;

PROMPT CREATING Table Customers
CREATE TABLE Customers (
    CustomerID numeric(4),
    Forename varchar2(20),
    Surname varchar2(20),
    Phone varchar2(10),
    Email varchar2(20),
    CONSTRAINT pk_Customers PRIMARY KEY (CustomerID)
);

PROMPT POPULATING Table Customers
INSERT INTO Customers
VALUES(1,'Aisling','Sullivan','0851234576','email1@domain.ie');
INSERT INTO Customers
VALUES(2,'Ronan','Brady','0857654321','email2@domain.ie');
INSERT INTO Customers
VALUES(3,'Connor','Kelly','0852134567','email3@domain.ie');
INSERT INTO Customers
VALUES(4,'Aoife','Brennan','0853125467','email4@domain.ie');
INSERT INTO Customers
VALUES(5,'Roisin','Murphy','0851234567','email5@domain.ie');

COMMIT;