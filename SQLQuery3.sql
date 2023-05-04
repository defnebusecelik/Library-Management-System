create table NewStudent(
stuid int NOT NULL IDENTITY(1,1) primary key,
sname varchar(250) not null,
enroll varchar(250) not null,
dep varchar(250) not null,
sem varchar(250) not null,
contact bigint not null,
email varchar(250) not null)

insert into NewStudent(sname,enroll,dep,sem,contact,email) values ('Defne','1234567','Computer Engineering','4.Semester',5000000000,'defne@mail.com');

select * from NewStudent