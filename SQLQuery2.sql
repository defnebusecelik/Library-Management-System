create database master
create table NewBook(
bid int NOT NULL IDENTITY(1,1) primary key,
bName varchar(250) not null,
bAuthor varchar(250) not null,
bPubl varchar(250) not null,
bPDate varchar(250) not null,
bPrice bigint not null,
bQuan bigint not null)

insert into NewBook(bName,bAuthor,bPubl,bPDate,bPrice,bQuan) values ('Java','PK Singh','PK Publication','Monday,April 20,2020',500,30);


SELECT * FROM NewBook
