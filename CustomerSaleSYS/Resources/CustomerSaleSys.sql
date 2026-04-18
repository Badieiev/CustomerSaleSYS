//CustomerSaleSys
DROP TABLE Order_items;
DROP TABLE Orders;
DROP TABLE Products;
DROP TABLE Customers;

PROMPT CREATING Table Customers
CREATE TABLE Customers (
    CustomerID number(4),
    Forename varchar2(20),
    Surname varchar2(20),
    Phone varchar2(20),
    Email varchar2(20),
    Status char(1),
    CONSTRAINT pk_Customers PRIMARY KEY (CustomerID)
);

PROMPT CREATING Table Products
CREATE TABLE Products (
    ProductID number(4),
    ProductName varchar2(50),
    Quantity number(10),
    Price number(10,2),
    Status char(1),
    CONSTRAINT pk_Products PRIMARY KEY (ProductID)
);

PROMPT CREATING Table Orders
CREATE TABLE Orders (
    OrderID number(4),
    CustomerID number (4),
    OrderDate DATE,
    OrderSum number(10,2),
    Status char(1),
    CONSTRAINT pk_Orders PRIMARY KEY (OrderID),
    CONSTRAINT fk_Orders_Customers FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
);

PROMPT CREATING Table Order_items
CREATE TABLE Order_items (
    OrderID number(4),
    ProductID number(4),
    Quantity number(10),
    Cost number(10,2),wd
    Status char(1),
    CONSTRAINT pk_Order_items PRIMARY KEY (OrderID, ProductID),
    CONSTRAINT fk_Order_items_Order FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
    CONSTRAINT fk_Order_items_Products FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
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
INSERT INTO Customers
VALUES(6,'Farrokh','Bulsara','0853234567','email6@domain.ie','A');
INSERT INTO Customers
VALUES(7,'Marshall','Mathers','0854234567','email7@domain.ie','A');
INSERT INTO Customers
VALUES(8,'Gordon','Sumner','0858234567','email8@domain.ie','A');
INSERT INTO Customers
VALUES(9,'Reginald','Dwigh','0859234567','email9@domain.ie','A');
INSERT INTO Customers
VALUES(10,'Louise','Ciccone','0859134567','email@domain.ie','A');

PROMPT POPULATING Table Products
INSERT INTO Products
VALUES(1,'Product1', 20, 15.5,'A');
INSERT INTO Products
VALUES(2,'Product2', 22, 25.5,'A');
INSERT INTO Products
VALUES(3,'Product3', 10, 5.0,'I');
INSERT INTO Products
VALUES(4,'Product4', 4, 1.5,'A');
INSERT INTO Products
VALUES(5,'Product5', 45, 4.5,'A');

COMMIT;