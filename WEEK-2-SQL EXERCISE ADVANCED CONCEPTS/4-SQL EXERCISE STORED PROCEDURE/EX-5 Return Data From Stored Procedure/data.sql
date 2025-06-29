-- Stored Procedure to count employees in a specific department
CREATE PROCEDURE sp_CountEmployeesByDepartment
    @DepartmentID INT
AS
BEGIN
    SELECT COUNT(*) AS TotalEmployees
    FROM Employees
    WHERE DepartmentID = @DepartmentID;
END;
GO

-- Execute the procedure for DepartmentID = 1 (HR)
EXEC sp_CountEmployeesByDepartment @DepartmentID = 1;
