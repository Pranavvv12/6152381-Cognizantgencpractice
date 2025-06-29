-- Create Scalar Function to calculate annual salary
CREATE FUNCTION fn_CalculateAnnualSalary (@EmpID INT)
RETURNS DECIMAL(12,2)
AS
BEGIN
    DECLARE @AnnualSalary DECIMAL(12,2);
    SELECT @AnnualSalary = Salary * 12
    FROM Employees
    WHERE EmployeeID = @EmpID;
    
    RETURN @AnnualSalary;
END;
GO

-- Execute function for EmployeeID = 1
SELECT dbo.fn_CalculateAnnualSalary(1) AS AnnualSalary;
