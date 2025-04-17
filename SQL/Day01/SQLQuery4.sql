create database Academy;

use Academy;

create table students(
	StudentID int primary key,
	FirstName varchar(50),
	LastName varchar(50),
	Age int ,
	Grade varchar(1),
);

INSERT INTO students (StudentID, FirstName, LastName, Age, Grade) VALUES
(1, 'Ahmed', 'Mostafa', 20, 'A'), (2, 'Omar', 'Mohamed', 19, 'B'), (3, 'Ahmed', 'Walid', 18, 'C'),
(4, 'Khalid', 'Hassan', 15, 'A'), (5, 'Mohamed', 'Wael', 17, 'B');

select * from students;
select FirstName , LastName from students;
select * from students where Age > 18;
select * from students where Grade = 'A';
