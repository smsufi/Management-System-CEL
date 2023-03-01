create database StdDB

use StdDB

create table adminTab(
	admId int identity(2023001,1) primary key,
	admName varchar(50),
	admMobile bigint,
	admEmail varchar (100),
	admPassword varchar(20)
);

drop table adminTab;

insert into adminTab values ('sufi', 012345678900, 'sufi@gmail.com', 'password');

select * from adminTab;


create table studentTab(
	stdID int identity(180104001,1) primary key,
	stdName varchar(50),
	stdDept varchar(3),
	stdSem float,
	stdCgpa float,
	stdPhone bigint,
	stdEmail varchar(100),
	stdPassword varchar(20),
	stdGender varchar(6),
	stdDob date
);

drop table studentTab;

begin transaction
insert into studentTab values ('mash', 'CSE', 4.2, 3.5, 9876543210, 'mash@gmail.com', 'nopassword', 'Male', '1998-02-26');
insert into studentTab values ('kaho', 'CSE', 4.1, 3.7, 123456789, 'kaho@gmail.com', 'password', 'Male', '1998-03-25');
commit;

update studentTab set stdName = 'mashh' where stdID = 180104002;

select * from studentTab;
