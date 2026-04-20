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
    Cost number(10,2),
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
INSERT INTO Products
VALUES(6,'Product6', 25, 14.5,'A');
INSERT INTO Products
VALUES(7,'Product7', 33, 22.5,'A');
INSERT INTO Products
VALUES(8,'Product8', 75, 3.5,'A');
INSERT INTO Products
VALUES(9,'Product9', 6, 7.5,'A');
INSERT INTO Products
VALUES(10,'Product10', 10, 4.55,'A');

PROMPT POPULATING Table Orders
INSERT INTO Orders
VALUES(1, 1, TO_DATE('2026-01-19', 'YYYY-MM-DD'), 15.5,'A');
INSERT INTO Orders
VALUES(2, 2, TO_DATE('2026-02-19', 'YYYY-MM-DD'), 87.0,'A');
INSERT INTO Orders
VALUES(3, 3, TO_DATE('2026-03-19', 'YYYY-MM-DD'), 15.0,'I');
INSERT INTO Orders
VALUES(4, 4, TO_DATE('2026-04-19', 'YYYY-MM-DD'), 6.0,'A');
INSERT INTO Orders
VALUES(5, 5, TO_DATE('2026-05-19', 'YYYY-MM-DD'), 22.5,'A');
INSERT INTO Orders
VALUES(6, 6, TO_DATE('2026-06-19', 'YYYY-MM-DD'), 30.0,'A');
INSERT INTO Orders
VALUES(7, 7, TO_DATE('2026-07-19', 'YYYY-MM-DD'), 48.5,'A');
INSERT INTO Orders
VALUES(8, 8, TO_DATE('2026-08-19', 'YYYY-MM-DD'), 10.5,'A');
INSERT INTO Orders
VALUES(9, 9, TO_DATE('2026-09-19', 'YYYY-MM-DD'), 30.0,'A');
INSERT INTO Orders
VALUES(10, 10, TO_DATE('2026-10-19', 'YYYY-MM-DD'), 18.2,'A');

PROMPT POPULATING Table Order_items
INSERT INTO Order_items
VALUES(1, 1, 1, 15.5,'A');
INSERT INTO Order_items
VALUES(2, 1, 2, 31.0,'A');
INSERT INTO Order_items
VALUES(2, 2, 2, 51.0,'A');
INSERT INTO Order_items
VALUES(2, 3, 1, 5.0,'A');
INSERT INTO Order_items
VALUES(3, 3, 3, 15.0,'A');
INSERT INTO Order_items
VALUES(4, 4, 4, 6.0,'A');
INSERT INTO Order_items
VALUES(5, 5, 5, 22.5,'A');
INSERT INTO Order_items
VALUES(6, 1, 1, 15.5,'A');
INSERT INTO Order_items
VALUES(6, 6, 1, 14.5,'A');
INSERT INTO Order_items
VALUES(7, 7, 2, 45.0,'A');
INSERT INTO Order_items
VALUES(7, 8, 1, 3.5,'A');
INSERT INTO Order_items
VALUES(8, 8, 3, 10.5,'A');
INSERT INTO Order_items
VALUES(9, 9, 4, 30.0,'A');
INSERT INTO Order_items
VALUES(10, 10, 5, 18.2,'A');

COMMIT;