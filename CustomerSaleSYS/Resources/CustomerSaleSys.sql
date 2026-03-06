//CustomerSaleSys
DROP TABLE Customers;
DROP TABLE Products;

PROMPT CREATING Table Customers
CREATE TABLE Customers (
    CustomerID number(4),
    Forename varchar2(20),
    Surname varchar2(20),
    Phone varchar2(10),
    Email varchar2(20),
    Status char(1),
    CONSTRAINT pk_Customers PRIMARY KEY (CustomerID)
);
//Email Uniq?

PROMPT CREATING Table Products
CREATE TABLE Products (
    ProductID number(4),
    ProductName varchar2(50),
    Quantity number(10),
    Price number(10,2),
    Status char(1),
    CONSTRAINT pk_Products PRIMARY KEY (ProductID)
);

PROMPT POPULATING Table Customers
INSERT INTO Customers
VALUES(1,'Aisling','Sullivan','0851234576','email1@domain.ie','A');
INSERT INTO Customers
VALUES(2,'Ronan','Brady','0857654321','email2@domain.ie','A');
INSERT INTO Customers
VALUES(3,'Connor','Kelly','0852134567','email3@domain.ie','I');
INSERT INTO Customers
VALUES(4,'Aoife','Brennan','0853125467','email4@domain.ie','A');
INSERT INTO Customers
VALUES(5,'Roisin','Murphy','0851234567','email5@domain.ie','A');

PROMPT POPULATING Table Products
INSERT INTO Products
VALUES(1,'Product1', 20, 15.5,'A');
INSERT INTO Products
VALUES(2,'Product2', 22, 25.5,'A');
INSERT INTO Products
VALUES(3,'Product3', 10, 5.0,'A');
INSERT INTO Products
VALUES(4,'Product4', 4, 1.5,'A');
INSERT INTO Products
VALUES(5,'Product5', 45, 4.5,'A');

COMMIT;