create table IRBook(
id int NOT NULL IDENTITY(1,1) primary key,
std_enroll varchar(250) not null,
std_name varchar(250) not null,
std_dep varchar(250) not null,
std_sem varchar(250) not null,
std_contact bigint not null,
std_email varchar(250) not null,
book_name varchar(250) not null,
book_issue_date varchar(250) not null,
book_return_date varchar(250)
);

insert into IRBook(std_enroll,std_name,std_dep,std_sem,std_contact,std_email,book_name,book_issue_date,book_return_date) values ('1234567','Defne','Computer Engineering','4.Semester',5000000000,'defne@mail.com','Python','4 Mayýs 2023 Perþembe','10 Mayýs 2023 Çarþamba');

SELECT * FROM IRBook