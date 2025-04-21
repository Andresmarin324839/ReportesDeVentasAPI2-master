
CREATE TABLE Products (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL
);
GO


CREATE TABLE Sales (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ProductId INT NOT NULL,
    Quantity INT NOT NULL,
    Total DECIMAL(18,2) NOT NULL,
    SaleDate DATETIME NOT NULL DEFAULT GETDATE(),
    FOREIGN KEY (ProductId) REFERENCES Products(Id)
);
GO


INSERT INTO Products (Name, Price) VALUES
('Smartphone Samsung Galaxy S23', 316900),
('Laptop Dell Inspiron 15', 882550),
('Smartwatch Huawei GT 3', 1299900),
('Televisor LG 55" 4K UHD', 7413697),
('Audífonos Sony WH-1000XM4', 1299000),
('Portátil MacBook Pro M2', 8562300),
('Mouse inalámbrico Logitech M185', 339200),
('Tablet Lenovo Tab P11', 949000),
('Consola PlayStation 5', 3890900),
('Cámara Canon EOS Rebel T7', 2899900);
GO


INSERT INTO Sales (ProductId, Quantity, Total, SaleDate) VALUES
(1, 3, 9507000, '2025-04-01'),
(2, 2, 17651000, '2025-04-02'),
(3, 1, 1299900, '2025-04-02'),
(4, 5, 37068485, '2025-04-03'),
(5, 10, 12990000, '2025-04-04'),
(6, 7, 59936100, '2025-04-05'),
(7, 4, 1356800, '2025-04-06'),
(8, 6, 5694000, '2025-04-07'),
(9, 8, 31127200, '2025-04-08'),
(10, 3, 8699700, '2025-04-09'),
(1, 5, 15845000, '2025-04-10'),
(3, 2, 2599800, '2025-04-11'),
(5, 6, 7794000, '2025-04-12'),
(6, 3, 25686900, '2025-04-13'),
(7, 1, 339200, '2025-04-14'),
(8, 2, 1898000, '2025-04-15'),
(9, 4, 15563600, '2025-04-16'),
(10, 2, 5799800, '2025-04-17'),
(2, 1, 8825500, '2025-04-18'),
(4, 2, 14827394, '2025-04-19'),
(5, 4, 5196000, '2025-04-20'),
(1, 1, 3169000, '2025-04-21'),
(6, 2, 17124600, '2025-04-22'),
(3, 3, 3899700, '2025-04-23'),
(8, 5, 4745000, '2025-04-24'),
(7, 2, 678400, '2025-04-25'),
(9, 3, 11672700, '2025-04-26'),
(10, 1, 2899900, '2025-04-27'),
(2, 3, 26476500, '2025-04-28'),
(4, 1, 7413697, '2025-04-29');
GO

