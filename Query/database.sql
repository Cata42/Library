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

-- /TABLES
