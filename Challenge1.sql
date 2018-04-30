CREATE TABLE Product (
    ProductID int Primary Key,
    Name varchar(255),
    Price int,
);

CREATE TABLE Customers (
    CustomerID int Primary key,
     FirstName varchar(255),
    LastName varchar(255),
    CardNumber varchar(255)
);

Create Table Orders(

OrderID int Primary key,
ProductID int FOREIGN KEY REFERENCES Product(ProductID),
CustomerID int FOREIGN KEY REFERENCES Customers(CustomerID)

);

INSERT INTO Customers(CustomerID, FirstName,LastName,CardNumber)
values( 1, 'John', 'Doe', '1234');

INSERT INTO Customers(CustomerID, FirstName,LastName, CardNumber)
values(2, 'Super', 'Mario', '1235');

INSERT INTO Customers(CustomerID, FirstName,LastName,CardNumber)
VALUES(3, 'Luigi', 'Tho','5231');

INSERT INTO Product ( ProductID, Name, Price )
Values (1, 'Laptop', 100);

INSERT INTO Product ( ProductID, Name, Price )
Values (2, 'Desktop', 300);

INSERT INTO Product ( ProductID, Name, Price )
Values (3, 'iPad', 500);



Insert Into Orders(OrderID, ProductID, CustomerID)
Values (2 , 3 , 3);

Insert Into Orders(OrderID, ProductID, CustomerID)
Values (3 , 2 , 3);

Insert into Product(ProductID, Name, Price)
values(4, 'iPhone', 200); 

Insert into Customers(CustomerID, FirstName, LastName, CardNumber)
values (4, 'Tina', 'Smith', '543212');

Insert into Orders(OrderID, ProductID, CustomerID)
values(4,4,4);

select o.OrderID, o.CustomerID, c.FirstName
from Orders o, Customers c
where o.CustomerID = 4 and c.FirstName = 'Tina'