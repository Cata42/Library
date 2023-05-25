USE MASTER;

GO

DROP DATABASE IF EXISTS LibraryDB;

GO

CREATE DATABASE LibraryDB;

GO

USE LibraryDB;

GO

-- TABLES

CREATE TABLE Genre (
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	"Name" VARCHAR(255) UNIQUE NOT NULL
);

GO

INSERT INTO Genre ("Name")
VALUES
  ('Fiction'),
  ('Mystery'),
  ('Science Fiction'),
  ('Romance'),
  ('Fantasy'),
  ('Science'),
  ('Biology'),
  ('History'),
  ('Thriller'),
  ('Horror'),
  ('Poetry'),
  ('Comedy'),
  ('Self-Help'),
  ('Business'),
  ('Cooking'),
  ('Travel'),
  ('Art'),
  ('Music'),
  ('Sports'),
  ('Biography');

GO

CREATE TABLE Book (
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	Title VARCHAR(255) NOT NULL,
	Author VARCHAR(255) NOT NULL,
	PublishingHouse VARCHAR(255) NOT NULL,
	ReleaseYear INT NOT NULL, 
	Price FLOAT NOT NULL,
	Genre INT FOREIGN KEY REFERENCES Genre(Id) NOT NULL
);

GO

CREATE TABLE Reader (
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	"Name" VARCHAR(255) NOT NULL,
	"Address" VARCHAR(255) NOT NULL,
	PhoneNumber VARCHAR(15) NOT NULL
);

GO

CREATE TABLE Rent (
	Id INT IDENTITY(1, 1) PRIMARY KEY,
	Book INT FOREIGN KEY REFERENCES Book(Id) NOT NULL,
	Reader INT FOREIGN KEY REFERENCES Reader(Id) NOT NULL,
	RentDate DATE NOT NULL,
	ExpectedReturnDate DATE NOT NULL,
	ReturnDate DATE
);

GO

-- /TABLES

-- TASKS

CREATE VIEW ReaderRentBookGenre AS
SELECT b.Title AS Book,
	   b.Author,
	   b.Price,
	   b.PublishingHouse,
	   b.ReleaseYear,
	   g.Name AS Genre,
	   rd.Name AS Reader,
	   rd.PhoneNumber,
	   rd.Address,
	   rt.RentDate,
	   rt.ExpectedReturnDate,
	   rt.ReturnDate
FROM Reader rd
INNER JOIN Rent rt ON rd.Id = rt.Reader
INNER JOIN Book b ON rt.Book = b.Id
INNER JOIN Genre g ON b.Genre = g.Id

GO

CREATE VIEW RentBookGenre AS
SELECT b.Title AS Book,
	   b.Author,
	   b.Price,
	   b.PublishingHouse,
	   b.ReleaseYear,
	   g.Name AS Genre,
	   rt.RentDate,
	   rt.ExpectedReturnDate,
	   rt.ReturnDate
FROM Rent rt
INNER JOIN Book b ON rt.Book = b.Id
INNER JOIN Genre g ON b.Genre = g.Id

GO

CREATE VIEW BookGenre AS
SELECT b.Title AS Book,
	   b.Author,
	   b.Price,
	   b.PublishingHouse,
	   b.ReleaseYear,
	   g.Name AS Genre
FROM Book b
INNER JOIN Genre g ON b.Genre = g.Id

GO

-- /TASKS

CREATE LOGIN gigel
	WITH PASSWORD = 'gigel';

GO

CREATE USER gigel FOR LOGIN gigel;