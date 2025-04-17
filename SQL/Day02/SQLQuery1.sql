create database BookStoreDB;

use BookStoreDB;

create table Books (
	BookID int PRIMARY KEY,
	Title varchar(100),
	Author varchar(50),
	PublishedYear int,
	Price decimal
)

INSERT INTO Books (BookID, Title, Author, PublishedYear, Price) VALUES
(6, 'The Road', 'Cormac McCarthy', 1975, 140.99),
(7, 'Atonement', 'Ian McEwan', 1980, 120.50),
(8, 'The Amazing Adventures of Kavalier & Clay', 'Michael Chabon', 2000, 180.00),
(9, 'The Book Thief', 'Markus Zusak', 2005, 130.99),
(10, 'The Help', 'Kathryn Stockett', 1999, 160.99);

UPDATE Books
SET Price = 15.99
WHERE Title = 'Atonement';

delete from Books where Author='Ian McEwan';

select * from Books order by PublishedYear;

select * from Books where PublishedYear < 2000;