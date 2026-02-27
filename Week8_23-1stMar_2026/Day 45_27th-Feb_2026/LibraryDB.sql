-- Create Database
CREATE DATABASE LibraryDB;
USE LibraryDB;

-- Authors Table
CREATE TABLE Authors (
    AuthorId INT PRIMARY KEY IDENTITY(1,1),
    AuthorName NVARCHAR(100) NOT NULL
);

-- Books Table
CREATE TABLE Books (
    BookId INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(200),
    AuthorId INT,
    PublishedYear INT
);

-- Members Table
CREATE TABLE Members (
    MemberId INT PRIMARY KEY IDENTITY(1,1),
    MemberName NVARCHAR(100),
    Email NVARCHAR(100)
);

-- BorrowRecords Table
CREATE TABLE BorrowRecords (
    RecordId INT PRIMARY KEY IDENTITY(1,1),
    MemberId INT,
    BookId INT,
    BorrowDate DATE,
    ReturnDate DATE
);


-- Insert Authors
INSERT INTO Authors (AuthorName) VALUES ('J.K. Rowling'), ('George Orwell'), ('Jane Austen');

-- Insert Books
INSERT INTO Books (Title, AuthorId, PublishedYear) VALUES
('Harry Potter', 1, 1997),
('1984', 2, 1949),
('Pride and Prejudice', 3, 1813);

-- Insert Members
INSERT INTO Members (MemberName, Email) VALUES
('Alice Johnson', 'alice@library.com'),
('Bob Smith', 'bob@library.com');

-- Insert BorrowRecords
INSERT INTO BorrowRecords (MemberId, BookId, BorrowDate, ReturnDate) VALUES
(1, 1, '2026-01-01', '2026-01-15'),
(2, 2, '2026-02-01', NULL);

-- stored procedures
-----------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE [dbo].[CreateBook]
    @Title NVARCHAR(200),
    @AuthorId INT,
    @PublishedYear INT
AS
BEGIN
    INSERT INTO Books (Title, AuthorId, PublishedYear)
    VALUES (@Title, @AuthorId, @PublishedYear);

    SELECT SCOPE_IDENTITY() AS NewBookId;
END;
-----------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE [dbo].[GetAllBooks]
AS
BEGIN
    SELECT *
    FROM Books;
END;
-----------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE [dbo].[DeleteBook]
    @BookId INT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION;

        DELETE FROM Books
        WHERE BookId = @BookId;

        COMMIT TRANSACTION;
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION;
        THROW;
    END CATCH
END;
-----------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE [dbo].[UpdateBook]
    @BookId INT,
    @Title NVARCHAR(200),
    @AuthorId INT,
    @PublishedYear INT
AS
BEGIN
    UPDATE Books
    SET
        Title = @Title,
        AuthorId = @AuthorId,
        PublishedYear = @PublishedYear
    WHERE BookId = @BookId;
END;
-----------------------------------------------------------------------------------------
-----------------------------------------------------------------------------------------
CREATE OR ALTER PROCEDURE [dbo].[GetBookByID]
    @BookId INT
AS
BEGIN
    SELECT *
    FROM Books
    WHERE BookId = @BookId;
END;