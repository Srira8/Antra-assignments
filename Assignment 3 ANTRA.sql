-- 1.List all cities that have both Employees and Customers.
SELECT DISTINCT e.City 
FROM Employees e
JOIN Customers c ON e.City = c.City;

--2. List all cities that have Customers but no Employee.

--a. Use sub-query

SELECT DISTINCT City 
FROM Customers 
WHERE City NOT IN (SELECT DISTINCT City FROM Employees);

--b. Do not use sub-query
SELECT DISTINCT c.City 
FROM Customers c
LEFT JOIN Employees e ON c.City = e.City
WHERE e.City IS NULL;

--3.  List all products and their total order quantities throughout all orders.
SELECT p.ProductID, p.ProductName, SUM(od.Quantity) AS TotalOrderQuantity
FROM Products p
JOIN [Order Details] od ON p.ProductID = od.ProductID
GROUP BY p.ProductID, p.ProductName
ORDER BY TotalOrderQuantity DESC;

--4. List all Customer Cities and total products ordered by that city.

SELECT c.City, SUM(od.Quantity) AS TotalProductsOrdered
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
ORDER BY TotalProductsOrdered DESC;

--5.  List all Customer Cities that have at least two customers.

SELECT City, COUNT(CustomerID) AS TotalCustomers
FROM Customers
GROUP BY City
HAVING COUNT(CustomerID) >= 2
ORDER BY TotalCustomers DESC;

--6.  List all Customer Cities that have ordered at least two different kinds of products.
SELECT c.City, COUNT(DISTINCT od.ProductID) AS DistinctProductsOrdered
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
JOIN [Order Details] od ON o.OrderID = od.OrderID
GROUP BY c.City
HAVING COUNT(DISTINCT od.ProductID) >= 2
ORDER BY DistinctProductsOrdered DESC;

--7. List all Customers who have ordered products, but have the ‘ship city’ on the order different from their own customer cities
WITH ProductOrderStats AS (
    SELECT od.ProductID, 
           SUM(od.Quantity) AS TotalOrdered,
           AVG(od.UnitPrice) AS AvgPrice
    FROM [Order Details] od
    GROUP BY od.ProductID
),
CityOrderStats AS (
    SELECT od.ProductID, c.City, SUM(od.Quantity) AS CityOrderQuantity
    FROM [Order Details] od
    JOIN Orders o ON od.OrderID = o.OrderID
    JOIN Customers c ON o.CustomerID = c.CustomerID
    GROUP BY od.ProductID, c.City
),
RankedCities AS (
    SELECT p.ProductID, p.TotalOrdered, p.AvgPrice, c.City, c.CityOrderQuantity,
           RANK() OVER (PARTITION BY p.ProductID ORDER BY c.CityOrderQuantity DESC) AS Rank
    FROM ProductOrderStats p
    JOIN CityOrderStats c ON p.ProductID = c.ProductID
)
SELECT TOP 5 p.ProductID, pr.ProductName, p.TotalOrdered, p.AvgPrice, r.City AS TopOrderingCity, r.CityOrderQuantity
FROM RankedCities r
JOIN Products pr ON r.ProductID = pr.ProductID
WHERE r.Rank = 1  -- Get the top city per product
ORDER BY p.TotalOrdered DESC;


SELECT c.CustomerID, c.CompanyName, c.City AS CustomerCity, o.ShipCity
FROM Customers c
JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE c.City <> o.ShipCity
ORDER BY c.CustomerID;

--8. List 5 most popular products, their average price, and the customer city that ordered most quantity of it.
WITH ProductOrderStats AS (
    -- Get total quantity ordered and average price per product
    SELECT od.ProductID, 
           SUM(od.Quantity) AS TotalOrdered,
           AVG(od.UnitPrice) AS AvgPrice
    FROM [Order Details] od
    GROUP BY od.ProductID
),
CityOrderStats AS (
    -- Get total quantity ordered per city for each product
    SELECT od.ProductID, c.City, SUM(od.Quantity) AS CityOrderQuantity
    FROM [Order Details] od
    JOIN Orders o ON od.OrderID = o.OrderID
    JOIN Customers c ON o.CustomerID = c.CustomerID
    GROUP BY od.ProductID, c.City
),
RankedCities AS (
    -- Rank cities for each product based on the highest order quantity
    SELECT p.ProductID, p.TotalOrdered, p.AvgPrice, c.City, c.CityOrderQuantity,
           RANK() OVER (PARTITION BY p.ProductID ORDER BY c.CityOrderQuantity DESC) AS Rank
    FROM ProductOrderStats p
    JOIN CityOrderStats c ON p.ProductID = c.ProductID
)
-- Final selection of the top 5 most popular products
SELECT TOP 5 r.ProductID, pr.ProductName, r.TotalOrdered, r.AvgPrice, r.City AS TopOrderingCity, r.CityOrderQuantity
FROM RankedCities r
JOIN Products pr ON r.ProductID = pr.ProductID
WHERE r.Rank = 1  -- Get the city with the highest order quantity for each product
ORDER BY r.TotalOrdered DESC;

--9.      List all cities that have never ordered something but we have employees there.

--a.      Use sub-query
SELECT DISTINCT e.City
FROM Employees e
WHERE e.City NOT IN (
    SELECT DISTINCT c.City
    FROM Customers c
    JOIN Orders o ON c.CustomerID = o.CustomerID
);


--b.      Do not use sub-query
SELECT DISTINCT e.City
FROM Employees e
LEFT JOIN Customers c ON e.City = c.City
LEFT JOIN Orders o ON c.CustomerID = o.CustomerID
WHERE o.OrderID IS NULL;

---10.  List one city, if exists, that is the city from where the employee sold most orders (not the product quantity) is, and also the city of most total quantity of products ordered from. (tip: join  sub-query)

WITH EmployeeOrderCity AS (
    -- Find the city where employees sold the most orders
    SELECT TOP 1 e.City AS EmployeeCity, COUNT(o.OrderID) AS TotalOrders
    FROM Employees e
    JOIN Orders o ON e.EmployeeID = o.EmployeeID
    GROUP BY e.City
    ORDER BY TotalOrders DESC
),
ProductOrderCity AS (
    -- Find the city where the most total quantity of products was ordered
    SELECT TOP 1 c.City AS ProductCity, SUM(od.Quantity) AS TotalProductQuantity
    FROM Orders o
    JOIN Customers c ON o.CustomerID = c.CustomerID
    JOIN [Order Details] od ON o.OrderID = od.OrderID
    GROUP BY c.City
    ORDER BY TotalProductQuantity DESC
)
-- Select the city that appears in both subqueries
SELECT e.EmployeeCity
FROM EmployeeOrderCity e
JOIN ProductOrderCity p ON e.EmployeeCity = p.ProductCity;


--11 How do you remove the duplicates record of a table?
--
--1. Using ROW_NUMBER() with DELETE (Best for Removing Duplicates)


WITH CTE AS (
    SELECT *, 
           ROW_NUMBER() OVER (PARTITION BY Column1, Column2, Column3 ORDER BY (SELECT NULL)) AS RowNum
    FROM TableName --Here the tablename can depends on what the individual wants to remove duplictae records for
)
DELETE FROM CTE WHERE RowNum > 1;

--2.
SELECT DISTINCT * 
INTO NewTable 
FROM TableName;

--3.
DELETE FROM TableName
WHERE ID NOT IN (
    SELECT MIN(ID)
    FROM TableName
    GROUP BY Column1, Column2, Column3
);

