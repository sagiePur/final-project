
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 01/26/2020 13:02:42
-- Generated from EDMX file: C:\Users\Owner\Desktop\final-project\WpfApp1\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [db];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_Employees_ToType ]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Employees] DROP CONSTRAINT [FK_Employees_ToType ];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[employee_type_id]', 'U') IS NOT NULL
    DROP TABLE [dbo].[employee_type_id];
GO
IF OBJECT_ID(N'[dbo].[Employees]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Employees];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'employee_type_id'
CREATE TABLE [dbo].[employee_type_id] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [license] nvarchar(50)  NOT NULL
);
GO

-- Creating table 'Employees'
CREATE TABLE [dbo].[Employees] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [name_] nvarchar(50)  NOT NULL,
    [telephone] nvarchar(50)  NOT NULL,
    [address] nvarchar(50)  NOT NULL,
    [employee_type_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'employee_type_id'
ALTER TABLE [dbo].[employee_type_id]
ADD CONSTRAINT [PK_employee_type_id]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [PK_Employees]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [employee_type_id] in table 'Employees'
ALTER TABLE [dbo].[Employees]
ADD CONSTRAINT [FK_Employees_ToType_]
    FOREIGN KEY ([employee_type_id])
    REFERENCES [dbo].[employee_type_id]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_Employees_ToType_'
CREATE INDEX [IX_FK_Employees_ToType_]
ON [dbo].[Employees]
    ([employee_type_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------