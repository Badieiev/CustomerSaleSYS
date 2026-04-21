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

COMMIT;