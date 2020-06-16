create database DBProjectStudent
use DBProjectStudent
--drop database DBProjectStudent
create table Student
(	S_ID varchar(20) primary key,
	S_name nvarchar(100),
	S_fullname nvarchar(50),
	S_major nvarchar(50),
	S_birthday datetime,
	S_phone nvarchar(50),
	S_email nvarchar(50),
	P_ID int,
	foreign key (P_ID) references Project(P_ID)
)
create table Lecture
(	L_ID varchar(20) primary key,
	L_name nvarchar(100),
	L_fullname nvarchar(50),
	L_department nvarchar(50),
	L_birthday datetime,
	L_phone nvarchar(50),
	L_email nvarchar(50)
)
create table Project
(
	P_ID int  primary key,
	P_title nvarchar(100),
	P_description nvarchar(200),
	P_fromtime datetime,
	P_totime datetime,
	P_point int,
	L_ID varchar(20),
	foreign key (L_ID) references Lecture(L_ID)
)
create table UserLogin
(
	ID varchar(20)primary key,
	Pass varchar(20),
	roleuser varchar(10),
	foreign key(ID) references Student(S_ID),
	--foreign key(ID) references Lecture(L_ID),
)
create table Progress
(
	P_ID int,
	Progress1 nvarchar(100),
	Progress2 nvarchar(100),
	Progress3 nvarchar(100),
	Progress4 nvarchar(100),
	LinkSource varchar(100),
	
)