Drop database if exists ContactManager;
CREATE DATABASE ContactManager;

USE ContactManager;

CREATE TABLE Contacts (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    Email NVARCHAR(50) NOT NULL,
    Phone NVARCHAR(20) NOT NULL,
);
CREATE TABLE Suppliers (
Id INT IDENTITY(1,1) PRIMARY KEY,
	Name NVARCHAR(50) NOT NULL,
	Email NVARCHAR(50) NOT NULL,
	Phone NVARCHAR(20) NOT NULL,
	CodeScn NVARCHAR(20) NOT NULL
);
