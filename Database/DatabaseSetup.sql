-- Database setup script for Reporting System

CREATE DATABASE IF NOT EXISTS ReportingSystem;
USE ReportingSystem;

-- Table for Raw Material Reports
CREATE TABLE IF NOT EXISTS RawMaterialReports (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    MaterialName VARCHAR(255) NOT NULL,
    Quantity INT NOT NULL,
    ReportDate DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Inserting test data into Raw Material Reports
INSERT INTO RawMaterialReports (MaterialName, Quantity) VALUES
('Steel', 1000),
('Copper', 500),
('Aluminum', 200);

-- Table for Finished Product Reports
CREATE TABLE IF NOT EXISTS FinishedProductReports (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    ProductName VARCHAR(255) NOT NULL,
    Quantity INT NOT NULL,
    ReportDate DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Inserting test data into Finished Product Reports
INSERT INTO FinishedProductReports (ProductName, Quantity) VALUES
('Engine', 150),
('Transmission', 75),
('Chassis', 200);

-- Table for Production Reports
CREATE TABLE IF NOT EXISTS ProductionReports (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    ReportDate DATETIME DEFAULT CURRENT_TIMESTAMP,
    TotalRawMaterialsUsed INT,
    TotalFinishedProducts INT
);

-- Inserting test data into Production Reports
INSERT INTO ProductionReports (TotalRawMaterialsUsed, TotalFinishedProducts) VALUES
(2000, 150),
(1800, 120);

-- Table for Report Types
CREATE TABLE IF NOT EXISTS ReportTypes (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    TypeName VARCHAR(255) NOT NULL
);

-- Inserting test data into Report Types
INSERT INTO ReportTypes (TypeName) VALUES
('Daily'),
('Weekly'),
('Monthly');

-- Table for Silo Configurations
CREATE TABLE IF NOT EXISTS SiloConfigurations (
    ID INT AUTO_INCREMENT PRIMARY KEY,
    SiloName VARCHAR(255) NOT NULL,
    Capacity INT NOT NULL
);

-- Inserting test data into Silo Configurations
INSERT INTO SiloConfigurations (SiloName, Capacity) VALUES
('Silo A', 10000),
('Silo B', 15000);
