CREATE SCHEMA census
GO

CREATE TABLE census.Residents(
	ResidentID INT IDENTITY PRIMARY KEY,
	FirstName VARCHAR(256) NOT NULL,
	MiddleName VARCHAR(256) NULL,
	LastName VARCHAR(256) NOT NULL,
	Age VARCHAR(256) NOT NULL,
	Sex VARCHAR(256) NOT NULL,
	Race VARCHAR(256) NOT NULL
)
GO

CREATE TABLE census.Regions(
	RegionID INT IDENTITY PRIMARY KEY,
	RegionDesc VARCHAR(512) NOT NULL
)
GO

CREATE TABLE census.Employees(
	EmployeeID INT IDENTITY PRIMARY KEY,
	FirstName VARCHAR(256) NOT NULL,
	LastName VARCHAR(256) NOT NULL,
	Position VARCHAR(256) NOT NULL,
	Salary VARCHAR(256) NOT NULL,
	ManagerID INT NULL FOREIGN KEY REFERENCES census.Employees (EmployeeID)
)
GO

CREATE TABLE census.Addresses(
	AddressID INT IDENTITY PRIMARY KEY,
	AddressType VARCHAR(256) NOT NULL,
	Number VARCHAR(128) NOT NULL,
	Street VARCHAR(256) NOT NULL,
	City VARCHAR(256) NOT NULL,
	State VARCHAR(256) NOT NULL,
	ZipCode VARCHAR(256) NOT NULL,
	RegionID INT NOT NULL FOREIGN KEY REFERENCES census.Regions (RegionID)
)
GO

CREATE TABLE census.Assignments(
	EmployeeID INT NOT NULL FOREIGN KEY REFERENCES census.Employees (EmployeeID),
	RegionID INT NOT NULL FOREIGN KEY REFERENCES census.Regions (RegionID),
	PRIMARY KEY(EmployeeID, RegionID)
)
GO

CREATE TABLE census.ResidentAddress(
	ResidentID INT NOT NULL FOREIGN KEY REFERENCES census.Residents (ResidentID),
	AddressID INT NOT NULL FOREIGN KEY REFERENCES census.Addresses (AddressID),
	ResidentStatus VARCHAR(256) NULL, --Owner/Rentor/Resident/etc
	PRIMARY KEY (ResidentID, AddressID)
)
GO