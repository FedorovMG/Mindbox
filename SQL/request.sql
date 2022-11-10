SELECT p.ProductName, c.CategoryName
FROM Product as p 
JOIN Category as c
ON p.ProductID = c.ProductID