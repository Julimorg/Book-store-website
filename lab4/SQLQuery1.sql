CREATE DATABASE BookStore;
go
use BookStore;
go

create table Publisher(
	publisher_id int identity(1,1) not null,
	publisher_name nvarchar(50) not null
	primary key (publisher_id));

go

create table Book(
	book_id int identity(1,1) not null,
	publisher_id int,
	book_name nvarchar(100) not null,
	image varchar(50),
	price decimal(18,0),
	update_date smalldatetime,
	quantity_instock int,
	primary key(book_id),
	foreign key(publisher_id) references Publisher);
	

insert into Publisher(publisher_name) values (N'publisher 1')
insert into Publisher(publisher_name) values (N'publisher 2')
insert into Publisher(publisher_name) values (N'publisher 3')
insert into Publisher(publisher_name) values (N'publisher 4')
select * from Publisher

insert into Book (publisher_id, book_name, image, price, update_date, quantity_instock) values 
(1, N'Title book 1', '/Content/images/book1.jpg', 3, '12-09-2023 00:00:00', 20),
(2, N'Title book 2', '/Content/images/book2.jpg', 3, '12-09-2023 00:00:00', 20),
(3, N'Title book 3', '/Content/images/book3.jpg', 3, '12-09-2023 00:00:00', 20),
(4, N'Title book 4', '/Content/images/book4.jpg', 3, '12-09-2023 00:00:00', 20);
select * from Book
