-- Create the table
CREATE TABLE DataItems (
    ID INT PRIMARY KEY IDENTITY,
    Title NVARCHAR(100),
    Description NVARCHAR(255),
    Status NVARCHAR(50),
    Date DATETIME
);

-- Insert sample data
INSERT INTO DataItems (Title, Description, Status, Date) VALUES 
('Item 1', 'Description for item 1', 'Active', '2023-06-01'),
('Item 2', 'Description for item 2', 'Inactive', '2023-06-02'),
('Item 3', 'Description for item 3', 'Pending', '2023-06-03'),
('Item 4', 'Description for item 4', 'Active', '2023-06-04');
